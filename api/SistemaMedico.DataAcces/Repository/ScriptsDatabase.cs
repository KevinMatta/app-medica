using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.DataAcces.Repository
{
    public class ScriptsDatabase
    {
        #region Pantallas 
        public static string PantallasListar = "Acce.sp_Pantallas_Listar";
        public static string PantallasBuscar = "Acce.sp_Pantallas_Buscar";
        #endregion

        #region PantallasPorRoles
        public static string PantallasPorRolesListar = "";
        public static string PantallasPorRolesCrear = "";
        public static string PantallasPorRolesActualizar = "";
        public static string PantallasPorRolesEliminar = "";
        public static string PantallasPorRolesBuscar = "";
        #endregion

        #region Roles
        public static string RolesCrear = "";
        public static string RolesActualizar = "";
        public static string RolesEliminar = "";
        public static string RolesListar = "Acce.sp_Roles_Listar";
        public static string RolesBuscar = "Acce.sp_Roles_Buscar";
        #endregion

        #region Usuarios
        public static string UsuariosListar = "Acce.sp_Usuarios_Listar";
        public static string UsuariosCrear = "Acce.SP_Usuarios_Crear";
        public static string UsuariosActualizar = "Acce.sp_UsuarioActualizar";
        public static string UsuariosEliminar = "Acce.sp_UsuarioEliminar";
        public static string UsuariosBuscar = "Acce.Usuario_Buscar";
        public static string UsuariosLogin = "[Acce].[sp_Usuarios_iniciosesion]";
        public static string UsuariosRestablecerClave = "[Acce].[sp_Usuarios_RestablecerClave]";
        public static string UsuariosValidarClave = "[Acce].[sp_Usuarios_validarclave]";
        public static string UsuariosValidarUsuario = "[Acce].[sp_Usuarios_validarusuario]";
        public static string UsuariosValidar = "Acce.sp_Usuarios_Validar";
        public static string UsuariosIngresarCodigo = "Acce.sp_Usuarios_IngresarCodigo";
        public static string UsuariosValidarCodigo = "Acce.sp_Usuarios_ValidarCodigo ";
        #endregion

        #region Ciudades 
        public static string CiudadesListar = "Gene.sp_Ciudades_Listar";
        public static string CiudadesCrear = "";
        public static string CiudadesActualizar = "";
        public static string CiudadesEliminar = "";
        public static string CiudadesBuscar = "Gene.sp_Ciudad_Buscar";
        #endregion

        #region Estados
        public static string EstadosListar = "Gene.sp_Estados_Listar";
        public static string EstadosCrear = "";
        public static string EstadosActualizar = "";
        public static string EstadosEliminar = "";
        public static string EstadosBuscar = "Gene.sp_Estados_Buscar";
        #endregion

        #region EstadosCiviles
        public static string EstadosCivilesListar = "Gene.sp_EstadosCiviles_Listar";
        public static string EstadosCivilesCrear = "";
        public static string EstadosCivilesActualizar = "";
        public static string EstadosCivilesEliminar = "";
        public static string EstadosCivilesBuscar = "Gene.sp_EstadosCiviles_Buscar";
        #endregion

        #region Personas
        public static string PersonasListar = "Gene.sp_Personas_Listar";
        public static string PersonasCrear = "";
        public static string PersonasActualizar = "";
        public static string PersonasEliminar = "";
        public static string PersonasBuscar = "Gene.sp_Personas_Buscar";
        #endregion

        #region Alimentos
        public static string AlimentoListar = "Medi.sp_Alimentos_Listar";
        public static string AlimentosCrear = "";
        public static string AlimentosActualizar = "";
        public static string AlimentosEliminar = "";
        public static string AlimentosBucar = "Medi.sp_Alimentos_Buscar";
        #endregion

        #region Diagnostico
        public static string DiagnosticoListar = "Medi.sp_Diagnosticos_Listar";
        public static string DiagnosticoCrear = "";
        public static string DiagnosticoActualizar = "";
        public static string DiagnosticoEliminar = "";
        public static string DiagnosticoBuscar = "Medi.sp_Diagnostico_Buscar";
        public static string DiagnosticoDietasListar = "[Medi].[sp_DiagnosticoDietas_listar]";
        public static string DiagnosticoDiagnosticosEntrenamientos = "Medi.sp_DiagnosticoEntrenamientos_listar";
        public static string DiagnosticoPersonaBuscar = "[Medi].[sp_DiagnosticoPersona_buscar]";
        #endregion

        #region Dietas
        public static string DietasListar = "Medi.sp_Dietas_Listar";
        public static string DietasCrear = "";
        public static string DietasActualizar = "";
        public static string DietasEliminar = "";
        public static string DietasBuscar = "Medi.sp_Dietas_Buscar";
        #endregion

        #region Ejercicios
        public static string EjerciciosListar = "Medi.sp_Ejercicios_Listar";
        public static string EjerciciosCrear = "";
        public static string EjerciciosActualizar = "";
        public static string EjerciciosEliminar = "";
        public static string EjerciciosBuscar = "Medi.sp_Ejercicios_Buscar";
        #endregion

        #region Enfermedades
        public static string EnfermedadesCrear = "[Medi].[sp_Enfermedades_crear]";
        public static string EnfermedadesActualizar = "[Medi].[sp_Enfermedades_editar]";
        public static string EnfermedadesListar = "[Gene].[sp_Enfermedades_listar]";
        public static string EnfermedadesEliminar = "[Medi].[sp_Enfermedades_eliminar]";
        public static string EnfermedadesBuscar = "[Gene].[sp_Enfermedades_buscar]";
        #endregion

        #region EnfermedadesPorPersona
        public static string EnfermedadesPorPersonasListar = "Medi.sp_EnfermedadesPorPersona_Listar";
        public static string EnfermedadesPorPersonasCrear = "";
        public static string EnfermedadesPorPersonasActualizar = "";
        public static string EnfermedadesPorPersonasEliminar = "";
        public static string EnfermedadesPorPersonasBuscar = "Medi.sp_EnfermedadesPorPersona_Buscar";
        #endregion

        #region Entrenamientos
        public static string EntrenamientosListar = "Medi.sp_Entrenamientos_Listar";
        public static string EntrenamientosCrear = "";
        public static string EntrenamientosActualizar = "";
        public static string EntrenamientosEliminar = "";
        public static string EntrenamientosBuscar = "Medi.sp_Entrenamientos_Buscar";
        #endregion

        #region EstadosSalud
        public static string EstadosSaludListar = "Medi.sp_EstadosSalud_Listar";
        public static string EstadosSaludCrear = "";
        public static string EstadosSaludAtualizar = "";
        public static string EstadosSaludEliminar = "";
        public static string EstadosSaludBuscar = "Medi.sp_EstadosSalud_Buscar";
        #endregion

        #region TiposSangre
        public static string TipoSangreListar = "Medi.sp_TipoSangre_Listar";
        public static string TipoSangreCrear = "";
        public static string TipoSangreActualizar = "";
        public static string TipoSangreEliminar = "";
        public static string TipoSangreBuscar = "Medi.sp_TipoSangre_Buscar";
        #endregion
    }
}
