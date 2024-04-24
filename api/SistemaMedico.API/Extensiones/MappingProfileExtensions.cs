using AutoMapper;
using SistemaMedico.Common.Models;
using SistemaMedico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMedico.Extensiones
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<UsuariosViewModel, tbUsuarios>().ReverseMap();
            CreateMap<AlimentosViewModel, tbAlimentos>().ReverseMap();
            CreateMap<CiudadesViewModel, tbCiudades>().ReverseMap();
            CreateMap<DiagnosticoViewModel, tbDiagnosticos>().ReverseMap();
            CreateMap<DietaViewModel, tbDietas>().ReverseMap();
            CreateMap<EjercicioViewModel, tbEjercios>().ReverseMap();
            CreateMap<EnfermedadesViewModel, tbEnfermedades>().ReverseMap();
            CreateMap<EntrenamientosViewModel, tbEntrenamientos>().ReverseMap();
            CreateMap<EnfermedadesPorPersonaViewModel, tbEnfermedades>().ReverseMap();
            CreateMap<EstadosCivilesViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<EstadosSaludViewModel, tbEstadosSalud>().ReverseMap();
            CreateMap<EstadosViewModel, tbEstados>().ReverseMap();
            CreateMap<PantallasPorRolesViewModel, tbPantallasPorRoles>().ReverseMap();
            CreateMap<PantallasViewModel, tbPantallas>().ReverseMap();
            CreateMap<RolesViewModel, tbRoles>().ReverseMap();
            CreateMap<TipoSangreViewModel, tbTiposSangre>().ReverseMap();
            
        }
    }
}
