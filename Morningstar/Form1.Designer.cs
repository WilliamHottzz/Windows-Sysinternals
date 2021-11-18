namespace Morningstar
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_RemoveAllFileSystemPermission = new System.Windows.Forms.Button();
            this.combobox_FilesystemAccessControlList = new System.Windows.Forms.ComboBox();
            this.button_RemoveFileSystemPermission = new System.Windows.Forms.Button();
            this.label_FileAttributeEncrypted = new System.Windows.Forms.Label();
            this.label_FileAttributeArchive = new System.Windows.Forms.Label();
            this.label_FileAttributeOffline = new System.Windows.Forms.Label();
            this.label_FileAttributeNormal = new System.Windows.Forms.Label();
            this.label_FileAttributeSystem = new System.Windows.Forms.Label();
            this.label_FileAttributeReadOnly = new System.Windows.Forms.Label();
            this.label_FileAttributeHidden = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_FilePropertiesLastModified = new System.Windows.Forms.Label();
            this.label_FilePropertiesLastAccessed = new System.Windows.Forms.Label();
            this.label_FilePropertiesCreationDate = new System.Windows.Forms.Label();
            this.label_FilePropertiesName = new System.Windows.Forms.Label();
            this.label_FilePropertiesSize = new System.Windows.Forms.Label();
            this.label_FilePropertiesOwner = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabpage_DotNet = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listbox_DotNetClasses = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listbox_DotNetStrings = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_RunUserFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitem_TerminateUserProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabpage_DotNet.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabpage_DotNet);
            this.tabControl1.Location = new System.Drawing.Point(4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ConsoleReader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label_FileAttributeEncrypted);
            this.tabPage2.Controls.Add(this.label_FileAttributeArchive);
            this.tabPage2.Controls.Add(this.label_FileAttributeOffline);
            this.tabPage2.Controls.Add(this.label_FileAttributeNormal);
            this.tabPage2.Controls.Add(this.label_FileAttributeSystem);
            this.tabPage2.Controls.Add(this.label_FileAttributeReadOnly);
            this.tabPage2.Controls.Add(this.label_FileAttributeHidden);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label_FilePropertiesLastModified);
            this.tabPage2.Controls.Add(this.label_FilePropertiesLastAccessed);
            this.tabPage2.Controls.Add(this.label_FilePropertiesCreationDate);
            this.tabPage2.Controls.Add(this.label_FilePropertiesName);
            this.tabPage2.Controls.Add(this.label_FilePropertiesSize);
            this.tabPage2.Controls.Add(this.label_FilePropertiesOwner);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button_RemoveAllFileSystemPermission);
            this.groupBox1.Controls.Add(this.combobox_FilesystemAccessControlList);
            this.groupBox1.Controls.Add(this.button_RemoveFileSystemPermission);
            this.groupBox1.Location = new System.Drawing.Point(435, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(167, 42);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File system permissions";
            // 
            // button_RemoveAllFileSystemPermission
            // 
            this.button_RemoveAllFileSystemPermission.Enabled = false;
            this.button_RemoveAllFileSystemPermission.Location = new System.Drawing.Point(82, 42);
            this.button_RemoveAllFileSystemPermission.Name = "button_RemoveAllFileSystemPermission";
            this.button_RemoveAllFileSystemPermission.Size = new System.Drawing.Size(78, 23);
            this.button_RemoveAllFileSystemPermission.TabIndex = 28;
            this.button_RemoveAllFileSystemPermission.Text = "Remove All";
            this.button_RemoveAllFileSystemPermission.UseVisualStyleBackColor = true;
            this.button_RemoveAllFileSystemPermission.Visible = false;
            this.button_RemoveAllFileSystemPermission.Click += new System.EventHandler(this.button_RemoveAllFileSystemPermission_Click);
            // 
            // combobox_FilesystemAccessControlList
            // 
            this.combobox_FilesystemAccessControlList.FormattingEnabled = true;
            this.combobox_FilesystemAccessControlList.Location = new System.Drawing.Point(6, 17);
            this.combobox_FilesystemAccessControlList.Name = "combobox_FilesystemAccessControlList";
            this.combobox_FilesystemAccessControlList.Size = new System.Drawing.Size(154, 21);
            this.combobox_FilesystemAccessControlList.TabIndex = 26;
            // 
            // button_RemoveFileSystemPermission
            // 
            this.button_RemoveFileSystemPermission.Enabled = false;
            this.button_RemoveFileSystemPermission.Location = new System.Drawing.Point(6, 42);
            this.button_RemoveFileSystemPermission.Name = "button_RemoveFileSystemPermission";
            this.button_RemoveFileSystemPermission.Size = new System.Drawing.Size(78, 23);
            this.button_RemoveFileSystemPermission.TabIndex = 27;
            this.button_RemoveFileSystemPermission.Text = "Remove";
            this.button_RemoveFileSystemPermission.UseVisualStyleBackColor = true;
            this.button_RemoveFileSystemPermission.Visible = false;
            this.button_RemoveFileSystemPermission.Click += new System.EventHandler(this.button_RemoveFileSystemPermission_Click);
            // 
            // label_FileAttributeEncrypted
            // 
            this.label_FileAttributeEncrypted.AutoSize = true;
            this.label_FileAttributeEncrypted.Location = new System.Drawing.Point(88, 275);
            this.label_FileAttributeEncrypted.Name = "label_FileAttributeEncrypted";
            this.label_FileAttributeEncrypted.Size = new System.Drawing.Size(27, 13);
            this.label_FileAttributeEncrypted.TabIndex = 25;
            this.label_FileAttributeEncrypted.Text = "N/A";
            // 
            // label_FileAttributeArchive
            // 
            this.label_FileAttributeArchive.AutoSize = true;
            this.label_FileAttributeArchive.Location = new System.Drawing.Point(88, 253);
            this.label_FileAttributeArchive.Name = "label_FileAttributeArchive";
            this.label_FileAttributeArchive.Size = new System.Drawing.Size(27, 13);
            this.label_FileAttributeArchive.TabIndex = 24;
            this.label_FileAttributeArchive.Text = "N/A";
            // 
            // label_FileAttributeOffline
            // 
            this.label_FileAttributeOffline.AutoSize = true;
            this.label_FileAttributeOffline.Location = new System.Drawing.Point(88, 231);
            this.label_FileAttributeOffline.Name = "label_FileAttributeOffline";
            this.label_FileAttributeOffline.Size = new System.Drawing.Size(27, 13);
            this.label_FileAttributeOffline.TabIndex = 23;
            this.label_FileAttributeOffline.Text = "N/A";
            // 
            // label_FileAttributeNormal
            // 
            this.label_FileAttributeNormal.AutoSize = true;
            this.label_FileAttributeNormal.Location = new System.Drawing.Point(88, 208);
            this.label_FileAttributeNormal.Name = "label_FileAttributeNormal";
            this.label_FileAttributeNormal.Size = new System.Drawing.Size(27, 13);
            this.label_FileAttributeNormal.TabIndex = 22;
            this.label_FileAttributeNormal.Text = "N/A";
            // 
            // label_FileAttributeSystem
            // 
            this.label_FileAttributeSystem.AutoSize = true;
            this.label_FileAttributeSystem.Location = new System.Drawing.Point(88, 184);
            this.label_FileAttributeSystem.Name = "label_FileAttributeSystem";
            this.label_FileAttributeSystem.Size = new System.Drawing.Size(27, 13);
            this.label_FileAttributeSystem.TabIndex = 21;
            this.label_FileAttributeSystem.Text = "N/A";
            // 
            // label_FileAttributeReadOnly
            // 
            this.label_FileAttributeReadOnly.AutoSize = true;
            this.label_FileAttributeReadOnly.Location = new System.Drawing.Point(88, 161);
            this.label_FileAttributeReadOnly.Name = "label_FileAttributeReadOnly";
            this.label_FileAttributeReadOnly.Size = new System.Drawing.Size(27, 13);
            this.label_FileAttributeReadOnly.TabIndex = 20;
            this.label_FileAttributeReadOnly.Text = "N/A";
            // 
            // label_FileAttributeHidden
            // 
            this.label_FileAttributeHidden.AutoSize = true;
            this.label_FileAttributeHidden.Location = new System.Drawing.Point(88, 139);
            this.label_FileAttributeHidden.Name = "label_FileAttributeHidden";
            this.label_FileAttributeHidden.Size = new System.Drawing.Size(27, 13);
            this.label_FileAttributeHidden.TabIndex = 19;
            this.label_FileAttributeHidden.Text = "N/A";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 275);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "File Encrypted: ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "File Archive: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "File Offline: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "File Normal: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "File System: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "File ReadOnly: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "File Hidden: ";
            // 
            // label_FilePropertiesLastModified
            // 
            this.label_FilePropertiesLastModified.AutoSize = true;
            this.label_FilePropertiesLastModified.Location = new System.Drawing.Point(88, 114);
            this.label_FilePropertiesLastModified.Name = "label_FilePropertiesLastModified";
            this.label_FilePropertiesLastModified.Size = new System.Drawing.Size(27, 13);
            this.label_FilePropertiesLastModified.TabIndex = 11;
            this.label_FilePropertiesLastModified.Text = "N/A";
            // 
            // label_FilePropertiesLastAccessed
            // 
            this.label_FilePropertiesLastAccessed.AutoSize = true;
            this.label_FilePropertiesLastAccessed.Location = new System.Drawing.Point(88, 92);
            this.label_FilePropertiesLastAccessed.Name = "label_FilePropertiesLastAccessed";
            this.label_FilePropertiesLastAccessed.Size = new System.Drawing.Size(27, 13);
            this.label_FilePropertiesLastAccessed.TabIndex = 10;
            this.label_FilePropertiesLastAccessed.Text = "N/A";
            // 
            // label_FilePropertiesCreationDate
            // 
            this.label_FilePropertiesCreationDate.AutoSize = true;
            this.label_FilePropertiesCreationDate.Location = new System.Drawing.Point(88, 70);
            this.label_FilePropertiesCreationDate.Name = "label_FilePropertiesCreationDate";
            this.label_FilePropertiesCreationDate.Size = new System.Drawing.Size(27, 13);
            this.label_FilePropertiesCreationDate.TabIndex = 9;
            this.label_FilePropertiesCreationDate.Text = "N/A";
            // 
            // label_FilePropertiesName
            // 
            this.label_FilePropertiesName.AutoSize = true;
            this.label_FilePropertiesName.Location = new System.Drawing.Point(88, 47);
            this.label_FilePropertiesName.Name = "label_FilePropertiesName";
            this.label_FilePropertiesName.Size = new System.Drawing.Size(27, 13);
            this.label_FilePropertiesName.TabIndex = 8;
            this.label_FilePropertiesName.Text = "N/A";
            // 
            // label_FilePropertiesSize
            // 
            this.label_FilePropertiesSize.AutoSize = true;
            this.label_FilePropertiesSize.Location = new System.Drawing.Point(88, 25);
            this.label_FilePropertiesSize.Name = "label_FilePropertiesSize";
            this.label_FilePropertiesSize.Size = new System.Drawing.Size(27, 13);
            this.label_FilePropertiesSize.TabIndex = 7;
            this.label_FilePropertiesSize.Text = "N/A";
            // 
            // label_FilePropertiesOwner
            // 
            this.label_FilePropertiesOwner.AutoSize = true;
            this.label_FilePropertiesOwner.Location = new System.Drawing.Point(88, 3);
            this.label_FilePropertiesOwner.Name = "label_FilePropertiesOwner";
            this.label_FilePropertiesOwner.Size = new System.Drawing.Size(27, 13);
            this.label_FilePropertiesOwner.TabIndex = 6;
            this.label_FilePropertiesOwner.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Size: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Owner: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Last modified: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last accessed: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Creation date: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File name: ";
            // 
            // tabpage_DotNet
            // 
            this.tabpage_DotNet.Controls.Add(this.tabControl2);
            this.tabpage_DotNet.Location = new System.Drawing.Point(4, 22);
            this.tabpage_DotNet.Name = "tabpage_DotNet";
            this.tabpage_DotNet.Size = new System.Drawing.Size(605, 327);
            this.tabpage_DotNet.TabIndex = 2;
            this.tabpage_DotNet.Text = ".NET";
            this.tabpage_DotNet.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-4, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(606, 324);
            this.tabControl2.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listbox_DotNetClasses);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(598, 298);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Classes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listbox_DotNetClasses
            // 
            this.listbox_DotNetClasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_DotNetClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_DotNetClasses.FormattingEnabled = true;
            this.listbox_DotNetClasses.Location = new System.Drawing.Point(3, 3);
            this.listbox_DotNetClasses.Name = "listbox_DotNetClasses";
            this.listbox_DotNetClasses.Size = new System.Drawing.Size(589, 286);
            this.listbox_DotNetClasses.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listbox_DotNetStrings);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(598, 298);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Strings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listbox_DotNetStrings
            // 
            this.listbox_DotNetStrings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listbox_DotNetStrings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_DotNetStrings.FormattingEnabled = true;
            this.listbox_DotNetStrings.Location = new System.Drawing.Point(3, 3);
            this.listbox_DotNetStrings.Name = "listbox_DotNetStrings";
            this.listbox_DotNetStrings.Size = new System.Drawing.Size(594, 286);
            this.listbox_DotNetStrings.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuitem_RunUserFile,
            this.menuitem_TerminateUserProcess});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menustrip_OpenFile,
            this.openProcessToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menustrip_OpenFile
            // 
            this.menustrip_OpenFile.Name = "menustrip_OpenFile";
            this.menustrip_OpenFile.Size = new System.Drawing.Size(146, 22);
            this.menustrip_OpenFile.Text = "Open File";
            this.menustrip_OpenFile.Click += new System.EventHandler(this.menustrip_OpenFile_Click);
            // 
            // openProcessToolStripMenuItem
            // 
            this.openProcessToolStripMenuItem.Name = "openProcessToolStripMenuItem";
            this.openProcessToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openProcessToolStripMenuItem.Text = "Open Process";
            // 
            // menuitem_RunUserFile
            // 
            this.menuitem_RunUserFile.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_RunUserFile.Image")));
            this.menuitem_RunUserFile.Name = "menuitem_RunUserFile";
            this.menuitem_RunUserFile.Size = new System.Drawing.Size(28, 20);
            this.menuitem_RunUserFile.ToolTipText = "Run this program";
            this.menuitem_RunUserFile.Click += new System.EventHandler(this.menuitem_RunUserFile_Click);
            // 
            // menuitem_TerminateUserProcess
            // 
            this.menuitem_TerminateUserProcess.Image = ((System.Drawing.Image)(resources.GetObject("menuitem_TerminateUserProcess.Image")));
            this.menuitem_TerminateUserProcess.Name = "menuitem_TerminateUserProcess";
            this.menuitem_TerminateUserProcess.Size = new System.Drawing.Size(28, 20);
            this.menuitem_TerminateUserProcess.ToolTipText = "Kill process";
            this.menuitem_TerminateUserProcess.Click += new System.EventHandler(this.menuitem_TerminateUserProcess_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 380);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "jnz 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabpage_DotNet.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menustrip_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem openProcessToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_FilePropertiesLastModified;
        private System.Windows.Forms.Label label_FilePropertiesLastAccessed;
        private System.Windows.Forms.Label label_FilePropertiesCreationDate;
        private System.Windows.Forms.Label label_FilePropertiesName;
        private System.Windows.Forms.Label label_FilePropertiesSize;
        private System.Windows.Forms.Label label_FilePropertiesOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_FileAttributeEncrypted;
        private System.Windows.Forms.Label label_FileAttributeArchive;
        private System.Windows.Forms.Label label_FileAttributeOffline;
        private System.Windows.Forms.Label label_FileAttributeNormal;
        private System.Windows.Forms.Label label_FileAttributeSystem;
        private System.Windows.Forms.Label label_FileAttributeReadOnly;
        private System.Windows.Forms.Label label_FileAttributeHidden;
        private System.Windows.Forms.ComboBox combobox_FilesystemAccessControlList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_RemoveFileSystemPermission;
        private System.Windows.Forms.Button button_RemoveAllFileSystemPermission;
        private System.Windows.Forms.TabPage tabpage_DotNet;
        private System.Windows.Forms.ListBox listbox_DotNetClasses;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox listbox_DotNetStrings;
        private System.Windows.Forms.ToolStripMenuItem menuitem_RunUserFile;
        private System.Windows.Forms.ToolStripMenuItem menuitem_TerminateUserProcess;
    }
}

