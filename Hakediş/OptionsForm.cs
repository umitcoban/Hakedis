using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Hakediş
{
    public partial class OptionsForm : Form
    {
        bool startAutoApp = false;
        public string path;
        public string fileName;
        public OptionsForm()
        {
            InitializeComponent();
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

        }
        public void GetExeLocation()
        {
            path = System.Reflection.Assembly.GetEntryAssembly().Location; // for getting the location of exe file ( it can change when you change the location of exe)
            fileName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name; // for getting the name of exe file( it can change when you change the name of exe)
            StartExeWhenPcStartup(fileName, path); // start the exe autometically when computer is stared.
        }

        public void StartExeWhenPcStartup(string filename, string filepath)
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue(filename, filepath);
        }
        #endregion
        private void btnAutoStart_Click(object sender, EventArgs e)
        {
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
        }

        private void btnOptionsExit_Click(object sender, EventArgs e)
        {
            //RegisterInStartup(startAutoApp);
            GetExeLocation();
            this.Close();
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
