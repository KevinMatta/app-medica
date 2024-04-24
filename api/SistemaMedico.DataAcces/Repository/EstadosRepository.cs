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
    public class EstadosRepository : IRepository<tbEstados>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEstados> Find(int? id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<tbEstados> Find1(string id)
        {
            string sql = ScriptsDatabase.EstadosSaludBuscar;
            List<tbEstados> result = new List<tbEstados>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Estd_Id ", id);
                result = db.Query<tbEstados>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbEstados item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEstados> List()
        {
            string sql = ScriptsDatabase.EstadosListar;

            List<tbEstados> result = new List<tbEstados>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbEstados>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEstados item)
        {
            throw new NotImplementedException();
        }
    }
}
