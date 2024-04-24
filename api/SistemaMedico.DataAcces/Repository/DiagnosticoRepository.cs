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
    public class DiagnosticoRepository : IRepository<tbDiagnosticos>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbDiagnosticos> Find(int? id)
        {
            string sql = ScriptsDatabase.DiagnosticoBuscar;
            List<tbDiagnosticos> result = new List<tbDiagnosticos>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Diag_Id", id);
                result = db.Query<tbDiagnosticos>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public IEnumerable<tbDiagnosticos> FindDiagnosticoPersona(int? id)
        {
            string sql = ScriptsDatabase.DiagnosticoPersonaBuscar;
            List<tbDiagnosticos> result = new List<tbDiagnosticos>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Usua_Id", id);
                result = db.Query<tbDiagnosticos>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbDiagnosticos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbDiagnosticos> List()
        {
            string sql = ScriptsDatabase.DiagnosticoListar;

            List<tbDiagnosticos> result = new List<tbDiagnosticos>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbDiagnosticos>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public IEnumerable<tbDiagnosticos> Listado1(int id)
        {
            string sql = ScriptsDatabase.DiagnosticoDiagnosticosEntrenamientos;

            List<tbDiagnosticos> result = new List<tbDiagnosticos>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Diag_Id", id);
                result = db.Query<tbDiagnosticos>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public IEnumerable<tbDiagnosticos> ListadoDieta(int id)
        {
            string sql = ScriptsDatabase.DiagnosticoDietasListar;

            List<tbDiagnosticos> result = new List<tbDiagnosticos>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Diag_Id", id);
                result = db.Query<tbDiagnosticos>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbDiagnosticos item)
        {
            throw new NotImplementedException();
        }
    }
}
