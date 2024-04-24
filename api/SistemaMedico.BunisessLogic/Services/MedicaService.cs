using SistemaMedico.DataAcces.Repository;
using SistemaMedico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.BunisessLogic.Services
{
    public class MedicaService
    {
        private readonly AlimentosRepository _alimentosRepository;
        private readonly DiagnosticoRepository _diagnosticoRepository;
        private readonly DietaRepository _dietaRepository;
        private readonly EjercicioRepository _ejercicioRepository;
        private readonly EnfermedadesRepository _enfermedadesRepository;
        private readonly EnfermedadesPorPersonaRepository _enfermedadesPorPersonaRepository;
        private readonly EntrenamientosRepository _entrenamientosRepository;
        private readonly EstadosSaludRepository _estadosSaludRepository;
        private readonly TipoSangreRepository _tipoSangreRepository;

        public MedicaService(AlimentosRepository alimentosRepository, DiagnosticoRepository diagnosticoRepository, DietaRepository dietaRepository, EjercicioRepository ejercicioRepository, EnfermedadesRepository enfermedadesRepository, EnfermedadesPorPersonaRepository enfermedadesPorPersonaRepository, EntrenamientosRepository entrenamientosRepository, EstadosSaludRepository estadosSaludRepository, TipoSangreRepository tipoSangreRepository)
        {
            _alimentosRepository = alimentosRepository;
            _diagnosticoRepository = diagnosticoRepository;
            _dietaRepository = dietaRepository;
            _ejercicioRepository = ejercicioRepository;
            _enfermedadesRepository = enfermedadesRepository;
            _enfermedadesPorPersonaRepository = enfermedadesPorPersonaRepository;
            _entrenamientosRepository = entrenamientosRepository;
            _estadosSaludRepository = estadosSaludRepository;
            _tipoSangreRepository = tipoSangreRepository;
        }

        #region Alimentos
        public ServicesResult ListaAlimentos()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _alimentosRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbAlimentos> BuscarAlimentos(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _alimentosRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbAlimentos>();
            }
        }
        #endregion

        #region Diagnosticos
        public ServicesResult ListaDiagnosticos()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _diagnosticoRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public ServicesResult ListaDiagnosticosEntrenamientos(int id)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _diagnosticoRepository.Listado1(id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public ServicesResult ListaDiagnosticosDietas(int id)
        {
            var result = new ServicesResult();
            try
            {
                var lost = _diagnosticoRepository.ListadoDieta(id);

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }

        public IEnumerable<tbDiagnosticos> BuscarDiagnosticos(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _diagnosticoRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbDiagnosticos>();
            }
        }

        public IEnumerable<tbDiagnosticos> BuscarDiagnosticosPersonas(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _diagnosticoRepository.FindDiagnosticoPersona(Id);
            }
            catch
            {
                return Enumerable.Empty<tbDiagnosticos>();
            }
        }
        #endregion

        #region Dietas
        public ServicesResult ListaDietas()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _dietaRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbDietas> BuscarDietas(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _dietaRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbDietas>();
            }
        }

        #endregion

        #region Ejercicios
        public ServicesResult ListaEjercicios()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _ejercicioRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbEjercios> BuscarEjercicios(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _ejercicioRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbEjercios>();
            }
        }
        #endregion

        #region Enfermedades
        public ServicesResult ListaEnfermedades()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _enfermedadesRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbEnfermedades> BuscarEnfermedades(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _enfermedadesRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbEnfermedades>();
            }
        }
        #endregion

        #region Enfermedades Por Persona
        public ServicesResult ListaEnfermedadesPorPersona()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _enfermedadesPorPersonaRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbEnfermedadesPorPersona> BuscarEnfermedadesPorPersona(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _enfermedadesPorPersonaRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbEnfermedadesPorPersona>();
            }
        }
        #endregion

        #region Entrenamientos
        public ServicesResult ListaEntrenamientos()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _entrenamientosRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbEntrenamientos> BuscarEntrenamientos(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _entrenamientosRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbEntrenamientos>();
            }
        }
        #endregion

        #region Estados Salud
        public ServicesResult ListaEstadosSalud()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _estadosSaludRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbEstadosSalud> BuscarEstadosSalud(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _estadosSaludRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbEstadosSalud>();
            }
        }
        #endregion

        #region Tipos Sangre
        public ServicesResult ListaTiposSangre()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _tipoSangreRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbTiposSangre> BuscarTiposSangre(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _tipoSangreRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbTiposSangre>();
            }
        }
        #endregion
    }
}
