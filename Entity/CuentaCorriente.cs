using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CuentaCorriente : ICuenta
    {
        public decimal Numero { get; set; }
        public Cliente Cliente { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }
        public decimal Cupo { get; set; }
        public List<Movimiento> Movimientos { get; set; }
        string ICuenta.Numero { get; set; }

        public CuentaCorriente()
        {
            Movimientos = new List<Movimiento>();
        }

        public CuentaCorriente(decimal numero, Cliente cliente, string tipo)
        {
            Numero = numero;
            Cliente = cliente;
            Tipo = tipo;
            Cupo = 100000;
            Movimientos = new List<Movimiento>();
        }

        public string Consignar(decimal valor)
        {
            if (valor <= Saldo)
            {
                Saldo -= valor;
                Cupo += valor;
                RegistroMoviento(valor, "Consignacion");
                return $"Se ha consignado correctamente su nuevo saldo es de:  {Saldo} y cupo es de : {Cupo}";
            }
            return $"Valor Fuera del cupo admitido";
        }

        public string Retirar(decimal valor)
        {
            if (valor <= Cupo)
            {
                Saldo += valor;
                Cupo -= valor;
                RegistroMoviento(valor, "Retiro");
                return $"Se ha retirado correctamente su nuevo saldo es de:  {Saldo} y cupo es de : {Cupo}";
            }
            return $"Valor Fuera del cupo admitido";            
        }

        private void RegistroMoviento(decimal valor, string tipo)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.Fecha = DateTime.Now;
            movimiento.Tipo = tipo;
            movimiento.Saldo = Saldo;
            movimiento.Valor = valor;
            Movimientos.Add(movimiento);
        }
    }
}
