using Microsoft.AspNetCore.Mvc;
using SistemaMedico.BunisessLogic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedico.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnfermedadPorPersonaController : Controller
    {
        private readonly MedicaService _medicaService;
        public EnfermedadPorPersonaController(MedicaService medicaService)
        {
            _medicaService = medicaService;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _medicaService.ListaEnfermedadesPorPersona();
            return Ok(listado);
        }
    }
}
