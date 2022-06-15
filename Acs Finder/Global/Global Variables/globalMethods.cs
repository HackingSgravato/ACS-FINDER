using System;
using System.Text;
using System.Diagnostics;
using DiscordMessenger;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Global
{
    class MemoryDump
    {
        static string path = AppInfo.dumpStuffPath + "\\";
        static string resultPath = AppInfo.singleProcessesDump;
        static Stopwatch sw;
        public static void DumpProcessByName(string pName, string prefix)
        {
            sw = new Stopwatch();
            sw.Start();

            // check if is a svchost service...

            // blocco di codice preso da dumperClass.cs e modificato secondo le necessità
            Dumper.runCommand("tasklist /svc | find \"svchost.exe\" > C:\\ProgramData\\AcsFinder\\DumpStuff\\assets\\svchost.log");
            Thread.Sleep(500);
            var process = File.ReadAllLines(Dumper.svchostlogPath).Where((line) => line.ToLower().Contains(pName.ToLower()));
            if (process.Any())
            {
                string filename = prefix + pName + "_" + StringUtils.RandomNumbers() + ".txt";
                Dumper.runCommand(string.Format("\"{0}assets\\\"dumper.exe -pid {1} > \"{2}\\\"{3}", new object[]
                            {
                                path,
                                Dumper.getPID(process.ToArray()[0]),
                                resultPath,
                                filename
                            }));

                sw.Stop();
                MessageBox.Show("The process memory was dumped in " + sw.ElapsedMilliseconds + "ms");
                MessageBox.Show("If you can't find the txt it's because the process wasn't found and if the txt is empty it's because the memory dump was failed bacause of the application or user permissions.");

                return;
            }

            // ... or a process

            Process[] processes = FindProcess(pName);

            // blocco di codice preso da dumperClass.cs e modificato secondo le necessità
            for (int i = 0; i < processes.Length; i++)
            {
                Process p = processes[i];
                new Thread(delegate ()
                {
                    try
                    {
                        string filename = prefix + p.ProcessName + "_" + StringUtils.RandomNumbers() + ".txt";

                         Dumper.runCommand(string.Format("\"{0}assets\\\"dumper.exe -pid {1} -l 4 -nh {2} > \"{3}\\\"{4}", new object[]
                            {
                                path,
                                p.Id,
                                "",
                                resultPath,
                                filename
                            }));
                    }
                    catch
                    {
                        MessageBox.Show("Failed to dump process \"" + p.ProcessName + "\"");
                    }
                }).Start();
            }

            sw.Stop();
            MessageBox.Show("The process memory was dumped in " + sw.ElapsedMilliseconds + "ms");
            MessageBox.Show("If you can't find the txt it's because the process wasn't found and if the txt is empty it's because the memory dump was failed bacause of the application or user permissions.");
        }

        static Process[] FindProcess(string pName)
        {
            return Process.GetProcessesByName(pName).Where((_pname) => _pname.ProcessName.ToLower().Contains(pName.ToLower())).ToArray();
        }
    }

    class StringUtils
    {
        // thanks to process hacker libs
        static Random random = new Random((int)(99999999));
        public static string RandomNumbers(int spin = 1)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < spin; i++) builder.Append(random.Next());

            return builder.ToString();
        }

        public static string RemovePathFromFilename(string filename)
        {
            int i = filename.LastIndexOf('\\');
            return filename.Substring(i + 1);
        }
    }

    class BrowserUtils
    {
        public static void OpenLink(string link)
        {
            Process.Start(link);
        }

        public static bool SendMessageToDiscord(string message)
        {
            try
            {
                new DiscordMessage().SetUsername("User Report").AddEmbed().SetDescription(message).Build().SendMessage(@"https://discord.com/api/webhooks/986362212480327680/F4stFMqAwpg8QWf59mLgkcgUwidprQhwqAHjEu_qmEM-oysxEKbBfkrwKR4BMzxyb4uo");

                return true;
            }
            catch { return false; }
        }
    }

    class SearchString
    {
        Stopwatch sw;
        StreamWriter writer;
        public SearchString(string textsPath, string resultFilename, out string ElapsedMilliseconds, string textToSearch)
        {
            writer = new StreamWriter(resultFilename);
            sw = new Stopwatch();
            sw.Start();
            string[] subDirectories = Directory.GetDirectories(textsPath);
            writer.WriteLine("To search a process press ctrl + f and digit \"result from *process name*\".\nIf there isn't result for a process it's because there were 0 matches and if you can find the process it's because there was a problem with the memory dump because of the application or user permissions.\n\n\n");
            Parallel.ForEach<string>(subDirectories, (dir) =>
            {
                foreach (string file in Directory.EnumerateFileSystemEntries(dir))
                {
                    try
                    {
                        if (!FileUtils.isFileEmpty(file)) writer.WriteLine("Result from " + StringUtils.RemovePathFromFilename(file) + "\n" + String.Join(Environment.NewLine, File.ReadAllLines(file).Where<string>((line) => line.ToLower().Contains(textToSearch.ToLower()))));

                    }
                    catch (Exception) { }
                }
            });

            writer.Close();
            sw.Stop();
            ElapsedMilliseconds = sw.ElapsedMilliseconds.ToString();
        }
    }

    class FileUtils
    {
        static FileInfo info;
        public static bool isFileEmpty(string filename)
        {
            info = new FileInfo(filename);
            if (info.Length > 0) return false;

            return true;
        }
    }

    class DirectoryUtils
    {
        // thanks to https://stackoverflow.com/a/954837
        public static bool IsDirectoryEmpty(string path)
        {
            return !Directory.EnumerateFileSystemEntries(path).Any();
        }

    }

}
