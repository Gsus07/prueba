using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public interface ICuenta
    {
        string Numero {get; set;}
        Cliente Cliente { get; set; }
        string Tipo { get; set; }
        decimal Saldo { get; set; }

        List<Movimiento> Movimientos { get; set; }


        string Consignar(decimal valor);
        string Retirar(decimal valor);
    }
}
