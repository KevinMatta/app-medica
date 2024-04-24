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
    public class PantallasRepository : IRepository<tbPantallas>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPantallas> Find(int? id)
        {
            string sql = ScriptsDatabase.PantallasBuscar;
            List<tbPantallas> result = new List<tbPantallas>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Estd_Id ", id);
                result = db.Query<tbPantallas>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbPantallas item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPantallas> List()
        {
            string sql = ScriptsDatabase.PantallasListar;

            List<tbPantallas> result = new List<tbPantallas>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbPantallas>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbPantallas item)
        {
            throw new NotImplementedException();
        }
    }
}
