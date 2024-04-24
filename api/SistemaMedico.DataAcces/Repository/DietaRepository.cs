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
    public class DietaRepository : IRepository<tbDietas>
    {
        public RequestStatus Delete(int? id)
        {
            string sql = ScriptsDatabase.DietasEliminar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Diet_Id", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public IEnumerable<tbDietas> Find(int? id)
        {
            string sql = ScriptsDatabase.DietasBuscar;
            List<tbDietas> result = new List<tbDietas>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Diet_Id", id);
                result = db.Query<tbDietas>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbDietas item)
        {
            string sql = ScriptsDatabase.DietasCrear;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Descripcion", item.Diag_Id);
                parametro.Add("@Carg_Descripcion", item.Alim_Id);
                parametro.Add("@Carg_Descripcion", item.Diet_Detalle);
                parametro.Add("@Carg_UsuarioCreacion", item.Diet_Creacion);
                parametro.Add("@Carg_FechaCreacion", item.Diet_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public IEnumerable<tbDietas> List()
        {
            string sql = ScriptsDatabase.DietasListar;

            List<tbDietas> result = new List<tbDietas>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbDietas>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbDietas item)
        {
            string sql = ScriptsDatabase.DietasActualizar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Id", item.Diet_Id);
                parametro.Add("@Carg_Descripcion", item.Diag_Id);
                parametro.Add("@Carg_Descripcion", item.Alim_Id);
                parametro.Add("@Carg_Descripcion", item.Diet_Detalle);
                parametro.Add("@Carg_UsuarioCreacion", item.Diet_Creacion);
                parametro.Add("@Carg_FechaCreacion", item.Diet_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
    }
}
