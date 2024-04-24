﻿using Dapper;
using Microsoft.Data.SqlClient;
using SistemaMedico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.DataAcces.Repository
{
    public class EnfermedadesRepository : IRepository<tbEnfermedades>
    {
        public RequestStatus Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEnfermedades> Find(int? id)
        {
            string sql = ScriptsDatabase.EnfermedadesBuscar;
            List<tbEnfermedades> result = new List<tbEnfermedades>();
            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                var parametro = new DynamicParameters();
                parametro.Add("@Enfe_Id", id);
                result = db.Query<tbEnfermedades>(sql, parametro, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Insert(tbEnfermedades item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEnfermedades> List()
        {
            string sql = ScriptsDatabase.EntrenamientosListar;

            List<tbEnfermedades> result = new List<tbEnfermedades>();

            using (var db = new SqlConnection(SistemaMedicoContext.ConnectionString))
            {
                result = db.Query<tbEnfermedades>(sql, commandType: System.Data.CommandType.Text).ToList();

                return result;
            }
        }

        public RequestStatus Update(tbEnfermedades item)
        {
            throw new NotImplementedException();
        }
    }
}