using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CuentaAhorro : ICuenta
    {
        const decimal TOPE = 10000;
        public decimal Numero { get; set; }
        public Cliente Cliente { get ; set; }
        public string Tipo { get ; set ; }
        public decimal Saldo { get; set; }
        public List<Movimiento> Movimientos { get ; set ; }
        string ICuenta.Numero { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CuentaAhorro(decimal saldo)
        {
            Saldo = saldo;
            Movimientos = new List<Movimiento>();
        }

        public CuentaAhorro(decimal numero, Cliente cliente, string tipo, decimal saldo)
        {
            Numero = numero;
            Cliente = cliente;
            Tipo = tipo;
            Saldo = saldo;
            Movimientos = new List<Movimiento>();
        }


        public string Consignar(decimal valor)
        {
            if (valor>0)
            {
                Saldo += valor;
                RegistroMoviento(valor , "Consignacion");
                return $"Se Consigno {valor}";
            }

            return $"No se Acepto el valor negativo";            
        }

        private void RegistroMoviento(decimal valor , string tipo)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.Fecha = DateTime.Now;
            movimiento.Tipo = tipo;
            movimiento.Saldo = Saldo;
            movimiento.Valor = valor;
            Movimientos.Add(movimiento);
        }

        public string Retirar(decimal valor)
        {
            if ((Saldo - valor)>=TOPE)
            {
                Saldo -= valor;
                RegistroMoviento(valor, "Retiro");
                return $"Se retiro {valor} su nuevo saldo es {Saldo}";
            }
            return $"Saldo insuficiente no es posible retirar {valor}";
        }
    }
}
