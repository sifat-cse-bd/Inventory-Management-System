using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace InventoryManagement.EmailHub
{
    public static class EmailAccess
    {
        public static string Email { get; set; }
        public static string CurrentOtp { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }

        public static string AppPassword { get; set; } // smtp
        public static string AppEmail { get; set; } // smtp

        private static Database.DataAccess Da = new Database.DataAccess();

        public static void GetServer(string defaultEmail = "sifatbd933@gmail.com", string defaultPass = "jrdwdgarxyifkrxy")
        {
            try
            {
                var sql = "SELECT * FROM SMTP;";
                var dt = Da.ExecuteQueryTable(sql);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Use from database
                    AppEmail = dt.Rows[0]["SMTP_Email"].ToString();
                    AppPassword = dt.Rows[0]["Email_AppPassword"].ToString();
                }
                else
                {
                    // Use default/fallback
                    AppEmail = defaultEmail;
                    AppPassword = defaultPass;
                }
            }
            catch
            {
                // Use default on error
                AppEmail = defaultEmail;
                AppPassword = defaultPass;
            }
        }

        public static async Task<bool> SendOtpEmailAsync(string email, string currentOtp, string name, string role)
        {
            try
            {
                GetServer();
                Email = email;
                CurrentOtp = currentOtp;
                Name = name;
                Role = role;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(AppEmail, "Mehedi Mart Ltd.");
                    mail.To.Add(Email);
                    mail.Subject = "Super Shop Admin Registration - OTP Verification";

                    string msg = $"Dear {Name},\n\n" +
                                 $"Thank you for registering as an {Role} at MEHEDI MART LTD.\n" +
                                 $"Your OTP is: {CurrentOtp}\n\n" +
                                 $"This OTP is valid for 90 seconds.\n\n" +
                                 $"Regards,\n" +
                                 $"MEHEDI MART LTD\n\n" +
                                 $"Organized by:\nMd. Sifat (ID: 23-51221-1)\nAyswarjo Sarkar (ID: 24-55990-1)\nAIUB";

                    mail.Body = msg;
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtpserver = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtpserver.Credentials = new NetworkCredential(AppEmail, AppPassword);
                        smtpserver.EnableSsl = true;
                        await smtpserver.SendMailAsync(mail);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


        public static async Task<bool> SendOtpEmailAsync(string email, string currentOtp)
        {
            try
            {
                GetServer();
                Email = email;
                CurrentOtp = currentOtp;

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(AppEmail, "Mehedi Mart Ltd.");
                    mail.To.Add(Email);
                    mail.Subject = "Password Reset - OTP Verification";

                    string msg = $"Your OTP is: {CurrentOtp}\n\n" +
                                 $"This OTP is valid for 90 seconds.\n\n" +
                                 $"Regards,\n" +
                                 $"MEHEDI MART LTD\n\n" +
                                 $"Organized by:\nMd. Sifat (ID: 23-51221-1)\nAyswarjo Sarkar (ID: 24-55990-1)\nAIUB";

                    mail.Body = msg;
                    mail.IsBodyHtml = false;

                    using (SmtpClient smtpserver = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtpserver.Credentials = new NetworkCredential(AppEmail, AppPassword);
                        smtpserver.EnableSsl = true;
                        await smtpserver.SendMailAsync(mail);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
