using Morningstar.Core.Foundation.FileOperations;
using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Threading.Tasks;
using System.Windows.Forms;
using Morningstar.Core.Foundation.DotNetOperations;
using Morningstar.Core.Foundation.ProcessOperations;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using Morningstar.Core.Foundation.Message.Error;

namespace Morningstar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The file user selects in dialog is kept here.
        /// </summary>
        [Required]
        private string UserSelectedFile;
        /// <summary>
        /// For when process operations start, process PID is kept here.
        /// </summary>
        private int UserStartedProcessPid = -1;


        FailedProcessOperations failedProcessResponse = new FailedProcessOperations();


    private async void GetDotNetAssemblyStrings()
        {
            var assemblyStrings = new AssemblyString();           
           
            if (!string.IsNullOrEmpty(this.UserSelectedFile))
            {
                await Task.Run(() =>
                {
                    assemblyStrings.ReadAll(filename: UserSelectedFile);

                    foreach (var item in assemblyStrings.Strings)
                    {
                        BackgroundWork.ControlInvoke(listbox_DotNetStrings, () => listbox_DotNetStrings.Items.Add(item));
                    }

                    assemblyStrings.Strings = null;
                });
            }           
        }


        private async void GetDotNetAssemblyClasses()
        {
            var assemblyClasses = new ClassNames();

            if (!string.IsNullOrEmpty(this.UserSelectedFile))
            {
                await Task.Run(() =>
                {
                    assemblyClasses.ReadAll(filename: UserSelectedFile);

                    foreach (var item in assemblyClasses.AssemblyClasses)
                    {
                        BackgroundWork.ControlInvoke(listbox_DotNetClasses, () => listbox_DotNetClasses.Items.Add(item));
                    }

                    assemblyClasses.AssemblyClasses = null;
                });
            }
        }


        private async void menustrip_OpenFile_Click(object sender, EventArgs e)
        {
            listbox_DotNetClasses.Items.Clear();
            listbox_DotNetStrings.Items.Clear();

            var userFile = new UserFile();
            var userFileProperties = new FileProperty();
            var userFileAttributes = new FileAttribute();
            var userFileSystemAccessRights = new FileSystemAccess();                   
            var userFileAccessRule = new BindingSource();
                       

            this.UserSelectedFile = await userFile.Load();


            //  Load .NET classes.
            await Task.Run(() => { GetDotNetAssemblyClasses(); });
            //  Load .NET strings.
            await Task.Run(() => { GetDotNetAssemblyStrings(); });

            


            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                await userFileProperties.LoadProperties(file: this.UserSelectedFile);

                // Load file properties.

                label_FilePropertiesName.Text = userFileProperties.OriginalFileName;
                label_FilePropertiesCreationDate.Text = userFileProperties.CreationDate;
                label_FilePropertiesLastAccessed.Text = userFileProperties.AccessedDate;
                label_FilePropertiesLastModified.Text = userFileProperties.ModifiedDate;
                label_FilePropertiesOwner.Text = userFileProperties.Owner;
                label_FilePropertiesSize.Text  = userFileProperties.Size;                

                await userFileAttributes.LoadAttributes(file: this.UserSelectedFile);

                // Load file attributes.

                label_FileAttributeHidden.Text = userFileAttributes.Hidden;
                label_FileAttributeNormal.Text = userFileAttributes.Normal;
                label_FileAttributeSystem.Text = userFileAttributes.System;
                label_FileAttributeOffline.Text  = userFileAttributes.Offline;
                label_FileAttributeReadOnly.Text = userFileAttributes.ReadOnly;                
                label_FileAttributeEncrypted.Text = userFileAttributes.Encrypted;
                label_FileAttributeArchive.Text   = userFileAttributes.Archive;

                await userFileSystemAccessRights.LoadAccessRights(file: this.UserSelectedFile);

                // Load permissions access rights.

                await Task.Run(() => 
                {
                    userFileAccessRule.DataSource = userFileSystemAccessRights.SecurityAttributes;
                    combobox_FilesystemAccessControlList.DataSource = userFileAccessRule;
                });                
            }

            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                menuitem_RunUserFile.Enabled = true;
            }           
        }

        /*
        private void button_RemoveFileSystemPermission_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                var userfilesystemaccessrights = new FileSystemAccess();
                var fileoperationconstants = new FileOperationConstants();

                foreach (KeyValuePair<string, FileSystemRights> right in fileoperationconstants.stuff)
                {
                    if(combobox_FilesystemAccessControlList.SelectedItem.ToString() == right.Key)
                    {
                        MessageBox.Show(combobox_FilesystemAccessControlList.SelectedItem.ToString());

                        if (string.IsNullOrWhiteSpace(this.UserSelectedFile))
                        {
                            MessageBox.Show("name is null");
                            return;
                        }
                        else
                        {                           
                            if(userfilesystemaccessrights.RemoveRule(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {
                               
                            }
                            if (!userfilesystemaccessrights.RemoveRule(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {
                               
                            }
                        }
                    }
                }                   
            }
        }
        */

        private void button_RemoveAllFileSystemPermission_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                var userfilesystemaccessrights = new FileSystemAccess();
                var fileoperationconstants = new FileOperationConstants();

                foreach (KeyValuePair<string, FileSystemRights> right in fileoperationconstants.stuff)
                {
                    if (combobox_FilesystemAccessControlList.SelectedItem.ToString() == right.Key)
                    {
                        MessageBox.Show(combobox_FilesystemAccessControlList.SelectedItem.ToString());

                        if (string.IsNullOrWhiteSpace(this.UserSelectedFile))
                        {
                            MessageBox.Show("name is null");
                            return;
                        }
                        else
                        {
                            if (userfilesystemaccessrights.RemoveAllRules(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {

                            }
                            if (!userfilesystemaccessrights.RemoveAllRules(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {

                            }
                        }
                    }
                }
            }            
        }
        
        private async void menuitem_RunUserFile_Click(object sender, EventArgs e)
        {
            var startprocess = new ProcessEnviroment();
            int result = await startprocess.StartProcess(this.UserSelectedFile);
            UserStartedProcessPid = result;

            if (result == -1)
            {
                MessageBox.Show(failedProcessResponse.FailedStartingProcess);
                return;
            }

            menuitem_TerminateUserProcess.Enabled = true;
            menuitem_RunUserFile.Enabled = false;
        }

        

        private async void menustrip_OpenFile_Click_1(object sender, EventArgs e)
        {
            listbox_DotNetClasses.Items.Clear();
            listbox_DotNetStrings.Items.Clear();

            var userFile = new UserFile();
            var userFileProperties = new FileProperty();
            var userFileAttributes = new FileAttribute();
            var userFileSystemAccessRights = new FileSystemAccess();
            var userFileAccessRule = new BindingSource();


            this.UserSelectedFile = await userFile.Load();


            //  Load .NET classes.
            await Task.Run(() => { GetDotNetAssemblyClasses(); });
            //  Load .NET strings.
            await Task.Run(() => { GetDotNetAssemblyStrings(); });




            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                await userFileProperties.LoadProperties(file: this.UserSelectedFile);

                // Load file properties.

                label_FilePropertiesName.Text = userFileProperties.OriginalFileName;
                label_FilePropertiesCreationDate.Text = userFileProperties.CreationDate;
                label_FilePropertiesLastAccessed.Text = userFileProperties.AccessedDate;
                label_FilePropertiesLastModified.Text = userFileProperties.ModifiedDate;
                label_FilePropertiesOwner.Text = userFileProperties.Owner;
                label_FilePropertiesSize.Text = userFileProperties.Size;

                await userFileAttributes.LoadAttributes(file: this.UserSelectedFile);

                // Load file attributes.

                label_FileAttributeHidden.Text = userFileAttributes.Hidden;
                label_FileAttributeNormal.Text = userFileAttributes.Normal;
                label_FileAttributeSystem.Text = userFileAttributes.System;
                label_FileAttributeOffline.Text = userFileAttributes.Offline;
                label_FileAttributeReadOnly.Text = userFileAttributes.ReadOnly;
                label_FileAttributeEncrypted.Text = userFileAttributes.Encrypted;
                label_FileAttributeArchive.Text = userFileAttributes.Archive;

                await userFileSystemAccessRights.LoadAccessRights(file: this.UserSelectedFile);

                // Load permissions access rights.

                await Task.Run(() =>
                {
                    userFileAccessRule.DataSource = userFileSystemAccessRights.SecurityAttributes;
                    combobox_FilesystemAccessControlList.DataSource = userFileAccessRule;
                });

                toolstrip_SelectedFile.Text = this.UserSelectedFile;
            }

            //if (string.IsNullOrWhiteSpace(this.UserSelectedFile))
            //{
               // menuitem_RunUserFile.Enabled = false;
            //}
        }

        private async void menuitem_RunUserFile_Click_1(object sender, EventArgs e)
        {
            Modules processModules = new Modules();

            var startprocess = new ProcessEnviroment();
            int result = -1;

            try
            {
                result = await startprocess.StartProcess(this.UserSelectedFile);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No selected file available!");
                return;
            }
            
            ListViewItem item = null;
            string[] data = new string[3];


            this.UserStartedProcessPid = result;

            if (result == -1)
            {
                MessageBox.Show(failedProcessResponse.FailedStartingProcess);
                return;
            }

            menuitem_TerminateUserProcess.Enabled = true;
            menuitem_RunUserFile.Enabled = false;

            listView1.Items.Clear();

            if (!processModules.Read32(UserStartedProcessPid))
            {
                MessageBox.Show(failedProcessResponse.FailedLoadingProcessModules);
                return;
            }          

            foreach(var module in processModules.ModuleNames)
            {
                string[] splitter = module.Split(',');

                data[0] = splitter[0];
                data[1] = splitter[1];
                data[2] = splitter[2];

                item = new ListViewItem(data);

                listView1.BeginUpdate();
                listView1.Items.Add(item);
                listView1.EndUpdate();
            }

            toolstrip_ProcessId.Text = this.UserStartedProcessPid.ToString();
            processModules.ModuleNames = null;
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            menuitem_TerminateUserProcess.Enabled = false;
            menuitem_RunUserFile.Enabled = false;

            listView1.View = View.Details;
            listView1.ListViewItemSorter = null;
            listView1.Columns.Add("Entry Address", 125);
            listView1.Columns.Add("Base Address", 70);
            listView1.Columns.Add("Name", 100);
            
        }

        private void menuitem_TerminateUserProcess_Click(object sender, EventArgs e)
        {
            try
            {
                using (Process process = Process.GetProcessById(this.UserStartedProcessPid))
                {
                    MessageBox.Show(this.UserStartedProcessPid.ToString());
                    try
                    {
                        if (!this.UserSelectedFile.Contains(process.ProcessName))
                        {
                            MessageBox.Show(failedProcessResponse.FailedProcessNamesDoNotMatch);
                            return;
                        }

                        process.Kill();
                    }
                    catch (Exception)   // Default
                    {
                        MessageBox.Show(failedProcessResponse.FailedTerminatingProcess);
                        return;
                    }
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show(failedProcessResponse.FailedProcessIdNotFound);
            }


            this.UserStartedProcessPid = -1;

            menuitem_TerminateUserProcess.Enabled = false;
            menuitem_RunUserFile.Enabled = true;
        }

        private void menuitem_TerminateUserProcess_EnabledChanged(object sender, EventArgs e)
        {
            if (!menuitem_TerminateUserProcess.Enabled)
            {
                toolstrip_ProcessId.Text = "-";
            }
        }

        private void toolstrip_SelectedFile_TextChanged(object sender, EventArgs e)
        {
            if(toolstrip_SelectedFile.Text != "-")
            {
                menuitem_RunUserFile.Enabled = true;
            }
        }

        private void btn_ReloadModules_Click(object sender, EventArgs e)
        {
            Modules processModules = new Modules();
            ListViewItem item = null;
            string[] data = new string[3];


            if (!processModules.Read32(UserStartedProcessPid))
            {
                MessageBox.Show(failedProcessResponse.FailedLoadingProcessModules);
                return;
            }

            listView1.Items.Clear();

            foreach (var module in processModules.ModuleNames)
            {
                string[] splitter = module.Split(',');

                data[0] = splitter[0];
                data[1] = splitter[1];
                data[2] = splitter[2];

                item = new ListViewItem(data);

                listView1.BeginUpdate();
                listView1.Items.Add(item);
                listView1.EndUpdate();
            }

            processModules.ModuleNames = null;
        }
    }
}

    class BackgroundWork
    {
        delegate void UniversalVoidDelegate();

        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;

            if (control.InvokeRequired)
            {
                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;
            }
            function();
        }
    }

