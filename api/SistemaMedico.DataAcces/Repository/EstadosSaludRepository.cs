using Dapper;
using Microsoft.Data.SqlClient;
using SistemaMedico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.DataAcces.Repository
{
    public class EstadosSaludRepository : IRepository<tbEstadosSalud>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEstadosSalud> Find(int? id)
        {
            string sql = ScriptsDatabase.EntrenamientosBuscar;
            List<tbEstadosSalud> result = new List<tbEstadosSalud>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Estd_Id ", id);
                result = db.Query<tbEstadosSalud>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbEstadosSalud item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEstadosSalud> List()
        {
            string sql = ScriptsDatabase.EstadosSaludListar;

            List<tbEstadosSalud> result = new List<tbEstadosSalud>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbEstadosSalud>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEstadosSalud item)
        {
            throw new NotImplementedException();
        }
    }
}
