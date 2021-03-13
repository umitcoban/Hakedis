using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
namespace Hakediş
{
   static class ConnectAndSendMail
    {
      static public bool Email_Send(string toEmail,string body,string subject,string userName,string pass,string filePath,string filePath2)
        {
            MailMessage mail = new MailMessage();
            try
            {
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
                mail.From = new MailAddress(userName);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                System.Net.Mail.Attachment attachment;
                System.Net.Mail.Attachment attachment2;
                attachment = new System.Net.Mail.Attachment(filePath);
                attachment2 = new System.Net.Mail.Attachment(filePath2);
                mail.Attachments.Add(attachment);
                mail.Attachments.Add(attachment2);
                SmtpServer.Port = 587;
                SmtpServer.EnableSsl = true;
                SmtpServer.UseDefaultCredentials = false;
                NetworkCredential nc = new NetworkCredential(userName, pass);
                SmtpServer.Credentials = nc;
                //SmtpDeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                SmtpServer.Send(mail);
            }
            catch (Exception)
            {
                mail.Attachments.Clear();
                return false;
            }
            return true;
            //Microsoft.Office.Interop.Outlook.Application OutlookObject = new Microsoft.Office.Interop.Outlook.Application();

            ////Outlook programına gönderilmek üzere MailItem nesnesinin bir instance oluşturuyoruz
            //Microsoft.Office.Interop.Outlook.MailItem MailObject = (Microsoft.Office.Interop.Outlook.MailItem)(OutlookObject.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem));

            ////Mesajı gönderen "TO"
            //MailObject.To = toEmail;
            ////İhtiyaca göre "CC" ve "BCC" eklenmesi
            ////MailObject.CC = ccTextBox.Text;
            ////MailObject.BCC = bccTextBox.Text;

            //// Mail başlığının eklenmesi
            //MailObject.Subject = subject;

            //MailObject.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceNormal;

            //// Mesaj içeriği metin yada keyfinize göre HTML ekleyebilirsiniz
            //MailObject.HTMLBody = body;

            //// Mail'e attachment yani ek eklenmsi, birden çok ek te ekleyebilirsiniz
            //MailObject.Attachments.Add(filePath, Microsoft.Office.Interop.Outlook.OlAttachmentType.olByValue, 1, "Ek Adı");

            //// Hazırladığınız mail template istediğiniz yere kaydetmenizi sağlar,
            ////ayrıca file dialog açar ve istediğiniz yeri seçmenize de izin verir
            ////MailObject.SaveAs(@"C:\demo.msg", Microsoft.Office.Interop.Outlook.OlSaveAsType.olMSG);

            ////Maili outlook açılarak içinde pencere olarak göterilemesini sağlar gönder butonuna siz basarsınız
            ////MailObject.Display();

            ////Maili direk yollamak isterseniz bu kodu kullanırsınız, pencere gösterilmeden direk yollanır. 
            ////(Bunu kullanacaksanız Display kodunu kapatmak gerek)
            //MailObject.Send();  
        }
    }
}
