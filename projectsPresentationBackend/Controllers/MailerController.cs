using ArchitecturalProjectsBackend.Interfaces;
using ArchitecturalProjectsBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchitecturalProjectsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailerController : ControllerBase
    {
        private readonly IMailer _mailer;

        public MailerController(IMailer mailer)
        {
            _mailer = mailer;
        }

        [HttpPost("contactform")]
        public  ActionResult<ContactFormUserInfo> SendEmailAsync( ContactFormUserInfo userInfo)
        {
            _mailer.SendEmailAsync(userInfo);
            return Ok();
        }      
    }
}
