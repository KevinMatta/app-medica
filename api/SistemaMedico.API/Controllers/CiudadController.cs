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
    public class CiudadController : Controller
    {
        private readonly GeneralService _generalService;
        private readonly IMapper _mapper;

        public CiudadController(GeneralService generalService, IMapper mapper)
        {
            _generalService = generalService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _generalService.ListaCiudades();
            return Ok(listado);
        }

    }
}
