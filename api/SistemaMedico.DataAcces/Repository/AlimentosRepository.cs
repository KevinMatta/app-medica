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
    public class AlimentosRepository : IRepository<tbAlimentos>
    {
        public RequestStatus Delete(int? id)
        {
            string sql = ScriptsDatabase.AlimentosEliminar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Alim", id);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public IEnumerable<tbAlimentos> Find(int? id)
        {
            string sql = ScriptsDatabase.AlimentosBucar;
            List<tbAlimentos> result = new List<tbAlimentos>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("Carg_Id", id);
                result = db.Query<tbAlimentos>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbAlimentos item)
        {
            string sql = ScriptsDatabase.AlimentosCrear;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Descripcion", item.Alim_Descripcion);
                parametro.Add("@Carg_Descripcion", item.Alim_TipoComida);
                parametro.Add("@Carg_Descripcion", item.Alim_Calorias);
                parametro.Add("@Carg_Descripcion", item.Alim_Proteinas);
                parametro.Add("@Carg_Descripcion", item.Alim_Carbohidratos);
                parametro.Add("@Carg_UsuarioCreacion", item.Alim_Creacion);
                parametro.Add("@Carg_FechaCreacion", item.Alim_FechaCreacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };

            }
        }

        public IEnumerable<tbAlimentos> List()
        {
            string sql = ScriptsDatabase.AlimentoListar;

            List<tbAlimentos> result = new List<tbAlimentos>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbAlimentos>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbAlimentos item)
        {
            string sql = ScriptsDatabase.AlimentosActualizar;

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Carg_Descripcion", item.Alim_Id);
                parametro.Add("@Carg_Descripcion", item.Alim_Descripcion);
                parametro.Add("@Carg_Descripcion", item.Alim_TipoComida);
                parametro.Add("@Carg_Descripcion", item.Alim_Calorias);
                parametro.Add("@Carg_Descripcion", item.Alim_Proteinas);
                parametro.Add("@Carg_Descripcion", item.Alim_Carbohidratos);
                parametro.Add("@Carg_UsuarioCreacion", item.Alim_Modificacion);
                parametro.Add("@Carg_FechaCreacion", item.Alim_FechaModificacion);
                var result = db.Execute(sql, parametro, commandType: CommandType.StoredProcedure);

                return new RequestStatus { CodeStatus = result, MessageStatus = "" };
            }
        }
    }
}
