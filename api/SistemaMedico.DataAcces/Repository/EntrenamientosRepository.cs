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
    public class EntrenamientosRepository : IRepository<tbEntrenamientos>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEntrenamientos> Find(int? id)
        {
            string sql = ScriptsDatabase.EntrenamientosBuscar;
            List<tbEntrenamientos> result = new List<tbEntrenamientos>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Enfe_Identidad", id);
                result = db.Query<tbEntrenamientos>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbEntrenamientos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEntrenamientos> List()
        {
            string sql = ScriptsDatabase.EntrenamientosListar;

            List<tbEntrenamientos> result = new List<tbEntrenamientos>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbEntrenamientos>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEntrenamientos item)
        {
            throw new NotImplementedException();
        }
    }
}
