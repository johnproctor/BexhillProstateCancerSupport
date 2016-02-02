using BPCS.Models;
using SendGrid;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace BPCS.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ContactModel model)
        {

            var message = new SendGridMessage();
            message.From = new MailAddress(model.EmailAddress);
            message.AddTo(ConfigurationManager.AppSettings["EmailTo"]);
            message.Text = model.Message;
            message.Subject = String.Format("Website email from {0}", model.Name);

            var credentials = new NetworkCredential(ConfigurationManager.AppSettings["EmailUsername"], ConfigurationManager.AppSettings["EmailPassword"]);
            // Create an Web transport for sending email.
            var transportWeb = new Web(credentials);

            transportWeb.DeliverAsync(message).Wait();

            return View();
        }
    }
}