﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace Hakediş
{
    public partial class OptionsForm : Form
    {
        private readonly MainMenu mainMenu;
        static string appPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(appPath);
        readonly string jsonMailUpdateDataPath = pathApplication + @"\jsonMailUpdateData.json";
        readonly string jsonUserConfigPathFile = pathApplication + @"\UserConfig.json";

        public List<UpdateMail> updateMails { get; set; }
        bool autoUpdate = true;
        bool startAutoApp = true;
        public string path;
        public string fileName;
        public OptionsForm(MainMenu main)
        {
            InitializeComponent();
            updateMails = new List<UpdateMail>();
            mainMenu = main;
        }
        #region Uygulama Ayarları

        private void RegisterInStartup(bool isChecked)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey
                         ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (isChecked)
                {
                    registryKey.SetValue("Hakediş", Application.ExecutablePath);
                    MessageBox.Show("Uygulama Otomatik Başlamaya Ayarlanmıştır !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    registryKey.DeleteValue("Hakediş");
                    MessageBox.Show("Uygulama Otomatik Başlama İptal Edilmiştir !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        public void GetExeLocation(bool isChecked)
        {
            path = System.Reflection.Assembly.GetEntryAssembly().Location; // for getting the location of exe file ( it can change when you change the location of exe)
            fileName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name; // for getting the name of exe file( it can change when you change the name of exe)
            StartExeWhenPcStartup(fileName, path, isChecked); // start the exe autometically when computer is stared.
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        public void StartExeWhenPcStartup(string filename, string filepath,bool isChecked)
        {
            if (isChecked)
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue(filename,filepath);
                //MessageBox.Show("Uygulama Otomatik Başlamaya Ayarlanmıştır !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue(filename, false);
                //MessageBox.Show("Uygulama Otomatik Başlama İptal Edilmiştir !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();

        }
        #endregion
        #region Dosyaları Yedekleme
        bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #region Data İşlemleri
        private void CreateNewBackup()
        {
            try
            {
                UpdateMail updateMail = new UpdateMail();
                var nowDate = DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"));
                updateMail.UserName = maskedtxtUsername.Text;
                updateMail.Password = maskedTxtPass.Text;
                updateMail.UpdateDate = comboBoxSelectUpdateDay.SelectedItem.ToString();
                updateMail.ToEmail = maskedTxtToEmail.Text;
                updateMail.LastUpdateDate = nowDate.AddDays(-1);
                updateMails.Add(updateMail);
                var jsonData = JsonConvert.SerializeObject(updateMails);
                File.WriteAllText(jsonMailUpdateDataPath,jsonData);
                mainMenu.BackupData(DateTime.Now.ToString("dddd"));
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu !", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion
        private void BackupFile()
        {
                if (autoUpdate)
                {
                    if (IsValidEmail(maskedTxtToEmail.Text)&&IsValidEmail(maskedtxtUsername.Text) && maskedTxtPass.Text != "" && comboBoxSelectUpdateDay.SelectedItem != null)
                    {
                    CreateNewBackup();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Geçerli Değerler Giriniz !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        autoUpdate = false;
                    }
                }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        #endregion
        private void btnChangeFunction(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "btnAutoStart":
                    if (!startAutoApp)
                    {
                        startAutoApp = true;
                        btnAutoStart.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
                        btnAutoStart.Text = "Otomatik Başlat";
                    }
                    else
                    {
                        btnAutoStart.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
                        startAutoApp = false;
                        btnAutoStart.Text = "Otomatik Başlatmayı İptal Et";
                    }
                    break;
                case "btnAutoUpdate":
                    if (!autoUpdate)
                    {
                        btnAutoUpdate.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
                        btnAutoUpdate.Text = "Otomatik Yedekle";
                        autoUpdate = true;
                        comboBoxSelectUpdateDay.Visible = true;
                        lblUserName.Visible = true;
                        lblPass.Visible = true;
                        maskedTxtPass.Visible = true;
                        maskedtxtUsername.Visible = true;
                        comboBoxSelectUpdateDay.Visible = true;
                        maskedTxtToEmail.Visible = true;
                        lblToEmail.Visible = true;
                        chckboxShowPass.Visible = true;
                    }
                    else
                    {
                        btnAutoUpdate.IconChar = FontAwesome.Sharp.IconChar.Box;
                        btnAutoUpdate.Text = "Otomatik Yedeklemeyi İptal Et";
                        comboBoxSelectUpdateDay.Visible = false;
                        lblToEmail.Visible = false;
                        autoUpdate = false;
                        lblUserName.Visible = false;
                        lblPass.Visible = false;
                        maskedTxtPass.Visible = false;
                        maskedtxtUsername.Visible = false;
                        comboBoxSelectUpdateDay.Visible = false;
                        maskedTxtToEmail.Visible = false;
                        chckboxShowPass.Visible = false;
                    }
                    break;
                default:
                    break;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void btnOptionsExit_Click(object sender, EventArgs e)
        {
            if (autoUpdate&&startAutoApp)
            {
                GetExeLocation(startAutoApp);
                BackupFile();
            }
            else if(autoUpdate)
            {
                GetExeLocation(startAutoApp);
                BackupFile();
            }
            else if(startAutoApp)
            {
                File.Delete(jsonMailUpdateDataPath);
                GetExeLocation(startAutoApp);
            }
            else
            {
                File.Delete(jsonMailUpdateDataPath);
                GetExeLocation(startAutoApp);
            }
            MessageBox.Show("Uygulama Ayarları Tamamlandı!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void BackUpDataFileItem()
        {
            if (File.Exists(jsonMailUpdateDataPath) && new FileInfo(jsonMailUpdateDataPath).Length > 0)
            {
                List<UpdateMail> updateMails = new List<UpdateMail>();
                updateMails = DataListing.ReadBackupInfo(jsonMailUpdateDataPath,updateMails);
                comboBoxSelectUpdateDay.SelectedItem = updateMails[0].UpdateDate;
                maskedtxtUsername.Text = updateMails[0].UserName;
                maskedTxtPass.Text = updateMails[0].Password;
                maskedTxtToEmail.Text = updateMails[0].ToEmail;
            }
            else
            {
                btnAutoUpdate.PerformClick();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void OptionsForm_Load(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(217, 499);
            BackUpDataFileItem();
        }

        private void chckboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chckboxShowPass.Checked)
            {
                maskedTxtPass.UseSystemPasswordChar = false;
            }
            else
            {
                maskedTxtPass.UseSystemPasswordChar = true;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ıconBtnNewUser_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Yeni Kullanıcı Oluşturmak İstediğinize Eminmisiniz ?","Yeni Kullanıcı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                File.Delete(jsonUserConfigPathFile);
                Application.Restart();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        
    }
}
