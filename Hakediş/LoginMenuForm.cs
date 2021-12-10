using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
namespace Hakediş
{
    public partial class LoginMenuForm : Form
    {
        static readonly string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(path);
        readonly string userConfigPathFile = pathApplication + @"\UserConfig.json";
        List<User> users = new List<User>();
        public LoginMenuForm()
        {
            InitializeComponent();
            CheckFilePath();
        }

        private void ıconBtnPayee_Click(object sender, EventArgs e)
        { 
            CreateNewUserConfig(UserTypeEnum.Payee,1);
        }

        private void LoginMenuForm_Load(object sender, EventArgs e)
        {
            if (CheckAlreadyRunningApp.CheckApp())
            {
                MessageBox.Show("Uygulama Şuanda Çalışmakta !");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void CreateNewUserConfig(UserTypeEnum @enum,short parameter)
        {
            try
            {
                User user = new User();
                user.Usertype = @enum;
                user.CalculateParameter = parameter;
                users.Add(user);
                string jsonUserConfigData = Newtonsoft.Json.JsonConvert.SerializeObject(users);
                File.WriteAllText(userConfigPathFile, jsonUserConfigData);
                MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Oluşturuldu !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show("Bir Hata Oluştu!", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void CheckFilePath()
        {
            if (File.Exists(userConfigPathFile) && new FileInfo(userConfigPathFile).Length > 0)
            {
                //LoginMenuForm.Visible = false;
                Hide();
                Application.Run(new MainMenu());
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void ıconBtnPayed_Click(object sender, EventArgs e)
        {
            CreateNewUserConfig(UserTypeEnum.Paying, -1);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
