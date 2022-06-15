using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Threading;
using Global;
using System.Text.RegularExpressions;

// vorrei tanto ringraziare chi ha fatto questo dumper ma non ho trovato l'autore né la source: avevo il .exe in una cartella abbandonata nel disco D.
// (Ho preso la classe e riportata qua per effettuare delle modifiche)

// ho modificato varie cose fra cui il dump degli svchost dato che non mi prendeva i pid correttamente

namespace Global
{
	class Dumper
	{
		public Dumper(out string ElapsedMilliseconds)
        {
			Directory.Delete(AppInfo.processesDump, true);
			File.Delete(svchostlogPath);

			Directory.CreateDirectory(AppInfo.processesDump);

			sw = new Stopwatch();

			Start(out ElapsedMilliseconds);
		}

		public static void Start(out string ElapsedMilliseconds)
		{
			runCommand("cd C:\\ProgramData\\AcsFinder\\DumpStuff\\assets & tasklist /svc | find \"svchost.exe\" > C:\\ProgramData\\AcsFinder\\DumpStuff\\assets\\svchost.log");
			Thread.Sleep(500);
			sw.Start();
			getSvchost();
			dumpSvchost();
			dumpProcesses();
			Thread.Sleep(1000);
			Process[] processesByName = Process.GetProcessesByName("dumper");
			int num = processesByName.Length;
			foreach (Process process in processesByName)
			{
				while (num != 0)
				{
					if (!getParent(process.Id).Equals(Process.GetCurrentProcess().ProcessName))
					{
						num--;
					}
				}
			}

			ElapsedMilliseconds = sw.ElapsedMilliseconds.ToString();
		}

		public static void AddException(string pName)
        {
			exclusionList.Add(pName);
        }

		private static void dumpProcesses()
		{
			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				Process p = processes[i];
				new Thread(delegate ()
				{
					try
					{
						if (!exclusionList.Contains(p.ProcessName))
						{
							if (!Directory.Exists($"{AppInfo.processesDump}\\" + p.ProcessName))
							{
								Directory.CreateDirectory($"{AppInfo.processesDump}\\" + p.ProcessName);
							}
							runCommand(string.Format("\"{0}assets\\\"dumper.exe -pid {1} -l 4 -nh {2} > \"{3}dumps\\{4}\\\"{5}_{6}.txt", new object[]
							{
								path,
								p.Id,
								additionalCommands,
								path,
								p.ProcessName,
								p.ProcessName,
								r.Next(0, 999999999)
							}));
						}
					}
					catch
					{
						Console.WriteLine("Failed to dump process \"" + p.ProcessName + "\"");
					}
				}).Start();
			}
		}

		private static void dumpSvchost()
		{
			if (!Directory.Exists($"{AppInfo.processesDump}\\svchost"))
			{
				Directory.CreateDirectory($"{AppInfo.processesDump}\\svchost");
			}
			using (List<int>.Enumerator enumerator = svchostList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					int service = enumerator.Current;
					new Thread(delegate ()
					{
						try
						{
							if (!Directory.Exists($"{AppInfo.processesDump}\\svchost\\" + service))
							{
								Directory.CreateDirectory($"{AppInfo.processesDump}\\svchost\\" + service);
							}
							runCommand(string.Format("\"{0}assets\\\"dumper.exe -pid {1} > \"{3}dumps\\svchost\\{4}\\\"{5}_{6}.txt", new object[]
							{
								path,
								service,
								additionalCommands,
								path,
								service,
								"svchostPid" + service,
								r.Next(0, 999999999)
							}));
						}
						catch
						{
							Console.WriteLine("Failed to dump service (pid: " + service + ")");
						}
					}).Start();
				}
			}
		}


		private static void getSvchost()
		{
			foreach (string line in File.ReadAllLines(svchostlogPath))
            {
				svchostList.Add(getPID(line));
            }


			//{
			//	'\n'
			//}))
			//{
			//	if (line.Length > 5)
			//	{
			//		string text2 = line.Substring(35).Replace(" ", "").Replace(",", ".");
			//		svchostList.Add(text2.Substring(0, text2.Length - 1));
			//	}
			//}
		}

		static Regex regexPid = new Regex(@"[0-9]+");
		public static int getPID(string pName)
        {
			int pid = Convert.ToInt32(regexPid.Match(NormalizeString(pName)).Value);

			return pid;
        }

		public static string NormalizeString(string pName)
        {
			string newPname = pName.Replace("svchost.exe", string.Empty);
			string noWhiteSpaces = newPname.Trim();

			return noWhiteSpaces;
		}

		public static void runCommand(string command)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.UseShellExecute = false;
			process.Start();
			process.StandardInput.WriteLine(command);
			process.StandardInput.Flush();
			process.StandardInput.Close();
		}

		private static string getParent(int pid)
		{
			string result;
			try
			{
				string queryString = string.Format("SELECT ParentProcessId FROM Win32_Process WHERE ProcessId = {0}", pid);
				ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementObjectSearcher("root\\CIMV2", queryString).Get().GetEnumerator();
				enumerator.MoveNext();
				result = Process.GetProcessById((int)((uint)enumerator.Current["ParentProcessId"])).ProcessName;
			}
			catch (Exception)
			{
				result = "prolly died so is fine";
			}
			return result;
		}

		private static uint getService(string serviceName)
		{
			uint result = 0U;
			foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT PROCESSID FROM WIN32_SERVICE WHERE NAME = '" + serviceName + "'").Get())
			{
				result = (uint)((ManagementObject)managementBaseObject)["PROCESSID"];
			}
			return result;
		}

		private static Random r = new Random();

		private static Stopwatch sw;

		private static List<int> svchostList = new List<int>();

		//private static string[] exclusionList = new string[]
		//{
		//	"svchost",
		//	"cmd",
		//	"chrome",
		//	"opera",
		//	"firefox",
		//	"discord"
		//};

		private static List<string> exclusionList = new List<string>()
        {
			"svchost",
            "cmd",
            "chrome",
            "opera",
            "firefox",
            "discord"
        };

		private static string additionalCommands = "";

		private static string path = AppInfo.dumpStuffPath + "\\";

		public static string svchostlogPath = AppInfo.assetsPath + "\\" + "svchost.log";
	}
}
