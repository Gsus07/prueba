using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class CuentasAhorroRepository

    {
        List<CuentaAhorro> CuentasAhorro;
        public CuentasAhorroRepository()
        {
            CuentasAhorro = new List<CuentaAhorro>();
        }

        public void Agregar(CuentaAhorro cuentaAhorro)
        {
            CuentasAhorro.Add(cuentaAhorro);
        }

        public List<CuentaAhorro> Guardar()
        {
            return CuentasAhorro;
        }

        public List<CuentaAhorro> Consultar()
        {
            return CuentasAhorro;
        }

        public CuentaAhorro BuscarIndentificacion(decimal indentificacion)
        {
            foreach (var item in CuentasAhorro)
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
