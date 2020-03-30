using System;
using System.Collections.Generic;
using Entity;

namespace DAL
{
    public class CuentaRepository
    {
        private List<ICuenta> cuentas;

        public CuentaRepository()
        {
            cuentas = new List<ICuenta>();
        }

        public bool Guardar(ICuenta cuenta)
        {
            if (cuentas.Contains(cuenta))
                return false;
            cuentas.Add(cuenta);
            return true;
        }

        public ICuenta Buscar(string numero)
        {
            return cuentas.Find((ICuenta cuenta) => { return cuenta.Numero == numero; });
        }
    }
}
