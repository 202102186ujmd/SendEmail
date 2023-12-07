using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendEmail.Services;
using SendEmail.Models;

namespace SendEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        //Inyeccion de dependencias
        #region
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        #endregion

        //Metodo para enviar email

        #region EnviarEmail
        [HttpPost("EnviarEmail")]
        public IActionResult SendEmail(EmailDTO request)
        {
            _emailService.SendEmail(request);//Llamado al metodo
            return Ok("Email enviado con exito");//Respuesta
        }
        #endregion
    }
}
