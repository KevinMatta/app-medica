using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SistemaMedico.API.Servicios;
using SistemaMedico.BunisessLogic.Services;
using SistemaMedico.Common.Models;
using SistemaMedico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedico.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly AccesoService _accesoService;
        private readonly IMapper _mapper;
        private readonly IMailService _mailService;
        public UsuarioController(AccesoService accesoService, IMapper mapper, IMailService mailService)
        {
            _accesoService = accesoService;
            _mapper = mapper;
            _mailService = mailService;
        }

        [HttpGet("Listado")]
        public IActionResult Index()
        {
            var listado = _accesoService.ListarUsuarios();

            return Ok(listado);
        }


        [HttpPost("UsuarioCrear")]
        public IActionResult Insert(UsuariosViewModel item)
        {
            var model = _mapper.Map<tbUsuarios>(item);
            var modelo = new tbUsuarios()
            {
                Usua_Usuario = item.Usua_Usuario,
                Usua_Clave = item.Usua_Clave,
                Usua_IsAdmin = item.Usua_IsAdmin,
                Rol_Id = item.Rol_Id,
                Usua_Creacion = 1,
                Usua_FechaCreacion = DateTime.Now,


            };
            var list = _accesoService.InsertarUsuarios(modelo);
            return Ok(list);
        }




        [HttpPut("UsuarioActualizar")]
        public IActionResult Update(UsuariosViewModel item)
        {

            var model = _mapper.Map<tbUsuarios>(item);
            var modelo = new tbUsuarios()
            {
                Usua_Id = item.Usua_Id,
                Usua_Usuario = item.Usua_Usuario,
                Usua_Clave = item.Usua_Clave,
                Usua_IsAdmin = item.Usua_IsAdmin,
                Rol_Id = item.Rol_Id,
                Usua_Modificacion = 1,
                Usua_FechaModificacion = DateTime.Now,

            };
            var list = _accesoService.ActualizarUsuarios(modelo);
            return Ok(list);
        }



        [HttpPut("RestablacerContrasena")]
        public IActionResult restablecer(UsuariosViewModel item)
        {
            var model = new tbUsuarios()
            {
                Usua_Clave = item.Usua_CodigoV,

            };
            var lista = _accesoService.ValidarCodigo(model);

            if (lista.Success == true)
            {
                var modelo = new tbUsuarios()
                {
                    Usua_Id = item.Usua_Id,
                    Usua_Clave = item.Usua_Clave,
                    Usua_Modificacion = 1,
                    Usua_FechaModificacion = DateTime.Now,

                };
                var list = _accesoService.RestablecerContrasenia(modelo);
                if (list.Success == true)
                {
                    return Ok(list);
                }
                else
                {
                    return Problem();
                }
            }
            else
            {
                return Problem();
            }
        }


        [HttpGet("UsuarioLlenar/{Usua_Id}")]
        public IActionResult LlenarUsuario(int Usua_Id)
        {
            var llenar = _accesoService.BuscarUsuario(Usua_Id).ToList();
            var id = llenar.FirstOrDefault()?.Usua_Id;
            var nombre = llenar.FirstOrDefault()?.Usua_Usuario;
            var contra = llenar.FirstOrDefault()?.Usua_Clave;
            var admin = llenar.FirstOrDefault()?.Usua_IsAdmin;
            var rol = llenar.FirstOrDefault()?.Rol_Id;



            return Json(new { success = true, id, nombre, contra, admin, rol });
        }


        [HttpDelete("UsuarioEliminar/{Usua_Id}")]
        public IActionResult Delete(int Usua_Id)
        {

            var list = _accesoService.EliminarUsuario(Usua_Id);

            return Ok(list);

        }

        [HttpGet("BuscarUsuario")]
        public IActionResult Details(int Usua_Id)
        {
            var list = _accesoService.BuscarUsuario(Usua_Id);
            
            return Ok(list);
        }

        [HttpGet("Login")]
        public IActionResult Login(string Usuario, string Contra)
        {
            //var usuario = _accesoService.ValidarUsuario(Usuario);
            //var clave = _accesoService.ValidarClave(Contra);
            var list = _accesoService.Login(Usuario, Contra);
            if (!list.Success)
            {
                return Problem();
            }
            else
            {
                return Ok(list);

            }
        }

        [HttpGet("validarRestablecer")]
        public IActionResult validarRestablecer(string usuario)
        {
            Random random = new Random();
            int randomNumber = random.Next(100000, 1000000);
            var estado = _accesoService.ValidarRestablecer(usuario);
            var lista = estado.Data;
            if(lista.Count > 0)
            {
                var datos = estado.Data as List<tbUsuarios>;
                var first = datos.FirstOrDefault();
                _accesoService.Implementarcodigo(randomNumber.ToString(), first.Usua_Id);
                MailData mailData = new MailData();
                mailData.EmailToId = first.Usua_CorreoElectronico;
                mailData.EmailToName = "Usuario";
                mailData.EmailSubject = "Su codigo para restablecer contraseña es el siguiente";
                mailData.EmailBody = "" + randomNumber.ToString();
                _mailService.SendMail(mailData);
                return Ok(estado);
            }
            else
            {
                return Problem();
            }
        }




    }
}
