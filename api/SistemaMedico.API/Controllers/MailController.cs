using Microsoft.AspNetCore.Mvc;
using SistemaMedico.API.Servicios;
using SistemaMedico.BunisessLogic.Services;
using SistemaMedico.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedico.API.Controllers
{
     [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;
        //injecting the IMailService into the constructor
        public MailController(IMailService _MailService)
        {
            _mailService = _MailService;
        }

        [HttpPost]
        [Route("SendMail")]
        public bool SendMail(MailData mailData)
        {
            return _mailService.SendMail(mailData);
        }
    }
}
