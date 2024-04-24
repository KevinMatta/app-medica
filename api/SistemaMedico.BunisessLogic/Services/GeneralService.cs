using SistemaMedico.DataAcces.Repository;
using SistemaMedico.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMedico.BunisessLogic.Services
{
    public class GeneralService
    {

        private readonly CiudadesRepository _ciudadesRepository;
        private readonly EstadosRepository _estadosRepository;
        private readonly EstadosCivilesRepository _estadosCivilesRepository;
        private readonly PersonasRepository _personasRepository;
        public GeneralService(CiudadesRepository ciudadesRepository, EstadosRepository estadosRepository, EstadosCivilesRepository estadosCivilesRepository, PersonasRepository personasRepository)
        {
            _ciudadesRepository = ciudadesRepository;
            _estadosRepository = estadosRepository;
            _estadosCivilesRepository = estadosCivilesRepository;
            _personasRepository = personasRepository;
        }

        #region Ciudades
        public ServicesResult ListaCiudades()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _ciudadesRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbCiudades> BuscarCiudades(string Id)
        {
            var result = new ServicesResult();
            try
            {
                return _ciudadesRepository.Find1(Id);
            }
            catch
            {
                return Enumerable.Empty<tbCiudades>();
            }
        }
        #endregion

        #region Estados

        public ServicesResult ListaEstados()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _estadosRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbEstados> BuscarEstados(string Id)
        {
            var result = new ServicesResult();
            try
            {
                return _estadosRepository.Find1(Id);
            }
            catch
            {
                return Enumerable.Empty<tbEstados>();
            }
        }
        #endregion

        #region Estados Civiles
        public ServicesResult ListaEstadosCiviles()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _estadosCivilesRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbEstadosCiviles> BuscarEstadosCiviles(int Id)
        {
            var result = new ServicesResult();
            try
            {
                return _estadosCivilesRepository.Find(Id);
            }
            catch
            {
                return Enumerable.Empty<tbEstadosCiviles>();
            }
        }
        #endregion

        #region Personas
        public ServicesResult ListaPersonas()
        {
            var result = new ServicesResult();
            try
            {
                var lost = _personasRepository.List();

                return result.Ok(lost);

            }
            catch (Exception ex)
            {
                return result.Error(ex.Message);

            }
        }
        public IEnumerable<tbPersonas> BuscarPersonas(string Id)
        {
            var result = new ServicesResult();
            try
            {
                return _personasRepository.Find1(Id);
            }
            catch
            {
                return Enumerable.Empty<tbPersonas>();
            }
        }
        #endregion
    }
}

