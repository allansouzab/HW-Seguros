using System.Web.Mvc;
using HardWorkSegurosWebSite.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System;
using System.Text;

namespace HardWorkSegurosWebSite.Controllers
{
    public class ContatoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SentTrue()
        {
            return View();
        }

        public ActionResult SentNotTrue()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email de: {0} ({1})</p><p>Celular: {2}</p><p>Mensagem: {3}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("seguros@hardworkbr.com.br"));  // replace with valid value 
                //message.To.Add(new MailAddress("allansouzab@hotmail.com"));  // replace with valid value 
                message.From = new MailAddress("WebsiteHardWork@hotmail.com");  // replace with valid value
                message.Subject = "HardWork Seguros - Contato";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Celular, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "WebsiteHardWork@hotmail.com",  // replace with valid value
                        Password = "All@n1souza2"  // replace with valid value
                    };
                    smtp.Host = "smtp.live.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    smtp.Credentials = credential;
                    await smtp.SendMailAsync(message);

                    ViewBag.EmailReturn = "Email enviado com sucesso. Retornaremos em breve!";
                    return RedirectToAction("SentTrue");
                }
            }
            ViewBag.EmailReturn = "Falha ao enviar email. Tente novamente em alguns instantes!";
            return RedirectToAction("SentNotTrue");
        }

    }
}