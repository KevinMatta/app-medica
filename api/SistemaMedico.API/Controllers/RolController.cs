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
    public class RolController : Controller
    {
        private readonly AccesoService _accesoService;
        private readonly IMapper _mapper;

        public RolController(AccesoService accesoService, IMapper mapper)
        {
            _accesoService = accesoService;
            _mapper = mapper;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _accesoService.ListarRoles();
            return Ok(listado);
        }
    }
}