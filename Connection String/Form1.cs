using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Connection_String
{
    public partial class Form1 : Form
    {
        string directory;
        string[] repEntries;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //foreach (FileInfo foundFile in filesInDir)
            //{
            //    string fullName = foundFile.FullName;
            //    Console.WriteLine(fullName);
            //}
            //MessageBox.Show(this.Controls.GetType().Name);
            int j = 0;
            while (j < this.Controls.Count)
            {
                //MessageBox.Show(this.Controls.GetType().Name);
                var labelToRemove = this.Controls["lbl1" + j];
                var buttonToRemove = this.Controls["btn1" + j];
                this.Controls.Remove(labelToRemove);
                this.Controls.Remove(buttonToRemove);
                j++;
            }
            //this.Update();
            //MessageBox.Show(this.Controls.Count.ToString());
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "D:\\Environments\\Application\\ASKARI\\MonetaBackOffice\\Applications";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                //MessageBox.Show("You selected: " + dialog.FileName);
                pathText.Text = directory = dialog.FileName;
            }

            string[] entries = Directory.GetFileSystemEntries(directory, "Web.config", SearchOption.AllDirectories);
            repEntries = entries;

            for (int i = 0; i < entries.Length; i++)
            {
                string[] spl = entries[i].Split('\\');
                //Create label
                Label label = new Label();
                label.Text = String.Format(spl[spl.Length - 2] + " - Web.config found.");
                label.Name = "lbl1" + i;
                label.AutoSize = true;
                //Console.WriteLine(spl[spl.Length - 2]);
                //Position label on screen
                label.Left = 20;
                label.Top = (i + 1) * 22;
                Button btn = new Button();
                btn.Text = String.Format("Replace");
                btn.Name = "btn1" + i;
                btn.Left = 240;
                btn.Top = (i + 1) * 22;
                //Create textbox
                //TextBox textBox = new TextBox();
                //Position textbox on screen
                //textBox.Left = 120;
                //textBox.Top = (i + 1) * 20;
                ///Add controls to form
                this.Controls.Add(label);
                this.Controls.Add(btn);
                //this.Controls.Add(textBox);
            }
            //MessageBox.Show(this.Controls.Count.ToString());
        }

        private void Rep_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < repEntries.Length; i++)
            {
                string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string configFile = System.IO.Path.Combine(repEntries[i], "");
                ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                configFileMap.ExeConfigFilename = configFile;
                System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                bool key = config.AppSettings.Settings.AllKeys.Contains("ConnString");
                if (key)
                {
                    config.AppSettings.Settings["ConnString"].Value = repText.Text;
                    config.Save();
                }
            }

            if (reg.Checked)
            {

                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (var myKey1 = hklm.OpenSubKey(@"SOFTWARE\TPS\Iris", true))
                {
                    if (myKey1 != null)
                    {
                        Console.WriteLine("Inside!!!");
                        myKey1.SetValue("ConnectionString", repText.Text, RegistryValueKind.String);
                        myKey1.Close();
                    }
                }
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (var myKey2 = hklm.OpenSubKey(@"SOFTWARE\TPS\Moneta", true))
                {
                    if (myKey2 != null)
                    {
                        Console.WriteLine("Inside!!!");
                        myKey2.SetValue("ConnectionString", repText.Text, RegistryValueKind.String);
                        myKey2.Close();
                    }
                }
            }
            label1.Visible = true;
            label1.BackColor = System.Drawing.Color.Red;
            label1.Text = "Done !!!";
        }
    }
}

