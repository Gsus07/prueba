using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
namespace UIBanco
{
    class FrmPrincipal
    {
        static void Main(string[] args)
        {
            string mensaje;
            decimal valor, numero;
            
            int opcionMenu, segundaOpcionMenu, OpcionmenuModificar;
            char salirPrograma = 'S';
            CuentasService cuentasService = new CuentasService();
            while (salirPrograma == 'S')
            {
                Console.Clear();
                Console.WriteLine($"----PROGRAMA DE BANCO----");
                Console.WriteLine($"Menu de ociones:");
                Console.WriteLine($"1.Agregar cuenta");
                Console.WriteLine($"2.Ver listado de las cuentas");
                Console.WriteLine($"3.Ver movimientos de la cuenta");
                Console.WriteLine($"4.Hacer movimientos en la cuenta");
                Console.WriteLine($"5.Modificar dato de la cuenta");
                Console.WriteLine($"6.Eliminar cuenta");
                Console.WriteLine($"7.Buscar cuenta");
                Console.WriteLine($"8.SALIR ");
                Console.WriteLine("Por favor digite una opcione: ");
                opcionMenu = Int16.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine($"---AGREGAR UNA CUENTA---");

                        switch (MenuCuentas())
                        {
                            case 1: cuentasService.Guardar(RegistroCuentaCorriente()); break;
                            case 2: cuentasService.Guardar(RegistroCuentaAhorro()); break;
                            default:break;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine($"---LISTADOS DE CUENTAS---");
                        Console.WriteLine($"1.CORRIENTE ");
                        foreach (var item in cuentasService.consultarCuentasCorriente())
                        {
                            Console.WriteLine($"Numero: {item.Numero}");
                            Console.WriteLine($"Iidentificacion del cliente: {item.Cliente.Indentificacion}");
                            Console.WriteLine($"Nombre del cliente: {item.Cliente.Nombre}");
                            Console.WriteLine($"Tipo: {item.Tipo} ");
                            Console.WriteLine($"Saldo: {item.Saldo}");
                            Console.WriteLine($"Cupo: {item.Cupo}");
                        }
                        Console.WriteLine($"2.AHORRO ");
                        foreach (var item in cuentasService.consultarCuentasAhorro())
                        {
                            Console.WriteLine($"Numero: {item.Numero}");
                            Console.WriteLine($"Iidentificacion del cliente: {item.Cliente.Indentificacion}");
                            Console.WriteLine($"Nombre del cliente: {item.Cliente.Nombre}");
                            Console.WriteLine($"Saldo: {item.Saldo}");
                            Console.WriteLine($"Tipo: {item.Tipo} ");                            
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine($"---MOVIMIENTO DE CUENTA---");
                        /*foreach ()
                        {

                        }*/
                            break;
                    case 4:
                        Console.Clear();

                        switch (MenuCuentas())
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine($"Digite numero de la cuenta:");
                                numero = Int16.Parse(Console.ReadLine());
                                if(cuentasService.consultarCuentaCorriente(numero) != null)
                                {
                                    Console.Clear();
                                    segundaOpcionMenu = MenuMovimientoCuenta();
                                    Console.Clear();
                                    Console.WriteLine($"Por favor digite un valor a Cconsignar/Retirar:");
                                    valor = Int16.Parse(Console.ReadLine());

                                    if (segundaOpcionMenu == 2)
                                    {
                                        mensaje = cuentasService.consultarCuentaCorriente(numero).Consignar(valor);
                                        Console.WriteLine(mensaje);
                                    }
                                    else
                                    {
                                        if (segundaOpcionMenu == 1)
                                        {
                                            mensaje = cuentasService.consultarCuentaCorriente(numero).Retirar(valor);
                                            Console.WriteLine(mensaje);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("No se ha encontrado la cuenta");
                                }
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                
                                Console.WriteLine($"Por favor digite numero de la cuenta:");
                                numero = Int16.Parse(Console.ReadLine());
                                if (cuentasService.consultarCuentaAhorro(numero)!=null)
                                {
                                    Console.Clear();
                                    segundaOpcionMenu = MenuMovimientoCuenta();
                                    Console.Clear();
                                    Console.WriteLine($"Por favor digite un valor a Cconsignar/Retira");
                                    valor = decimal.Parse(Console.ReadLine());

                                    if (segundaOpcionMenu == 2)
                                    {
                                        mensaje = cuentasService.consultarCuentaAhorro(numero).Consignar(valor);
                                        Console.WriteLine(mensaje);
                                    }
                                    else
                                    {
                                        if (segundaOpcionMenu == 1)
                                        {
                                            mensaje = cuentasService.consultarCuentaAhorro(numero).Retirar(valor);
                                            Console.WriteLine(mensaje);
                                        }
                                    }
                                }                                
                                break;
                            default:
                                break;
                        }
                        break;
                    case 5: break;
                    case 6:
                        Console.WriteLine($"---ELIMINAR DE CUENTA---");
                        Console.WriteLine($"Digite identificacion:");

                        break;
                    case 7:
                        ICuenta cuenta = cuentasService.Buscar("12312");
                        Console.WriteLine(cuenta);
                        break;
                    case 8: salirPrograma = 'N'; break;
                    default: break;
                }
            }  
        }

        public static decimal MenuCuentas()
        {
            decimal opcionMenu;
            Console.WriteLine($"---TIPO DE CUENTA---");
            Console.WriteLine($"1.Corriente");
            Console.WriteLine($"2.Ahorros");

            Console.WriteLine("Por favor digite la opcion deseada: ");
            opcionMenu = Int16.Parse(Console.ReadLine());
            return opcionMenu;
        }

        
        public static CuentaCorriente RegistroCuentaCorriente()
        {
            decimal numero, indentificacionCliente;
            string tipo, nombreCliente;
            Console.Clear();
            Console.WriteLine($"Por favor digite el numero de la cuenta:");
            numero = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"Por favor digite el numero de identificacion personal del cliente:");
            indentificacionCliente = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"Nombre del cliente:");
            nombreCliente = Console.ReadLine();
            Console.WriteLine($"Digite su tipo de cuenta:");
            tipo = Console.ReadLine();     
            
            Cliente cliente = new Cliente(indentificacionCliente, nombreCliente);
            CuentaCorriente cuentaCorriente = new CuentaCorriente(numero, cliente, tipo);

            return cuentaCorriente;
        }

        public static int MenuMovimientoCuenta()
        {
            int opcionMenu;
            Console.WriteLine($"1.Retirar");
            Console.WriteLine($"2.Consignar");
            Console.WriteLine("Digite una de las opciones: ");
            opcionMenu = Int16.Parse(Console.ReadLine());
            return opcionMenu;
        }

        public static CuentaAhorro RegistroCuentaAhorro()
        {
            decimal numero, saldo,indentificacionCliente;
            string tipo, nombreCliente;
            Console.Clear();
            Console.WriteLine($"Por favor digite el numero de la cuenta:");
            numero = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"Por favor digite el numero de identificacion personal del cliente:");
            indentificacionCliente = Int16.Parse(Console.ReadLine());
            Console.WriteLine($"Digite nombre del cliente:");
            nombreCliente = Console.ReadLine();
            Console.WriteLine($"Nombre del cliente:");
            tipo = Console.ReadLine();
            Console.WriteLine($"Digite el saldo:");
            saldo = Int16.Parse(Console.ReadLine());

            Cliente cliente = new Cliente(indentificacionCliente, nombreCliente);
            CuentaAhorro cuentaAhorro = new CuentaAhorro(numero, cliente, tipo,saldo);
            return cuentaAhorro;
        }




    }
}
