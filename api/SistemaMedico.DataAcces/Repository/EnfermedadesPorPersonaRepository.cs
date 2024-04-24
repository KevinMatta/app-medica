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
    public class EnfermedadesPorPersonaRepository : IRepository<tbEnfermedadesPorPersona>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEnfermedadesPorPersona> Find(int? id)
        {
            string sql = ScriptsDatabase.EnfermedadesPorPersonasBuscar;
            List<tbEnfermedadesPorPersona> result = new List<tbEnfermedadesPorPersona>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@EnPe_Id", id);
                result = db.Query<tbEnfermedadesPorPersona>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbEnfermedadesPorPersona item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEnfermedadesPorPersona> List()
        {
            string sql = ScriptsDatabase.EnfermedadesPorPersonasListar;

            List<tbEnfermedadesPorPersona> result = new List<tbEnfermedadesPorPersona>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbEnfermedadesPorPersona>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEnfermedadesPorPersona item)
        {
            throw new NotImplementedException();
        }
    }
}
