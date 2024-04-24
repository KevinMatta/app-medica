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
    public class PantallasPorRolesRepository : IRepository<tbPantallasPorRoles>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPantallasPorRoles> Find(int? id)
        {
            string sql = ScriptsDatabase.PantallasPorRolesBuscar;
            List<tbPantallasPorRoles> result = new List<tbPantallasPorRoles>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Estd_Id ", id);
                result = db.Query<tbPantallasPorRoles>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbPantallasPorRoles item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbPantallasPorRoles> List()
        {
            string sql = ScriptsDatabase.PantallasPorRolesListar;

            List<tbPantallasPorRoles> result = new List<tbPantallasPorRoles>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbPantallasPorRoles>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbPantallasPorRoles item)
        {
            throw new NotImplementedException();
        }
    }
}
