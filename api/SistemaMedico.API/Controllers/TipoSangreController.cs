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
    public class TipoSangreController : Controller
    {
        private readonly MedicaService _medicaService;
        private readonly IMapper _mapper;

        public TipoSangreController(MedicaService medicaService, IMapper mapper)
        {
            _mapper = mapper;
            _medicaService = medicaService;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _medicaService.ListaTiposSangre();
            return Ok(listado);
        }
    }
}
