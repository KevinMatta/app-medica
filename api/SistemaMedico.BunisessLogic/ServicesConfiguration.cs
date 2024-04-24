using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using SistemaMedico.BunisessLogic.Services;
using SistemaMedico.DataAcces;
using SistemaMedico.DataAcces.Repository;
using SistemaMedico.Entities.Entities;

namespace SistemaMedico.BunisessLogic
{
    public static class ServicesConfiguration
    {
        public static void DataAccess(this IServiceCollection service, string conn)
        {
            service.AddScoped<AlimentosRepository>();
            service.AddScoped<CiudadesRepository>();
            service.AddScoped<DiagnosticoRepository>();
            service.AddScoped<DietaRepository>();
            service.AddScoped<EjercicioRepository>();
            service.AddScoped<EnfermedadesPorPersonaRepository>();
            service.AddScoped<EnfermedadesRepository>();
            service.AddScoped<EntrenamientosRepository>();
            service.AddScoped<EstadosCivilesRepository>();
            service.AddScoped<EstadosSaludRepository>();
            service.AddScoped<EstadosRepository>();
            service.AddScoped<PersonasRepository>();
            service.AddScoped<TipoSangreRepository>();
            service.AddScoped<PantallasPorRolesRepository>();
            service.AddScoped<PantallasRepository>();
            service.AddScoped<RolesRepository>();
            service.AddScoped<UsuariosRepository>();
            SistemaMedicoContext.BuildConnectionString(conn);

        }

        public static void BusinessLogic(this IServiceCollection service)
        {
            service.AddScoped<AccesoService>();
            service.AddScoped<GeneralService>();
            service.AddScoped<MedicaService>();
        }
    }
}
