﻿using AutoMapper;
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
    public class EstadoSaludController : Controller
    {
        private readonly MedicaService _medicaService;
        private readonly IMapper _mapper;

        public EstadoSaludController(MedicaService medicaService, IMapper mapper)
        {
            _medicaService = medicaService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _medicaService.ListaEstadosSalud();
            return Ok(listado);
        }
    }
}
