using Dapper;
using Microsoft.Data.SqlClient;
using SistemaMedico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.DataAcces.Repository
{
    public class UsuariosRepository : IRepository<tbUsuarios>
    {
        public RequestStatus Delete(int? id)
        {
            string sql = ScriptsDatabase.UsuariosEliminar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Usua_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public IEnumerable<tbUsuarios> Find(int? id)
        {
            string sql = ScriptsDatabase.UsuariosBuscar;
            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usua_Id" , id);
                result = db.Query<tbUsuarios>(sql, parametro, commandType: CommandType.StoredProcedure).ToList();

                return result;

            }
        }

        public RequestStatus Insert(tbUsuarios item)
        {
            string sql = ScriptsDatabase.UsuariosCrear;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usuario", item.Usua_Usuario);
                parametro.Add("@UsuaClave", item.Usua_Clave);
                parametro.Add("@UsuaIsAdmin", item.Usua_IsAdmin);
                parametro.Add("@Rol_Id", item.Rol_Id);
                parametro.Add("@UsuaCreacion", item.Usua_Creacion);
                parametro.Add("@FechaCreacion", item.Usua_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);
                string mensaje = (result == 1) ? "exito" : "error";
                return new RequestStatus { CodeStatus = result, MessageStatus = mensaje };

            }
            //throw new NotImplementedException();
        }

        public IEnumerable<tbUsuarios> List()
        {
            string sql = ScriptsDatabase.UsuariosListar;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbUsuarios>(sql, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbUsuarios item)
        {
            string sql = ScriptsDatabase.UsuariosActualizar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usua_Id", item.Usua_Id);
                parametro.Add("@Usuario", item.Usua_Usuario);
                parametro.Add("@UsuaIsAdmin", item.Usua_IsAdmin);
                parametro.Add("@Rol_Id", item.Rol_Id);
                parametro.Add("@UsuaModificacion", item.Usua_Modificacion);
                parametro.Add("@FechaModificacion", item.Usua_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public RequestStatus RestablecerContra(tbUsuarios item)
        {
            string sql = ScriptsDatabase.UsuariosRestablecerClave;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usua_Id", item.Usua_Id);
                parametro.Add("@Usua_Clave", item.Usua_Clave);
                parametro.Add("@Usua_Modificacion", item.Usua_Modificacion);
                parametro.Add("@Usua_FechaModificacion", item.Usua_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public tbUsuarios Login(string Usuario, string Contra)
        {
            string sql = ScriptsDatabase.UsuariosLogin;

            tbUsuarios result = new tbUsuarios();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Usuario", Usuario);
                parameters.Add("@Clave" , Contra );
                result = db.QueryFirstOrDefault<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public IEnumerable<tbUsuarios> ValidarUsuario(string Usuario)
        {
            string sql = ScriptsDatabase.UsuariosValidarUsuario;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parameters = new { @Usuario = Usuario };
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbUsuarios> ValidarClave(string Contra)
        {
            string sql = ScriptsDatabase.UsuariosValidarClave;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parameters = new { @Contra = Contra };
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbUsuarios> ValidarCorreoUsuario(string corus)
        {
            string sql = ScriptsDatabase.UsuariosValidar;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@UsuarioCorreo", corus);
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbUsuarios> IngresarCodigo(string codigo, int usua_id)
        {
            string sql = ScriptsDatabase.UsuariosIngresarCodigo;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Usua_Id", usua_id);
                parameters.Add("@Usua_CodigoV", codigo);
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public IEnumerable<tbUsuarios> ValidarCodigo(tbUsuarios item)
        {
            string sql = ScriptsDatabase.UsuariosValidarCodigo;

            List<tbUsuarios> result = new List<tbUsuarios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Usua_CodigoV", item.Usua_CodigoV);
                result = db.Query<tbUsuarios>(sql, parameters, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
    }
}
