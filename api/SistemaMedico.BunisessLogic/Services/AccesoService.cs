using System;
using SistemaMedico.DataAcces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaMedico.Entities.Entities;

namespace SistemaMedico.BunisessLogic.Services
{
    public class AccesoService
    {
        private readonly UsuariosRepository _usuariosRepository;
        private readonly RolesRepository _rolesRepository;
        private readonly PantallasRepository _pantallasRepository;
        private readonly PantallasPorRolesRepository _pantallasPorRolesRepository;
        public AccesoService(UsuariosRepository usuariosRepository, RolesRepository rolesRepository, PantallasRepository pantallasRepository, PantallasPorRolesRepository pantallasPorRolesRepository)
        {
            _usuariosRepository = usuariosRepository;
            _rolesRepository = rolesRepository;
            _pantallasRepository = pantallasRepository;
            _pantallasPorRolesRepository = pantallasPorRolesRepository;
        }

        #region Pantallas
        public ServicesResult ListaPantallas()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _pantallasRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbPantallas> BuscarPantallas(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _pantallasRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbPantallas>();
            }
        }
        #endregion

        #region Roles
        public ServicesResult ListarRoles()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _rolesRepository.List();
                return result.Ok();
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public IEnumerable<tbRoles> BuscarRoles(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _rolesRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbRoles>();
            }
        }
        #endregion

        #region PantallasPorRoles
        public ServicesResult ListarPantallasRoles()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _pantallasPorRolesRepository.List();
                return result.Ok();
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public IEnumerable<tbPantallasPorRoles> BuscarPantallasPorRoles(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _pantallasPorRolesRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbPantallasPorRoles>();
            }
        }
        #endregion

        #region Usuarios
        public ServicesResult ListarUsuarios()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.List();
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServicesResult InsertarUsuarios(tbUsuarios item)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.Insert(item);
                if(lost.CodeStatus >0)
                {
                    return result.Ok(lost);

                }
                else
                {
                    return result.Error(lost);
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServicesResult ActualizarUsuarios(tbUsuarios item)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.Update(item);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServicesResult RestablecerContrasenia(tbUsuarios item)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.RestablecerContra(item);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServicesResult Login(string Usuario, string Contra)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.Login(Usuario, Contra);
                if(lost != null)
                {
                    return result.Ok(lost);

                }
                else
                {
                    return result.Error();
                }
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        public ServicesResult ValidarUsuario(string Usuario)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.ValidarUsuario(Usuario);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        
        public ServicesResult EliminarUsuario(int Id)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.Delete(Id);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public IEnumerable<tbUsuarios> BuscarUsuario(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _usuariosRepository.Find(Id);
            }
            catch 
            {
                return Enumerable.Empty<tbUsuarios>();
            }
        }

        public ServicesResult ValidarClave(string Contra)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.ValidarClave(Contra);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServicesResult ValidarRestablecer(string corus)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _usuariosRepository.ValidarCorreoUsuario(corus);
                return result.Ok(lost);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }


        public ServicesResult Implementarcodigo(string codigo, int usuarioId)
        {
            var result = new ServicesResult();
            try
            {
                var list = _usuariosRepository.IngresarCodigo(codigo, usuarioId);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }

        public ServicesResult ValidarCodigo(tbUsuarios item)
        {
            var result = new ServicesResult();
            try
            {
                var list = _usuariosRepository.ValidarCodigo(item);
                return result.Ok(list);
            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);
            }
        }
        #endregion
    }
}
