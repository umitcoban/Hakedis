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
                    registryKey.SetValue("C:/Hakediş.exe", Application.ExecutablePath);
                    MessageBox.Show("Uygulama Otomatik Başlamaya Ayarlanmıştır !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    registryKey.DeleteValue("C:/Hakediş.exe");
                    MessageBox.Show("Uygulama Otomatik Başlama İptal Edilmiştir !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {

            }

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
            RegisterInStartup(startAutoApp);
            this.Close();
        }
    }
}
