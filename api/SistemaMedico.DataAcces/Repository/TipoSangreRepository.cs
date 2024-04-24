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
    public class TipoSangreRepository : IRepository<tbTiposSangre>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbTiposSangre> Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbTiposSangre item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbTiposSangre> List()
        {
            string sql = ScriptsDatabase.TipoSangreListar;

            List<tbTiposSangre> result = new List<tbTiposSangre>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbTiposSangre>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbTiposSangre item)
        {
            throw new NotImplementedException();
        }
    }
}
