using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SistemaMedico.DataAcces.Context;

namespace SistemaMedico.DataAcces
{
    public partial class SistemaMedicoContext : DbmedicoContext 
    {
        public static string ConnectionString { get; set; }

        public SistemaMedicoContext()
        {
            ChangeTracker.LazyLoadingEnabled = false;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        public static void BuildConnectionString(string connection)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder { ConnectionString = connection };
            ConnectionString = connectionStringBuilder.ConnectionString;
        }
    }
}
