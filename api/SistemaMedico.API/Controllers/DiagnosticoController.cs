using AutoMapper;
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
    public class DiagnosticoController : Controller
    {
        private readonly MedicaService _medicaService;
        private readonly IMapper _mapper;

        public DiagnosticoController(MedicaService medicaService, IMapper mapper)
        {
            _medicaService = medicaService;
            _mapper = mapper;

        }
        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _medicaService.ListaDiagnosticos();
            return Ok(listado);
        }

        [HttpGet("ListadoDiagEntre")]
        public IActionResult ListadoDiagEntr(int Diag_Id)
        {
            var listado = _medicaService.ListaDiagnosticosEntrenamientos(Diag_Id);
            return Ok(listado);
        }

        [HttpGet("ListadoDiagDieta")]
        public IActionResult ListadoDiagDieta(int Diag_Id)
        {
            var listado = _medicaService.ListaDiagnosticosDietas(Diag_Id);
            return Ok(listado);
        }

        [HttpGet("BuscarPersona")]
        public IActionResult Details(int Usua_Id)
        {
            var list = _medicaService.BuscarDiagnosticosPersonas(Usua_Id);

            return Ok(list);
        }
    }
}
