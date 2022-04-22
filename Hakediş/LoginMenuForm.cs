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
using System.Diagnostics;
namespace Hakediş
{
    public partial class LoginMenuForm : Form
    {
        Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        static readonly string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        readonly string jsonAppVersionConfigPathFile = pathApplication + @"\AppVersionConfig.json";
        readonly static string pathApplication = System.IO.Path.GetDirectoryName(path);
        readonly string userConfigPathFile = pathApplication + @"\UserConfig.json";
        readonly string appHakedisUpdaterPath = pathApplication + @"\UpdaterHakedis.exe";
        List<User> users = new List<User>();
        public LoginMenuForm()
        {
            InitializeComponent();
            CheckFilePath();
            //CreateCurrentVersionFile();
            //CheckUpdaterAppDone();
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
            else
            {
  
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void CreateCurrentVersionFile()
        {
            AppVersion appVersion = new AppVersion();
            appVersion.Major = version.Major;
            appVersion.Minor = version.Minor;
            appVersion.Build = version.Build;
            appVersion.Revision = version.Revision;
            var jsonData = JsonConvert.SerializeObject(appVersion);
            File.WriteAllText(jsonAppVersionConfigPathFile, jsonData);
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        private void CheckUpdaterAppDone()
        {
            if (File.Exists(pathApplication + @"\check.txt"))
            {
                File.Delete(pathApplication + @"\check.txt");
            }
            else
            {
                var p = new Process();
                p.StartInfo.FileName = appHakedisUpdaterPath;
                p.Start();
                Application.Exit();
                File.Delete(pathApplication + @"\check.txt");
            }
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
                this.Visible = false;
                Hide();
                Application.Run(new MainMenu());
                //MainMenu mainMenu = new MainMenu();
                //mainMenu.Show();
                //this.Hide();
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
