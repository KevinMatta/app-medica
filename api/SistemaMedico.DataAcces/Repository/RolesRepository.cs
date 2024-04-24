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
    public class RolesRepository : IRepository<tbRoles>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbRoles> Find(int? id)
        {
            string sql = ScriptsDatabase.RolesBuscar;
            List<tbRoles> result = new List<tbRoles>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Estd_Id ", id);
                result = db.Query<tbRoles>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbRoles item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbRoles> List()
        {
            string sql = ScriptsDatabase.RolesListar;

            List<tbRoles> result = new List<tbRoles>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbRoles>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbRoles item)
        {
            throw new NotImplementedException();
        }
    }
}
