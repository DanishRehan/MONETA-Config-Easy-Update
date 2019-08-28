using Microsoft.Win32;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Connection_String
{
    public partial class Form1 : Form
    {
        string directory;
        string[] entries;
        IEnumerable<string> files;

        public Form1()
        {
            InitializeComponent();
            regCheckBox.Enabled = false;
            rep.Enabled = false;
            radioWeb.Checked = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            entries = null;
            files = null;
            msgText.Visible = false;
            exText.Visible = false;

            for(int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls.ContainsKey("lbl1" + i))
                {
                    System.Windows.Forms.Control[] ad = new System.Windows.Forms.Control[1];
                    ad = Controls.Find("lbl1" + i, true);
                    ad[0].Dispose();
                    var a = Controls.Find("lbl1" + i, true);
                }
            }
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;
            try
            {
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    //MessageBox.Show("You selected: " + dialog.FileName);
                    pathText.Text = directory = dialog.FileName;
                    rep.Enabled = true;
                }
            }
            catch (Exception ex)
            {

            }

            if (radioWeb.Checked)
            {
                try
                {
                    entries = Directory.GetFileSystemEntries(directory, "Web.config", SearchOption.AllDirectories);
                    //Console.WriteLine(String.Format(entries[0]));
                }
                catch (Exception ex)
                {
                   
                }
            }

            if(radioWin.Checked)
            {
                try
                {
                    files = Directory.EnumerateFiles(directory, "*.config", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith("AMLService.exe.config") || s.EndsWith("AutoCleanseService.exe.config") ||
                    s.EndsWith("DailyExportService.exe.config") || s.EndsWith("FundsTransferService.exe.config") ||
                    s.EndsWith("ImportService.exe.config") || s.EndsWith("VMSBOContinousMailing.exe.config") ||
                    s.EndsWith("ProcessingService.exe.config") || s.EndsWith("SmsService.exe.config") ||
                    s.EndsWith("ThirdPartyExportService.exe.config"));
                }
                catch (Exception ex)
                {

                }
                /*foreach (string a in files)
                {
                    Console.WriteLine(a);
                }*/
            }

            if (entries != null)
            {
                for (int i = 0; i < entries.Length; i++)
                {
                    string[] spl = entries[i].Split('\\');
                    //Create label
                    Label label = new Label();
                    label.Text = String.Format(spl[spl.Length - 2] + " - Web.config found.");
                    label.Name = "lbl1" + i;
                    //Console.WriteLine(label.Name);
                    label.AutoSize = true;
                    //Console.WriteLine(spl[spl.Length - 1]);
                    //Position label on screen
                    label.Left = 300;
                    label.Top = (i + 1) * 22;
                    //Button btn = new Button();
                    //btn.Text = String.Format("Replace");
                    //btn.Name = "btn1" + i;
                    //btn.Left = 240;
                    //btn.Top = (i + 1) * 22;
                    //Create textbox
                    //TextBox textBox = new TextBox();
                    //Position textbox on screen
                    //textBox.Left = 120;
                    //textBox.Top = (i + 1) * 20;
                    ///Add controls to form
                    this.Controls.Add(label);
                    //this.Controls.Add(btn);
                    //this.Controls.Add(textBox);
                }
            }

            if (files != null)
            {
                int i = 0;
                try
                {
                    foreach (string a in files)
                    {
                        string[] spl = a.Split('\\');
                        //Create label
                        //Console.WriteLine(a);
                        Label label = new Label();
                        label.Text = String.Format(spl[spl.Length - 2] + " - exe.config found.");
                        label.Name = "lbl1" + i;
                        label.AutoSize = true;
                        //Console.WriteLine(spl[spl.Length - 2]);
                        //Position label on screen
                        label.Left = 300;
                        label.Top = (i + 1) * 22;
                        ///Add controls to form
                        this.Controls.Add(label);
                        i++;
                    }
                }
                catch
                {

                }
            }
            //MessageBox.Show(this.Controls.Count.ToString());
        }

        private void Rep_Click(object sender, EventArgs e)
        {
            if (radioWeb.Checked)
            {
                for (int i = 0; i < entries.Length; i++)
                {
                    /*string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    string configFile = System.IO.Path.Combine(entries[i], "");
                    ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                    configFileMap.ExeConfigFilename = configFile;
                    System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                    bool key = config.AppSettings.Settings.AllKeys.Contains(xmlCombo.Text);
                    if (key)
                    {
                        config.AppSettings.Settings[xmlCombo.Text].Value = repText.Text;
                        config.Save();
                    }*/
                    var doc = XDocument.Load(entries[i]);
                    try
                    {
                        var myList = from appNode in doc.Descendants("appSettings").Elements()
                                    where appNode.Attribute("key").Value == xmlCombo.Text
                                    select appNode;
                        var myElement = myList.FirstOrDefault();
                        myElement.Attribute("value").SetValue(repText.Text);
                        doc.Save(entries[i]);
                    }
                    catch
                    {
                        exText.Text = entries[i] + " - " + xmlCombo.Text + " not found.";
                        exText.Visible = true;
                    }
                }
            }
            else
            {
                foreach (string file in files)
                {
                    /*string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    string configFile = System.IO.Path.Combine(file, "");
                    ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
                    configFileMap.ExeConfigFilename = configFile;
                    System.Configuration.Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                    bool key = config.AppSettings.Settings.AllKeys.Contains(xmlCombo.Text);
                    if (key)
                    {
                        config.AppSettings.Settings[xmlCombo.Text].Value = repText.Text;
                        config.Save();
                    }*/
                    var doc = XDocument.Load(file);
                    try
                    {
                        var myList = from appNode in doc.Descendants("appSettings").Elements()
                                     where appNode.Attribute("key").Value == xmlCombo.Text
                                     select appNode;
                        var myElement = myList.FirstOrDefault();
                        myElement.Attribute("value").SetValue(repText.Text);
                        doc.Save(file);
                    }
                    catch
                    {
                        exText.Text = file + " - " + xmlCombo.Text + " not found.";
                        exText.Visible = true;
                    }
                }
            }
            if (regCheckBox.Checked && regCheckBox.Enabled)
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (var myKey1 = hklm.OpenSubKey(@"SOFTWARE\TPS\Iris", true))
                {
                    if (myKey1 != null)
                    {
                        myKey1.SetValue("ConnectionString", repText.Text, RegistryValueKind.String);
                        myKey1.Close();
                    }
                }
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
                using (var myKey2 = hklm.OpenSubKey(@"SOFTWARE\TPS\Moneta", true))
                {
                    if (myKey2 != null)
                    {
                        myKey2.SetValue("ConnectionString", repText.Text, RegistryValueKind.String);
                        myKey2.Close();
                    }
                }
            }
            //MessageBox.Show("Tags have been replaced.");
            msgText.Text = "Tags have been replaced!";
            msgText.Visible = true;
        }

        private void XmlCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!(xmlCombo.SelectedItem.ToString() == "ConnString"))
            {
                regCheckBox.Checked = false;
                regCheckBox.Enabled = false;
            }
            else
            {
                regCheckBox.Enabled = true;
            }
        }

        private void RegCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (xmlCombo.SelectedItem == null)
            {
                regCheckBox.Checked = false;
                regCheckBox.Enabled = false;
            }
        }

        private void RadioWeb_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWeb.Checked)
            {
                radioWin.Checked = false;
                directory = pathText.Text = "";
                rep.Enabled = false;
            }
        }

        private void RadioWin_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWin.Checked)
            {
                radioWeb.Checked = false;
                directory = pathText.Text = "";
                rep.Enabled = false;
            }
        }
    }
}