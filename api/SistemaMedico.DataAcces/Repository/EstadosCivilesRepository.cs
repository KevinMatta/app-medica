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
    public class EstadosCivilesRepository : IRepository<tbEstadosCiviles>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEstadosCiviles> Find(int? id)
        {
            string sql = ScriptsDatabase.EntrenamientosBuscar;
            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@EsCi_Id ", id);
                result = db.Query<tbEstadosCiviles>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbEstadosCiviles item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEstadosCiviles> List()
        {

            string sql = ScriptsDatabase.EstadosCivilesListar;

            List<tbEstadosCiviles> result = new List<tbEstadosCiviles>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbEstadosCiviles>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEstadosCiviles item)
        {
            throw new NotImplementedException();
        }
    }
}
