//using ProfessionalGYM.DataTransferModel.ResponseVM;
//using static ProfessionalGYM.DataTransferModel.ResponseVM.ResponseVM;

//namespace ProfessionalGYM.CommonMethods
//{
//    public class Methods
//    {
//        private readonly string smtpServer = "smtp.gmail.com";
//        private readonly int smtpPort = 465;

//        private readonly string smtpUsername = "mr.wordsense2.0@gmail.com";
//        private readonly string smtpPassword = "tjnnlcklajczerxi";

//        public static ResponseVM SendEmailAsync(string toEmail, string subject, string body)
//        {

//            ResponseVM response = ResponseVM.Instance;

//            try
//            {
//                using (var smtpClient = new MailKit.Net.Smtp.SmtpClient())
//                {
//                    smtpClient.ServerCertificateValidationCallback = (s, c, h, e) => true;

//                    smtpClient.Connect("smtp.gmail.com", 465, SecureSocketOptions.SslOnConnect);
//                    smtpClient.Authenticate("mr.wordsense2.0@gmail.com", "tjnnlcklajczerxi");

//                    var message = new MimeMessage();
//                    message.From.Add(new MailboxAddress("InFluencer", "mr.wordsense2.0@gmail.com"));
//                    message.To.Add(new MailboxAddress("InFluencer", toEmail));
//                    message.Subject = subject;
//                    message.Body = new TextPart("html") { Text = body };

//                    smtpClient.Send(message);
//                    smtpClient.Disconnect(true);
//                }
//            }
//            catch (Exception ex)
//            {
//                response.responseCode = ResponseCode.BadRequest;
//                response.errorMessage = "Failed to send email: " + ex.Message;

//                var methods = new Methods();

//            }

//            return response;

//        }
//    }
//}
