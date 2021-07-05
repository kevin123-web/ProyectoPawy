using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    public class Menu
    {
        public int opc;
        private Establecimiento lis_establacimientos = new Establecimiento();

        public void Mostrar()
        {
            do
            {
                Console.Clear();
                Console.WriteLine
                ("********************************************************************************************");
                Console.WriteLine("\n\t\t\t\tFecha " + DateTime.Now);
                Console.WriteLine("\n\t\t\t\tREGISTRO DE ESTABLECIMEINTO \n\t\t\t\t** AFECTADO POR LA PANDEMIA**");
                Console.WriteLine("\n\t1. Eliga una de las siguientes opciones ");
                Console.WriteLine("\n\t2. Consulte nombre del estableciemiento ");
                Console.WriteLine("\n\t3. Buscar ");
                Console.WriteLine("\n\t4. Modificar ");
                Console.WriteLine("\n\t1. Salir ");
                Console.WriteLine
                ("***********************************************************************************************");
                Console.Write("Opcion: ");

                opc = int.Parse(Console.ReadLine());

                if (opc < 1 || opc > 6)
                {
                    Console.WriteLine("\nLa opcion ingresada no es valida");
                    Console.ReadKey();

                }

                switch (opc)
                {
                    case 1:
                        {
                            lis_establacimientos.CargarEstablecimientos();
                            Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR ");
                            Console.ReadKey();

                        }
                        break;
                    case 2:
                        {
                            lis_establacimientos.consultar();
                            Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR ");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        {
                            lis_establacimientos.buscar();
                            Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR ");
                            Console.ReadKey();
                        }
                        break;
                    case 4:
                        {
                            lis_establacimientos.modificar();
                            Console.WriteLine("PRESIONA UNA TECLA PARA CONTINUAR ");
                            Console.ReadKey();
                        }
                        break;
                }

            } while (opc != 5);
        }
    }
}