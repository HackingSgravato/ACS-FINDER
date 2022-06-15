using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Global;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;

namespace Acs_Finder
{
    public partial class AcsFinderMain : MaterialForm
    {
        public AcsFinderMain()
        {
            InitializeComponent();
        }

        #region string finder stuff

        #region dump a single specific process stuff
        private void DumpSelectedProcessButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SelectedProcess.Text)) { MessageBox.Show("You must had submitted the process name to continue."); return; }

            MemoryDump.DumpProcessByName(SelectedProcess.Text, prefix.Text);

        }

        #endregion

        private void OpenResultsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(AppInfo.stringFinderResultsPath);
        }

        private void OpenSingleDumpResultsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(AppInfo.singleProcessesDump);
        }

        #region variables
        private string legitFilename { get; set; } = String.Empty;
        private string unlegitFilename { get; set; } = String.Empty;
        private string exceptionsFilename { get; set; } = String.Empty;

        #endregion

        #region check differences + save scan

        StreamWriter writer;
        private string result { get; set; }

        IEnumerable<string> unlegitLines;

        private void CheckDifferences_Click(object sender, EventArgs e)
        {
            if (legitFilename.Equals(String.Empty) || unlegitFilename.Equals(String.Empty)) { MessageBox.Show("You must had selected TXTs before scanning."); return; }

            if (IsExceptionsOnButton.Checked) // exceptions enabled
            {
                if (exceptionsFilename.Equals(null)) { MessageBox.Show("You must had selected Exceptions File before scanning or you can disable the exceptions."); return; }

                unlegitLines = File.ReadAllLines(unlegitFilename).Except(File.ReadAllLines(legitFilename)).Except(File.ReadAllLines(exceptionsFilename));

                // to prevent overwriting an existing file
                do
                {
                    result = AppInfo.stringFinderResultsPath + "\\" + "result-" + StringUtils.RandomNumbers() + ".txt";

                } while (File.Exists(result));

                writer = new StreamWriter(result);
                writer.WriteLine(String.Join(Environment.NewLine, unlegitLines));
                writer.Close();

                Process.Start(result);
            }
            else // exceptions disabled
            {
                unlegitLines = File.ReadAllLines(unlegitFilename).Except(File.ReadAllLines(legitFilename));

                do
                {
                    result = AppInfo.stringFinderResultsPath + "\\" + "result-" + StringUtils.RandomNumbers() + ".txt";

                } while (File.Exists(result));

                
                writer = new StreamWriter(result);
                writer.WriteLine(String.Join(Environment.NewLine, unlegitLines));
                writer.Close();

                Process.Start(result);
            }
        }

        #endregion

        #region take files
        private void LegitButton_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog().Equals(DialogResult.OK)) { legitFilename = fileBrowser.FileName; MessageBox.Show($"You've selected \"{fileBrowser.FileName}\" file"); return; }

            MessageBox.Show("Try again.");
        }

        private void UnlegitButton_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog().Equals(DialogResult.OK)) { unlegitFilename = fileBrowser.FileName; MessageBox.Show($"You've selected \"{fileBrowser.FileName}\" file"); return; }

            MessageBox.Show("Try again.");
        }

        private void ExceptionsButton_Click(object sender, EventArgs e)
        {
            if (fileBrowser.ShowDialog().Equals(DialogResult.OK)) { exceptionsFilename = fileBrowser.FileName; MessageBox.Show($"You've selected \"{fileBrowser.FileName}\" file"); return; }

            MessageBox.Show("Try again.");
        }
        #endregion

        private void IsExceptionsOnButton_CheckStateChanged(object sender, EventArgs e)
        {
            ExceptionsButton.Visible = !ExceptionsButton.Visible;
        }

        #region Enabling drag&drop

        // legit
        private void LegitButton_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            legitFilename = files[0]; MessageBox.Show($"You've selected \"{fileBrowser.FileName}\" file");
        }

        private void LegitButton_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        // unlegit
        private void UnlegitButton_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            unlegitFilename = files[0]; MessageBox.Show($"You've selected \"{fileBrowser.FileName}\" file");
        }

        private void UnlegitButton_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        // exceptions
        private void ExceptionsButton_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            exceptionsFilename = files[0]; MessageBox.Show($"You've selected \"{fileBrowser.FileName}\" file");
        }

        private void ExceptionsButton_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        #endregion

        #endregion


        #region method finder stuff

        SearchString searchString;
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextToSearch.Text)) { MessageBox.Show("You must had digited some text to search to continue."); return; }

            if (DirectoryUtils.IsDirectoryEmpty(AppInfo.processesDump)) { MessageBox.Show("You must had dumped the processes to continue."); return; }

            string result = AppInfo.mfResultsPath + "\\" + "result-" + StringUtils.RandomNumbers() + ".txt";

            string ElapsedMilliseconds;

            searchString = new SearchString(AppInfo.processesDump, result, out ElapsedMilliseconds, TextToSearch.Text);

            MessageBox.Show("Finished searching your text in processes dumped memories in " + ElapsedMilliseconds + "ms");

            Process.Start(result);
        }

        private void OpenMfResultsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(AppInfo.mfResultsPath);
        }

        Dumper dumper;

        private void IsAdvancedOnButton_CheckStateChanged(object sender, EventArgs e)
        {
            SelectedProcessException.Visible = !SelectedProcessException.Visible;
            AddProcessExceptionButton.Visible = !AddProcessExceptionButton.Visible;
        }
        private void AddProcessExceptionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SelectedProcessException.Text)) { MessageBox.Show("Digit a process name."); return; }

            Dumper.AddException(SelectedProcessException.Text);
        }

        private void LoadDumperButton_Click(object sender, EventArgs e)
        {
            string ElapsedMilliseconds = String.Empty;

            dumper = new Dumper(out ElapsedMilliseconds);

            MessageBox.Show("Finished dumping all system processes & services in " + ElapsedMilliseconds);
        }

        #endregion

        private void AcsFinderMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            App.Exit();
        }

        #region credits stuff
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserUtils.OpenLink(@"https://icons8.it/app/windows");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserUtils.OpenLink(@"https://github.com/winsiderss/systeminformer");
            BrowserUtils.OpenLink(@"https://processhacker.sourceforge.io");
            BrowserUtils.OpenLink(@"https://github.com/andyvand/ProcessHacker/tree/master/1.x/trunk");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserUtils.OpenLink(@"https://www.mediafire.com/file/3582e6gyenjghjk/processes_dumper.rar/file");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserUtils.OpenLink(@"https://github.com/MrCreeper2010/SMTool");
            BrowserUtils.OpenLink(@"https://www.mediafire.com/file/u5gjdbuackppk8g/c%2523_PH_libs.rar/file");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BrowserUtils.OpenLink(@"https://github.com/negrifelipe/DiscordMessenger");
            BrowserUtils.OpenLink(@"https://www.youtube.com/watch?v=D6nwwK6zbWU");
        }

        #endregion

        #region bug reporting stuff
        private void SendBug_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bugDescription.Text)) { MessageBox.Show("You must had described the bug to send it."); return; }

            if (BrowserUtils.SendMessageToDiscord(bugDescription.Text)) { MessageBox.Show("Report submitted."); return; }

            MessageBox.Show("Something went wrong.");
        }

        #endregion

        #region socials stuff
        private void DiscordButton_Click(object sender, EventArgs e)
        {
            BrowserUtils.OpenLink(@"https://discord.gg/nJx6tN5rS5");
        }

        private void TelegramChannelButton_Click(object sender, EventArgs e)
        {
            BrowserUtils.OpenLink(@"https://t.me/AntiCheatingSquad");
        }

        private void TelegramDeveloperButton_Click(object sender, EventArgs e)
        {
            BrowserUtils.OpenLink(@"https://t.me/VisualStudio2022");
        }

        private void ProjectSourceButton_Click(object sender, EventArgs e)
        {
            BrowserUtils.OpenLink(@"https://github.com/HackingSgravato/ACS-FINDER/releases/tag/v1.9-beta");
        }

        #endregion

    }
}
