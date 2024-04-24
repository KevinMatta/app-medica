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
    public class CiudadesRepository : IRepository<tbCiudades>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }
        public RequestStatus DeleteCiudad(string id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<tbCiudades> Find(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCiudades> Find1(string id)
        {
            string sql = ScriptsDatabase.CiudadesBuscar;
            List<tbCiudades> result = new List<tbCiudades>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Ciud_Id", id);
                result = db.Query<tbCiudades>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbCiudades item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbCiudades> List()
        {
            string sql = ScriptsDatabase.CiudadesListar;

            List<tbCiudades> result = new List<tbCiudades>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbCiudades>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbCiudades item)
        {
            throw new NotImplementedException();
        }
    }
}
