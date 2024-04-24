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
    public class EjercicioRepository : IRepository<tbEjercios>
    {
        public RequestStatus Delete(int? id)
        {
            string sql = ScriptsDatabase.EjerciciosEliminar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Ejer_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public IEnumerable<tbEjercios> Find(int? id)
        {
            string sql = ScriptsDatabase.EjerciciosBuscar;
            List<tbEjercios> result = new List<tbEjercios>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Ejer_Id", id);
                result = db.Query<tbEjercios>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbEjercios item)
        {
            string sql = ScriptsDatabase.EjerciciosCrear;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Descripcion", item.Ejer_Descripcion);
                parametro.Add("@Carg_Descripcion", item.Ejer_TipoEjercicio);
                parametro.Add("@Carg_UsuarioCreacion", item.Ejer_Creacion);
                parametro.Add("@Carg_FechaCreacion", item.Ejer_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }

        public IEnumerable<tbEjercios> List()
        {
            string sql = ScriptsDatabase.EjerciciosListar;

            List<tbEjercios> result = new List<tbEjercios>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbEjercios>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEjercios item)
        {
            string sql = ScriptsDatabase.EjerciciosActualizar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Id", item.Ejer_Id);
                parametro.Add("@Carg_Descripcion", item.Ejer_Descripcion);
                parametro.Add("@Carg_Descripcion", item.Ejer_TipoEjercicio);
                parametro.Add("@Carg_UsuarioCreacion", item.Ejer_Creacion);
                parametro.Add("@Carg_FechaCreacion", item.Ejer_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
    }
}
