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
    public class PersonasRepository : IRepository<tbPersonas>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPersonas> Find(int? id)
        {
            string sql = ScriptsDatabase.PersonasBuscar;
            List<tbPersonas> result = new List<tbPersonas>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Estd_Id ", id);
                result = db.Query<tbPersonas>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public IEnumerable<tbPersonas> Find1(string? id)
        {
            string sql = ScriptsDatabase.PersonasBuscar;
            List<tbPersonas> result = new List<tbPersonas>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Estd_Id ", id);
                result = db.Query<tbPersonas>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public RequestStatus Insert(tbPersonas item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPersonas> List()
        {
            string sql = ScriptsDatabase.PersonasListar;

            List<tbPersonas> result = new List<tbPersonas>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbPersonas>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbPersonas item)
        {
            throw new NotImplementedException();
        }
    }
}
