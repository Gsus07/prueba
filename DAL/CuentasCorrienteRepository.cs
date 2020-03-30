using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace DAL
{
    public class CuentasCorrienteRepository
    {
        List<CuentaCorriente> CuentasCorriente;
        public  CuentasCorrienteRepository()
        {
            CuentasCorriente = new List<CuentaCorriente>();
        }
        public void Agregar(CuentaCorriente cuentaCorriente)
        {
            CuentasCorriente.Add(cuentaCorriente);
        }
        public List<CuentaCorriente> Consultar()
        {
            return CuentasCorriente;
        }
        public CuentaCorriente BuscarIndentificacion(decimal indentificacion)
        {
            foreach (var item in CuentasCorriente)
            {
                if (item.Numero == indentificacion)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
