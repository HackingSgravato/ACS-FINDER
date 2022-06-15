namespace Acs_Finder
{
    partial class AcsFinderMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcsFinderMain));
            this.menu = new MaterialSkin.Controls.MaterialTabControl();
            this.stringFinderTab = new System.Windows.Forms.TabPage();
            this.OpenResultsFolder = new MaterialSkin.Controls.MaterialButton();
            this.DumpSelectedProcessButton = new MaterialSkin.Controls.MaterialButton();
            this.SelectedProcess = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.ExceptionsButton = new MaterialSkin.Controls.MaterialButton();
            this.IsExceptionsOnButton = new MaterialSkin.Controls.MaterialCheckbox();
            this.UnlegitButton = new MaterialSkin.Controls.MaterialButton();
            this.LegitButton = new MaterialSkin.Controls.MaterialButton();
            this.CheckDifferences = new MaterialSkin.Controls.MaterialButton();
            this.methodFinderTab = new System.Windows.Forms.TabPage();
            this.OpenMfResultsFolder = new MaterialSkin.Controls.MaterialButton();
            this.materialExpansionPanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.AddProcessExceptionButton = new MaterialSkin.Controls.MaterialButton();
            this.SelectedProcessException = new MaterialSkin.Controls.MaterialTextBox2();
            this.SearchButton = new MaterialSkin.Controls.MaterialButton();
            this.TextToSearch = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.IsAdvancedOnButton = new MaterialSkin.Controls.MaterialCheckbox();
            this.LoadDumperButton = new MaterialSkin.Controls.MaterialButton();
            this.creditsTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bugReportTab = new System.Windows.Forms.TabPage();
            this.SendBug = new MaterialSkin.Controls.MaterialButton();
            this.bugDescription = new MaterialSkin.Controls.MaterialTextBox2();
            this.SocialsTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TelegramDeveloperButton = new MaterialSkin.Controls.MaterialButton();
            this.TelegramChannelButton = new MaterialSkin.Controls.MaterialButton();
            this.DiscordButton = new MaterialSkin.Controls.MaterialButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.OpenSingleDumpResultsFolder = new MaterialSkin.Controls.MaterialButton();
            this.prefix = new MaterialSkin.Controls.MaterialComboBox();
            this.ProjectSourceButton = new MaterialSkin.Controls.MaterialButton();
            this.menu.SuspendLayout();
            this.stringFinderTab.SuspendLayout();
            this.methodFinderTab.SuspendLayout();
            this.materialExpansionPanel1.SuspendLayout();
            this.creditsTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bugReportTab.SuspendLayout();
            this.SocialsTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Controls.Add(this.stringFinderTab);
            this.menu.Controls.Add(this.methodFinderTab);
            this.menu.Controls.Add(this.creditsTab);
            this.menu.Controls.Add(this.bugReportTab);
            this.menu.Controls.Add(this.SocialsTab);
            this.menu.Depth = 0;
            this.menu.ImageList = this.imageList1;
            this.menu.Location = new System.Drawing.Point(59, 73);
            this.menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.menu.Multiline = true;
            this.menu.Name = "menu";
            this.menu.SelectedIndex = 0;
            this.menu.Size = new System.Drawing.Size(740, 376);
            this.menu.TabIndex = 0;
            // 
            // stringFinderTab
            // 
            this.stringFinderTab.BackColor = System.Drawing.Color.White;
            this.stringFinderTab.Controls.Add(this.prefix);
            this.stringFinderTab.Controls.Add(this.OpenSingleDumpResultsFolder);
            this.stringFinderTab.Controls.Add(this.OpenResultsFolder);
            this.stringFinderTab.Controls.Add(this.DumpSelectedProcessButton);
            this.stringFinderTab.Controls.Add(this.SelectedProcess);
            this.stringFinderTab.Controls.Add(this.materialDivider1);
            this.stringFinderTab.Controls.Add(this.ExceptionsButton);
            this.stringFinderTab.Controls.Add(this.IsExceptionsOnButton);
            this.stringFinderTab.Controls.Add(this.UnlegitButton);
            this.stringFinderTab.Controls.Add(this.LegitButton);
            this.stringFinderTab.Controls.Add(this.CheckDifferences);
            this.stringFinderTab.ImageKey = "icons8_search_1.ico";
            this.stringFinderTab.Location = new System.Drawing.Point(4, 39);
            this.stringFinderTab.Name = "stringFinderTab";
            this.stringFinderTab.Padding = new System.Windows.Forms.Padding(3);
            this.stringFinderTab.Size = new System.Drawing.Size(732, 333);
            this.stringFinderTab.TabIndex = 0;
            this.stringFinderTab.Text = "String Finder";
            // 
            // OpenResultsFolder
            // 
            this.OpenResultsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenResultsFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenResultsFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenResultsFolder.Depth = 0;
            this.OpenResultsFolder.HighEmphasis = true;
            this.OpenResultsFolder.Icon = null;
            this.OpenResultsFolder.Location = new System.Drawing.Point(545, 293);
            this.OpenResultsFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenResultsFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenResultsFolder.Name = "OpenResultsFolder";
            this.OpenResultsFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenResultsFolder.Size = new System.Drawing.Size(183, 36);
            this.OpenResultsFolder.TabIndex = 8;
            this.OpenResultsFolder.Text = "Open results folder";
            this.OpenResultsFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.OpenResultsFolder.UseAccentColor = false;
            this.OpenResultsFolder.UseVisualStyleBackColor = true;
            this.OpenResultsFolder.Click += new System.EventHandler(this.OpenResultsFolder_Click);
            // 
            // DumpSelectedProcessButton
            // 
            this.DumpSelectedProcessButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DumpSelectedProcessButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DumpSelectedProcessButton.Depth = 0;
            this.DumpSelectedProcessButton.HighEmphasis = true;
            this.DumpSelectedProcessButton.Icon = null;
            this.DumpSelectedProcessButton.Location = new System.Drawing.Point(69, 249);
            this.DumpSelectedProcessButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DumpSelectedProcessButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DumpSelectedProcessButton.Name = "DumpSelectedProcessButton";
            this.DumpSelectedProcessButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DumpSelectedProcessButton.Size = new System.Drawing.Size(64, 36);
            this.DumpSelectedProcessButton.TabIndex = 7;
            this.DumpSelectedProcessButton.Text = "dump";
            this.DumpSelectedProcessButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DumpSelectedProcessButton.UseAccentColor = false;
            this.DumpSelectedProcessButton.UseVisualStyleBackColor = true;
            this.DumpSelectedProcessButton.Click += new System.EventHandler(this.DumpSelectedProcessButton_Click);
            // 
            // SelectedProcess
            // 
            this.SelectedProcess.AnimateReadOnly = false;
            this.SelectedProcess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelectedProcess.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SelectedProcess.Depth = 0;
            this.SelectedProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SelectedProcess.HideSelection = true;
            this.SelectedProcess.LeadingIcon = null;
            this.SelectedProcess.Location = new System.Drawing.Point(69, 195);
            this.SelectedProcess.MaxLength = 32767;
            this.SelectedProcess.MouseState = MaterialSkin.MouseState.OUT;
            this.SelectedProcess.Name = "SelectedProcess";
            this.SelectedProcess.PasswordChar = '\0';
            this.SelectedProcess.PrefixSuffixText = null;
            this.SelectedProcess.ReadOnly = false;
            this.SelectedProcess.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedProcess.SelectedText = "";
            this.SelectedProcess.SelectionLength = 0;
            this.SelectedProcess.SelectionStart = 0;
            this.SelectedProcess.ShortcutsEnabled = true;
            this.SelectedProcess.Size = new System.Drawing.Size(270, 48);
            this.SelectedProcess.TabIndex = 6;
            this.SelectedProcess.TabStop = false;
            this.SelectedProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.SelectedProcess, "Digit the process you wanna dump.");
            this.SelectedProcess.TrailingIcon = null;
            this.SelectedProcess.UseSystemPasswordChar = false;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(69, 179);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(270, 10);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // ExceptionsButton
            // 
            this.ExceptionsButton.AllowDrop = true;
            this.ExceptionsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExceptionsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ExceptionsButton.Depth = 0;
            this.ExceptionsButton.HighEmphasis = true;
            this.ExceptionsButton.Icon = null;
            this.ExceptionsButton.Location = new System.Drawing.Point(230, 22);
            this.ExceptionsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExceptionsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExceptionsButton.Name = "ExceptionsButton";
            this.ExceptionsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ExceptionsButton.Size = new System.Drawing.Size(109, 36);
            this.ExceptionsButton.TabIndex = 4;
            this.ExceptionsButton.Text = "Exceptions";
            this.toolTip1.SetToolTip(this.ExceptionsButton, "You can also drag & drop the file instead of clicking the button");
            this.ExceptionsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ExceptionsButton.UseAccentColor = false;
            this.ExceptionsButton.UseVisualStyleBackColor = true;
            this.ExceptionsButton.Visible = false;
            this.ExceptionsButton.Click += new System.EventHandler(this.ExceptionsButton_Click);
            this.ExceptionsButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.ExceptionsButton_DragDrop);
            this.ExceptionsButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.ExceptionsButton_DragEnter);
            // 
            // IsExceptionsOnButton
            // 
            this.IsExceptionsOnButton.AutoSize = true;
            this.IsExceptionsOnButton.Depth = 0;
            this.IsExceptionsOnButton.Location = new System.Drawing.Point(69, 122);
            this.IsExceptionsOnButton.Margin = new System.Windows.Forms.Padding(0);
            this.IsExceptionsOnButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsExceptionsOnButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsExceptionsOnButton.Name = "IsExceptionsOnButton";
            this.IsExceptionsOnButton.ReadOnly = false;
            this.IsExceptionsOnButton.Ripple = true;
            this.IsExceptionsOnButton.Size = new System.Drawing.Size(111, 37);
            this.IsExceptionsOnButton.TabIndex = 3;
            this.IsExceptionsOnButton.Text = "exceptions";
            this.IsExceptionsOnButton.UseVisualStyleBackColor = true;
            this.IsExceptionsOnButton.CheckStateChanged += new System.EventHandler(this.IsExceptionsOnButton_CheckStateChanged);
            // 
            // UnlegitButton
            // 
            this.UnlegitButton.AllowDrop = true;
            this.UnlegitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UnlegitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UnlegitButton.Depth = 0;
            this.UnlegitButton.HighEmphasis = true;
            this.UnlegitButton.Icon = null;
            this.UnlegitButton.Location = new System.Drawing.Point(141, 22);
            this.UnlegitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UnlegitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UnlegitButton.Name = "UnlegitButton";
            this.UnlegitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UnlegitButton.Size = new System.Drawing.Size(81, 36);
            this.UnlegitButton.TabIndex = 2;
            this.UnlegitButton.Text = "Unlegit";
            this.toolTip1.SetToolTip(this.UnlegitButton, "You can also drag & drop the file instead of clicking the button");
            this.UnlegitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.UnlegitButton.UseAccentColor = false;
            this.UnlegitButton.UseVisualStyleBackColor = true;
            this.UnlegitButton.Click += new System.EventHandler(this.UnlegitButton_Click);
            this.UnlegitButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.UnlegitButton_DragDrop);
            this.UnlegitButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.UnlegitButton_DragEnter);
            // 
            // LegitButton
            // 
            this.LegitButton.AllowDrop = true;
            this.LegitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LegitButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LegitButton.Depth = 0;
            this.LegitButton.HighEmphasis = true;
            this.LegitButton.Icon = null;
            this.LegitButton.Location = new System.Drawing.Point(69, 22);
            this.LegitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LegitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LegitButton.Name = "LegitButton";
            this.LegitButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LegitButton.Size = new System.Drawing.Size(64, 36);
            this.LegitButton.TabIndex = 1;
            this.LegitButton.Text = "legit";
            this.toolTip1.SetToolTip(this.LegitButton, "You can also drag & drop the file instead of clicking the button");
            this.LegitButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.LegitButton.UseAccentColor = false;
            this.LegitButton.UseVisualStyleBackColor = true;
            this.LegitButton.Click += new System.EventHandler(this.LegitButton_Click);
            this.LegitButton.DragDrop += new System.Windows.Forms.DragEventHandler(this.LegitButton_DragDrop);
            this.LegitButton.DragEnter += new System.Windows.Forms.DragEventHandler(this.LegitButton_DragEnter);
            // 
            // CheckDifferences
            // 
            this.CheckDifferences.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CheckDifferences.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CheckDifferences.Depth = 0;
            this.CheckDifferences.HighEmphasis = true;
            this.CheckDifferences.Icon = null;
            this.CheckDifferences.Location = new System.Drawing.Point(69, 70);
            this.CheckDifferences.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CheckDifferences.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckDifferences.Name = "CheckDifferences";
            this.CheckDifferences.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CheckDifferences.Size = new System.Drawing.Size(69, 36);
            this.CheckDifferences.TabIndex = 0;
            this.CheckDifferences.Text = "check";
            this.CheckDifferences.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CheckDifferences.UseAccentColor = false;
            this.CheckDifferences.UseVisualStyleBackColor = true;
            this.CheckDifferences.Click += new System.EventHandler(this.CheckDifferences_Click);
            // 
            // methodFinderTab
            // 
            this.methodFinderTab.BackColor = System.Drawing.Color.White;
            this.methodFinderTab.Controls.Add(this.OpenMfResultsFolder);
            this.methodFinderTab.Controls.Add(this.materialExpansionPanel1);
            this.methodFinderTab.Controls.Add(this.AddProcessExceptionButton);
            this.methodFinderTab.Controls.Add(this.SelectedProcessException);
            this.methodFinderTab.Controls.Add(this.SearchButton);
            this.methodFinderTab.Controls.Add(this.TextToSearch);
            this.methodFinderTab.Controls.Add(this.materialDivider2);
            this.methodFinderTab.Controls.Add(this.IsAdvancedOnButton);
            this.methodFinderTab.Controls.Add(this.LoadDumperButton);
            this.methodFinderTab.ImageKey = "icons8_radar_plot_1.ico";
            this.methodFinderTab.Location = new System.Drawing.Point(4, 39);
            this.methodFinderTab.Name = "methodFinderTab";
            this.methodFinderTab.Padding = new System.Windows.Forms.Padding(3);
            this.methodFinderTab.Size = new System.Drawing.Size(732, 333);
            this.methodFinderTab.TabIndex = 1;
            this.methodFinderTab.Text = "Method Finder";
            // 
            // OpenMfResultsFolder
            // 
            this.OpenMfResultsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenMfResultsFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenMfResultsFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenMfResultsFolder.Depth = 0;
            this.OpenMfResultsFolder.HighEmphasis = true;
            this.OpenMfResultsFolder.Icon = null;
            this.OpenMfResultsFolder.Location = new System.Drawing.Point(543, 292);
            this.OpenMfResultsFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenMfResultsFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenMfResultsFolder.Name = "OpenMfResultsFolder";
            this.OpenMfResultsFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenMfResultsFolder.Size = new System.Drawing.Size(183, 36);
            this.OpenMfResultsFolder.TabIndex = 19;
            this.OpenMfResultsFolder.Text = "Open results folder";
            this.OpenMfResultsFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.OpenMfResultsFolder.UseAccentColor = false;
            this.OpenMfResultsFolder.UseVisualStyleBackColor = true;
            this.OpenMfResultsFolder.Click += new System.EventHandler(this.OpenMfResultsFolder_Click);
            // 
            // materialExpansionPanel1
            // 
            this.materialExpansionPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialExpansionPanel1.Controls.Add(this.materialLabel1);
            this.materialExpansionPanel1.Depth = 0;
            this.materialExpansionPanel1.Description = "";
            this.materialExpansionPanel1.ExpandHeight = 200;
            this.materialExpansionPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialExpansionPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialExpansionPanel1.Location = new System.Drawing.Point(380, 16);
            this.materialExpansionPanel1.Margin = new System.Windows.Forms.Padding(3, 16, 3, 16);
            this.materialExpansionPanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialExpansionPanel1.Name = "materialExpansionPanel1";
            this.materialExpansionPanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.materialExpansionPanel1.ShowValidationButtons = false;
            this.materialExpansionPanel1.Size = new System.Drawing.Size(336, 200);
            this.materialExpansionPanel1.TabIndex = 18;
            this.materialExpansionPanel1.Title = "Recommendation";
            this.materialExpansionPanel1.ValidationButtonEnable = true;
            this.materialExpansionPanel1.ValidationButtonText = "OK";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(14, 51);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(312, 106);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "If you have a bad pc I don\'t recommend you to use the method finder and I recomme" +
    "nd to who uses the method finder to not do something else during the processes d" +
    "ump or the string search.";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddProcessExceptionButton
            // 
            this.AddProcessExceptionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProcessExceptionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddProcessExceptionButton.Depth = 0;
            this.AddProcessExceptionButton.HighEmphasis = true;
            this.AddProcessExceptionButton.Icon = null;
            this.AddProcessExceptionButton.Location = new System.Drawing.Point(78, 288);
            this.AddProcessExceptionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddProcessExceptionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProcessExceptionButton.Name = "AddProcessExceptionButton";
            this.AddProcessExceptionButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddProcessExceptionButton.Size = new System.Drawing.Size(64, 36);
            this.AddProcessExceptionButton.TabIndex = 17;
            this.AddProcessExceptionButton.Text = "add";
            this.AddProcessExceptionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddProcessExceptionButton.UseAccentColor = false;
            this.AddProcessExceptionButton.UseVisualStyleBackColor = true;
            this.AddProcessExceptionButton.Visible = false;
            this.AddProcessExceptionButton.Click += new System.EventHandler(this.AddProcessExceptionButton_Click);
            // 
            // SelectedProcessException
            // 
            this.SelectedProcessException.AnimateReadOnly = false;
            this.SelectedProcessException.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SelectedProcessException.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SelectedProcessException.Depth = 0;
            this.SelectedProcessException.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SelectedProcessException.HideSelection = true;
            this.SelectedProcessException.LeadingIcon = null;
            this.SelectedProcessException.Location = new System.Drawing.Point(78, 234);
            this.SelectedProcessException.MaxLength = 32767;
            this.SelectedProcessException.MouseState = MaterialSkin.MouseState.OUT;
            this.SelectedProcessException.Name = "SelectedProcessException";
            this.SelectedProcessException.PasswordChar = '\0';
            this.SelectedProcessException.PrefixSuffixText = null;
            this.SelectedProcessException.ReadOnly = false;
            this.SelectedProcessException.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedProcessException.SelectedText = "";
            this.SelectedProcessException.SelectionLength = 0;
            this.SelectedProcessException.SelectionStart = 0;
            this.SelectedProcessException.ShortcutsEnabled = true;
            this.SelectedProcessException.Size = new System.Drawing.Size(270, 48);
            this.SelectedProcessException.TabIndex = 16;
            this.SelectedProcessException.TabStop = false;
            this.SelectedProcessException.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.SelectedProcessException, "Digit the process you wanna add to processes exception.");
            this.SelectedProcessException.TrailingIcon = null;
            this.SelectedProcessException.UseSystemPasswordChar = false;
            this.SelectedProcessException.Visible = false;
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SearchButton.Depth = 0;
            this.SearchButton.HighEmphasis = true;
            this.SearchButton.Icon = null;
            this.SearchButton.Location = new System.Drawing.Point(78, 74);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SearchButton.Size = new System.Drawing.Size(78, 36);
            this.SearchButton.TabIndex = 15;
            this.SearchButton.Text = "search";
            this.SearchButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SearchButton.UseAccentColor = false;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // TextToSearch
            // 
            this.TextToSearch.AnimateReadOnly = false;
            this.TextToSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TextToSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextToSearch.Depth = 0;
            this.TextToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TextToSearch.HideSelection = true;
            this.TextToSearch.LeadingIcon = null;
            this.TextToSearch.Location = new System.Drawing.Point(78, 20);
            this.TextToSearch.MaxLength = 32767;
            this.TextToSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.TextToSearch.Name = "TextToSearch";
            this.TextToSearch.PasswordChar = '\0';
            this.TextToSearch.PrefixSuffixText = null;
            this.TextToSearch.ReadOnly = false;
            this.TextToSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextToSearch.SelectedText = "";
            this.TextToSearch.SelectionLength = 0;
            this.TextToSearch.SelectionStart = 0;
            this.TextToSearch.ShortcutsEnabled = true;
            this.TextToSearch.Size = new System.Drawing.Size(270, 48);
            this.TextToSearch.TabIndex = 14;
            this.TextToSearch.TabStop = false;
            this.TextToSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.TextToSearch, "Digit the text you wanna search.");
            this.TextToSearch.TrailingIcon = null;
            this.TextToSearch.UseSystemPasswordChar = false;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(78, 133);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(270, 10);
            this.materialDivider2.TabIndex = 13;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // IsAdvancedOnButton
            // 
            this.IsAdvancedOnButton.AutoSize = true;
            this.IsAdvancedOnButton.Depth = 0;
            this.IsAdvancedOnButton.Location = new System.Drawing.Point(78, 194);
            this.IsAdvancedOnButton.Margin = new System.Windows.Forms.Padding(0);
            this.IsAdvancedOnButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.IsAdvancedOnButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.IsAdvancedOnButton.Name = "IsAdvancedOnButton";
            this.IsAdvancedOnButton.ReadOnly = false;
            this.IsAdvancedOnButton.Ripple = true;
            this.IsAdvancedOnButton.Size = new System.Drawing.Size(104, 37);
            this.IsAdvancedOnButton.TabIndex = 11;
            this.IsAdvancedOnButton.Text = "advanced";
            this.IsAdvancedOnButton.UseVisualStyleBackColor = true;
            this.IsAdvancedOnButton.CheckStateChanged += new System.EventHandler(this.IsAdvancedOnButton_CheckStateChanged);
            // 
            // LoadDumperButton
            // 
            this.LoadDumperButton.AllowDrop = true;
            this.LoadDumperButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadDumperButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LoadDumperButton.Depth = 0;
            this.LoadDumperButton.HighEmphasis = true;
            this.LoadDumperButton.Icon = null;
            this.LoadDumperButton.Location = new System.Drawing.Point(78, 152);
            this.LoadDumperButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LoadDumperButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoadDumperButton.Name = "LoadDumperButton";
            this.LoadDumperButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LoadDumperButton.Size = new System.Drawing.Size(122, 36);
            this.LoadDumperButton.TabIndex = 9;
            this.LoadDumperButton.Text = "load dumper";
            this.toolTip1.SetToolTip(this.LoadDumperButton, "Load dumper.");
            this.LoadDumperButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.LoadDumperButton.UseAccentColor = false;
            this.LoadDumperButton.UseVisualStyleBackColor = true;
            this.LoadDumperButton.Click += new System.EventHandler(this.LoadDumperButton_Click);
            // 
            // creditsTab
            // 
            this.creditsTab.BackColor = System.Drawing.Color.White;
            this.creditsTab.Controls.Add(this.groupBox1);
            this.creditsTab.ImageKey = "icons8_cancel_last_digit_1.ico";
            this.creditsTab.Location = new System.Drawing.Point(4, 39);
            this.creditsTab.Name = "creditsTab";
            this.creditsTab.Size = new System.Drawing.Size(732, 333);
            this.creditsTab.TabIndex = 2;
            this.creditsTab.Text = "Credits";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(41, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanks to";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.75583F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.244168F));
            this.tableLayoutPanel1.Controls.Add(this.linkLabel5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.linkLabel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.36842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 260);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(3, 95);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(320, 13);
            this.linkLabel5.TabIndex = 4;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "DiscordMessenger Nuget and \"It’s Networking\" youtube channel .";
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(3, 71);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(203, 13);
            this.linkLabel4.TabIndex = 3;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "SMTool for process hacker libraries in .dll.";
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(3, 46);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(336, 13);
            this.linkLabel3.TabIndex = 2;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "I don\'t know the autor but thanks for the process dumper made in c#. ";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(3, 24);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(313, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "ProcessHacker libs for the random numbers generator inspiration.";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(321, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Icons8 Pichon for the string finder, method finder and credits icons.";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bugReportTab
            // 
            this.bugReportTab.BackColor = System.Drawing.Color.White;
            this.bugReportTab.Controls.Add(this.SendBug);
            this.bugReportTab.Controls.Add(this.bugDescription);
            this.bugReportTab.ImageKey = "icons8_error.ico";
            this.bugReportTab.Location = new System.Drawing.Point(4, 39);
            this.bugReportTab.Name = "bugReportTab";
            this.bugReportTab.Size = new System.Drawing.Size(732, 333);
            this.bugReportTab.TabIndex = 3;
            this.bugReportTab.Text = "Bug Report";
            // 
            // SendBug
            // 
            this.SendBug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SendBug.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SendBug.Depth = 0;
            this.SendBug.HighEmphasis = true;
            this.SendBug.Icon = null;
            this.SendBug.Location = new System.Drawing.Point(20, 70);
            this.SendBug.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SendBug.MouseState = MaterialSkin.MouseState.HOVER;
            this.SendBug.Name = "SendBug";
            this.SendBug.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SendBug.Size = new System.Drawing.Size(64, 36);
            this.SendBug.TabIndex = 1;
            this.SendBug.Text = "send";
            this.SendBug.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.SendBug.UseAccentColor = false;
            this.SendBug.UseVisualStyleBackColor = true;
            this.SendBug.Click += new System.EventHandler(this.SendBug_Click);
            // 
            // bugDescription
            // 
            this.bugDescription.AnimateReadOnly = false;
            this.bugDescription.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bugDescription.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bugDescription.Depth = 0;
            this.bugDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.bugDescription.HideSelection = true;
            this.bugDescription.LeadingIcon = null;
            this.bugDescription.Location = new System.Drawing.Point(20, 13);
            this.bugDescription.MaxLength = 32767;
            this.bugDescription.MouseState = MaterialSkin.MouseState.OUT;
            this.bugDescription.Name = "bugDescription";
            this.bugDescription.PasswordChar = '\0';
            this.bugDescription.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Prefix;
            this.bugDescription.PrefixSuffixText = "Description:";
            this.bugDescription.ReadOnly = false;
            this.bugDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bugDescription.SelectedText = "";
            this.bugDescription.SelectionLength = 0;
            this.bugDescription.SelectionStart = 0;
            this.bugDescription.ShortcutsEnabled = true;
            this.bugDescription.Size = new System.Drawing.Size(696, 48);
            this.bugDescription.TabIndex = 0;
            this.bugDescription.TabStop = false;
            this.bugDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bugDescription.TrailingIcon = null;
            this.bugDescription.UseSystemPasswordChar = false;
            // 
            // SocialsTab
            // 
            this.SocialsTab.BackColor = System.Drawing.Color.White;
            this.SocialsTab.Controls.Add(this.groupBox2);
            this.SocialsTab.ImageKey = "icons8_tinder_2.ico";
            this.SocialsTab.Location = new System.Drawing.Point(4, 39);
            this.SocialsTab.Name = "SocialsTab";
            this.SocialsTab.Size = new System.Drawing.Size(732, 333);
            this.SocialsTab.TabIndex = 4;
            this.SocialsTab.Text = "Socials";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Location = new System.Drawing.Point(28, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 308);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Socials";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.75583F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.244168F));
            this.tableLayoutPanel2.Controls.Add(this.ProjectSourceButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TelegramDeveloperButton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.TelegramChannelButton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.DiscordButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 25);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.63158F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 260);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // TelegramDeveloperButton
            // 
            this.TelegramDeveloperButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TelegramDeveloperButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TelegramDeveloperButton.Depth = 0;
            this.TelegramDeveloperButton.HighEmphasis = true;
            this.TelegramDeveloperButton.Icon = null;
            this.TelegramDeveloperButton.Location = new System.Drawing.Point(4, 108);
            this.TelegramDeveloperButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TelegramDeveloperButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TelegramDeveloperButton.Name = "TelegramDeveloperButton";
            this.TelegramDeveloperButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TelegramDeveloperButton.Size = new System.Drawing.Size(182, 36);
            this.TelegramDeveloperButton.TabIndex = 2;
            this.TelegramDeveloperButton.Text = "telegram developer";
            this.TelegramDeveloperButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.TelegramDeveloperButton.UseAccentColor = false;
            this.TelegramDeveloperButton.UseVisualStyleBackColor = true;
            this.TelegramDeveloperButton.Click += new System.EventHandler(this.TelegramDeveloperButton_Click);
            // 
            // TelegramChannelButton
            // 
            this.TelegramChannelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TelegramChannelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TelegramChannelButton.Depth = 0;
            this.TelegramChannelButton.HighEmphasis = true;
            this.TelegramChannelButton.Icon = null;
            this.TelegramChannelButton.Location = new System.Drawing.Point(4, 56);
            this.TelegramChannelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TelegramChannelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TelegramChannelButton.Name = "TelegramChannelButton";
            this.TelegramChannelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TelegramChannelButton.Size = new System.Drawing.Size(168, 36);
            this.TelegramChannelButton.TabIndex = 1;
            this.TelegramChannelButton.Text = "telegram channel";
            this.TelegramChannelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.TelegramChannelButton.UseAccentColor = false;
            this.TelegramChannelButton.UseVisualStyleBackColor = true;
            this.TelegramChannelButton.Click += new System.EventHandler(this.TelegramChannelButton_Click);
            // 
            // DiscordButton
            // 
            this.DiscordButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DiscordButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DiscordButton.Depth = 0;
            this.DiscordButton.HighEmphasis = true;
            this.DiscordButton.Icon = null;
            this.DiscordButton.Location = new System.Drawing.Point(4, 6);
            this.DiscordButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DiscordButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DiscordButton.Name = "DiscordButton";
            this.DiscordButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DiscordButton.Size = new System.Drawing.Size(83, 36);
            this.DiscordButton.TabIndex = 0;
            this.DiscordButton.Text = "discord";
            this.DiscordButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.DiscordButton.UseAccentColor = false;
            this.DiscordButton.UseVisualStyleBackColor = true;
            this.DiscordButton.Click += new System.EventHandler(this.DiscordButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_radar_plot_1.ico");
            this.imageList1.Images.SetKeyName(1, "icons8_search_1.ico");
            this.imageList1.Images.SetKeyName(2, "icons8_cancel_last_digit_1.ico");
            this.imageList1.Images.SetKeyName(3, "icons8_error.ico");
            this.imageList1.Images.SetKeyName(4, "icons8_tinder_2.ico");
            // 
            // fileBrowser
            // 
            this.fileBrowser.FileName = "openFileDialog1";
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // OpenSingleDumpResultsFolder
            // 
            this.OpenSingleDumpResultsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenSingleDumpResultsFolder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenSingleDumpResultsFolder.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenSingleDumpResultsFolder.Depth = 0;
            this.OpenSingleDumpResultsFolder.HighEmphasis = true;
            this.OpenSingleDumpResultsFolder.Icon = null;
            this.OpenSingleDumpResultsFolder.Location = new System.Drawing.Point(295, 293);
            this.OpenSingleDumpResultsFolder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenSingleDumpResultsFolder.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenSingleDumpResultsFolder.Name = "OpenSingleDumpResultsFolder";
            this.OpenSingleDumpResultsFolder.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenSingleDumpResultsFolder.Size = new System.Drawing.Size(246, 36);
            this.OpenSingleDumpResultsFolder.TabIndex = 9;
            this.OpenSingleDumpResultsFolder.Text = "Open dumper results folder";
            this.OpenSingleDumpResultsFolder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.OpenSingleDumpResultsFolder.UseAccentColor = false;
            this.OpenSingleDumpResultsFolder.UseVisualStyleBackColor = true;
            this.OpenSingleDumpResultsFolder.Click += new System.EventHandler(this.OpenSingleDumpResultsFolder_Click);
            // 
            // prefix
            // 
            this.prefix.AutoResize = false;
            this.prefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.prefix.Depth = 0;
            this.prefix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.prefix.DropDownHeight = 174;
            this.prefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prefix.DropDownWidth = 121;
            this.prefix.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.prefix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.prefix.FormattingEnabled = true;
            this.prefix.IntegralHeight = false;
            this.prefix.ItemHeight = 43;
            this.prefix.Items.AddRange(new object[] {
            "LEGIT",
            "UNLEGIT"});
            this.prefix.Location = new System.Drawing.Point(345, 194);
            this.prefix.MaxDropDownItems = 4;
            this.prefix.MouseState = MaterialSkin.MouseState.OUT;
            this.prefix.Name = "prefix";
            this.prefix.Size = new System.Drawing.Size(120, 49);
            this.prefix.StartIndex = 0;
            this.prefix.TabIndex = 10;
            this.toolTip1.SetToolTip(this.prefix, "Add the file prefix");
            // 
            // ProjectSourceButton
            // 
            this.ProjectSourceButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProjectSourceButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ProjectSourceButton.Depth = 0;
            this.ProjectSourceButton.HighEmphasis = true;
            this.ProjectSourceButton.Icon = null;
            this.ProjectSourceButton.Location = new System.Drawing.Point(4, 159);
            this.ProjectSourceButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProjectSourceButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProjectSourceButton.Name = "ProjectSourceButton";
            this.ProjectSourceButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProjectSourceButton.Size = new System.Drawing.Size(186, 36);
            this.ProjectSourceButton.TabIndex = 3;
            this.ProjectSourceButton.Text = "project source code";
            this.ProjectSourceButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.ProjectSourceButton.UseAccentColor = false;
            this.ProjectSourceButton.UseVisualStyleBackColor = true;
            this.ProjectSourceButton.Click += new System.EventHandler(this.ProjectSourceButton_Click);
            // 
            // AcsFinderMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.DrawerAutoShow = true;
            this.DrawerHighlightWithAccent = false;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.menu;
            this.DrawerUseColors = true;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AcsFinderMain";
            this.Padding = new System.Windows.Forms.Padding(3, 72, 3, 3);
            this.Sizable = false;
            this.Text = "ACS FINDER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AcsFinderMain_FormClosing);
            this.menu.ResumeLayout(false);
            this.stringFinderTab.ResumeLayout(false);
            this.stringFinderTab.PerformLayout();
            this.methodFinderTab.ResumeLayout(false);
            this.methodFinderTab.PerformLayout();
            this.materialExpansionPanel1.ResumeLayout(false);
            this.materialExpansionPanel1.PerformLayout();
            this.creditsTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bugReportTab.ResumeLayout(false);
            this.bugReportTab.PerformLayout();
            this.SocialsTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl menu;
        private System.Windows.Forms.TabPage stringFinderTab;
        private System.Windows.Forms.TabPage methodFinderTab;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton ExceptionsButton;
        private MaterialSkin.Controls.MaterialCheckbox IsExceptionsOnButton;
        private MaterialSkin.Controls.MaterialButton UnlegitButton;
        private MaterialSkin.Controls.MaterialButton LegitButton;
        private MaterialSkin.Controls.MaterialButton CheckDifferences;
        private System.Windows.Forms.ToolTip toolTip1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox2 SelectedProcess;
        private MaterialSkin.Controls.MaterialButton DumpSelectedProcessButton;
        private MaterialSkin.Controls.MaterialButton SearchButton;
        private MaterialSkin.Controls.MaterialTextBox2 TextToSearch;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialButton LoadDumperButton;
        private MaterialSkin.Controls.MaterialButton AddProcessExceptionButton;
        private MaterialSkin.Controls.MaterialTextBox2 SelectedProcessException;
        private MaterialSkin.Controls.MaterialCheckbox IsAdvancedOnButton;
        private MaterialSkin.Controls.MaterialExpansionPanel materialExpansionPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton OpenResultsFolder;
        private System.Windows.Forms.OpenFileDialog fileBrowser;
        private System.Windows.Forms.TabPage creditsTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TabPage bugReportTab;
        private MaterialSkin.Controls.MaterialButton SendBug;
        private MaterialSkin.Controls.MaterialTextBox2 bugDescription;
        private System.Windows.Forms.TabPage SocialsTab;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialButton DiscordButton;
        private MaterialSkin.Controls.MaterialButton TelegramDeveloperButton;
        private MaterialSkin.Controls.MaterialButton TelegramChannelButton;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private MaterialSkin.Controls.MaterialButton OpenMfResultsFolder;
        private MaterialSkin.Controls.MaterialButton OpenSingleDumpResultsFolder;
        private MaterialSkin.Controls.MaterialComboBox prefix;
        private MaterialSkin.Controls.MaterialButton ProjectSourceButton;
    }
}

