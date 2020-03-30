using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
    public class CuentasService
    {
        CuentasAhorroRepository cuentasAhorroRepository;
        CuentasCorrienteRepository cuentasCorrienteRepository;
        CuentaRepository cuentas;

        public CuentasService()
        {
            cuentasAhorroRepository = new CuentasAhorroRepository();
            cuentasCorrienteRepository = new CuentasCorrienteRepository();
            cuentas = new CuentaRepository();
        }

        public string Guardar(ICuenta cuenta)
        {
            if (cuentas.Guardar(cuenta))
                return "Se guardo la información";
            else
                return "Cuenta ya registrada";
        }

        public ICuenta Buscar(string numero)
        {
            return cuentas.Buscar(numero);
        }

        public string GuardarCorriente(CuentaCorriente cuentaCorriente)
        {

            if (cuentasCorrienteRepository.BuscarIndentificacion(cuentaCorriente.Numero)== null)
            {
                cuentasCorrienteRepository.Agregar(cuentaCorriente);
                return "Se guardo La Informacion Satisfactoriamente";
            }
            else
            {
                return "No se Guardo Porque La Identificacion Ya Existe";
            }
        }

        public string GuardarAhorro(CuentaAhorro cuentaAhorro)
        {

            if (cuentasAhorroRepository.BuscarIndentificacion(cuentaAhorro.Numero) == null)
            {
                cuentasAhorroRepository.Agregar(cuentaAhorro);
                return "Se guardo La Informacion Satisfactoriamente";
            }
            else
            {
                return "No se Guardo Porque La Identificacion Ya Existe";
            }
        }


        public List<CuentaCorriente> consultarCuentasCorriente()
        {
            return cuentasCorrienteRepository.Consultar();
        }

        public List<CuentaAhorro> consultarCuentasAhorro()
        {
            return cuentasAhorroRepository.Consultar();
        }

        public CuentaCorriente consultarCuentaCorriente(decimal numero)
        {
            return cuentasCorrienteRepository.BuscarIndentificacion(numero);
        }

        public CuentaAhorro consultarCuentaAhorro(decimal numero)
        {
            return cuentasAhorroRepository.BuscarIndentificacion(numero);
        }

    }
}
