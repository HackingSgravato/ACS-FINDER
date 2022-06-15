using System;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Global
{
    class App
    {
        public static Task Init()
        {
            try { Directory.Delete(AppInfo.acsFinderPath, true); } catch (Exception) { }

            try
            {
                Directory.CreateDirectory(AppInfo.acsFinderPath);
                Directory.CreateDirectory(AppInfo.dumpStuffPath);
                Directory.CreateDirectory(AppInfo.processesDump);
                Directory.CreateDirectory(AppInfo.assetsPath);
                Directory.CreateDirectory(AppInfo.mfResultsPath);
                Directory.CreateDirectory(AppInfo.stringFinderPath);
                Directory.CreateDirectory(AppInfo.stringFinderResultsPath);
                Directory.CreateDirectory(AppInfo.singleProcessesDump);
            } catch (Exception e) { MessageBox.Show("Something went wrong. \n\n\n\n" + e.ToString()); Environment.Exit(0); }

            try
            {
                byte[] s2 = Acs_Finder.Properties.Resources.s2;

                File.WriteAllBytes(AppInfo.s2Filename, s2);
            } catch (Exception e) { MessageBox.Show("Something went wrong. \n\n\n\n" + e.ToString()); Environment.Exit(0); }

            return Task.CompletedTask;
        }
        public static void Exit()
        {
            try { Directory.Delete(AppInfo.acsFinderPath, true); }catch (Exception) { }
        }
    }
}
