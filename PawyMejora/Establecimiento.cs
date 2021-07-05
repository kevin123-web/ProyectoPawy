using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoIntegrador
{
    class Establecimiento
    {
        public double cantidad;

        public string nombreEstableci;

        public int nit;

        public string barrio;

        public string serviciosOfrece;

        public string jornada;

        public int cantidadEmpleadosActuales;

        public int cantidadEmpleadosDespedidos;

        public double perdidaDineroPersona;

        public double bono = 50000;

        public double perdida = 150000, total, totalPerdida;

        int opc;

        public double acu = 0;

        double perd1 = 0, ttP1 = 0;

        double ttD = 0, Ttp = 0, tt1 = 0, tt2 = 0;

        //condicion de la lista
        List<Establecimiento> lista_establecimientos = new List<Establecimiento>();

        public double Cantidad { get => cantidad; set => cantidad = value; }

        public string NombreEstableci { get => nombreEstableci; set => nombreEstableci = value; }

        public int Nit { get => nit; set => nit = value; }

        public string Barrio { get => barrio; set => barrio = value; }

        public string ServiciosOfrece { get => ServiciosOfrece; set => serviciosOfrece = value; }

        public string Jornada { get => jornada; set => jornada = value; }

        public int CantidadEmpleadoActuales { get => cantidadEmpleadosActuales; set => cantidadEmpleadosActuales = value; }

        public int CantidadEmpleadosDespedidos { get => cantidadEmpleadosDespedidos; set => cantidadEmpleadosDespedidos = value; }

        public double Bono { get => bono; set => bono = value; }

        public void CargarEstablecimientos()
        {
            Establecimiento n_Establecimiento = new Establecimiento();
            Console.Clear();
            Console.WriteLine
                ("****************************************************");
            Console.WriteLine("\n\t\t\t\tFecha " + DateTime.Now);


            Console.Write("\n Ingrese el nombre del establecimiento: ");
            n_Establecimiento.nombreEstableci = (Console.ReadLine());
            Console.Write("Ingrese el Nit de la empresa : ");
            n_Establecimiento.nit = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Barrio: ");
            n_Establecimiento.barrio = Console.ReadLine();
            Console.Write("Ingrese el servicio que ofrece: ");
            n_Establecimiento.serviciosOfrece = Console.ReadLine();
            Console.Write("Ingrese la jornada Día/Noche: ");
            Console.Write("\n 1) Día \n 2)Noche: ");
            opc = int.Parse(Console.ReadLine());

            //variables para llevar el conteo de las perdidas en la noche y dia
            n_Establecimiento.bono = 500000;

            Console.Write("Ingrese la cantidad de empleados actuales: ");
            n_Establecimiento.cantidadEmpleadosActuales = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de empleados despedidos: ");
            n_Establecimiento.cantidadEmpleadosDespedidos = int.Parse(Console.ReadLine());
            Console.Write("Cantidad de dinero perdido por persona: ");
            n_Establecimiento.perdidaDineroPersona = double.Parse(Console.ReadLine());

            //establecimeintos que trabajan por el dia y despedieron trabajadores y tuvo perdidas

            if (opc == 1)
            {
                ttD = n_Establecimiento.cantidadEmpleadosDespedidos;
                tt1 += ttD;

                totalPerdida = tt1 * tt2;

                Console.WriteLine("\n=> Establecimeintos que trabajan por el dia y despido de empleados y \ntotal despedidos " + tt1 + " y total de las perdidas $" + tt2);
                Console.WriteLine
                    ("*************************************************************");

            }

            if (opc == 2)
            {
                if (n_Establecimiento.cantidadEmpleadosActuales > 5 && n_Establecimiento.perdidaDineroPersona > perdida)
                {
                    Console.WriteLine("\n Te damos un bono de $" + bono + "millones de peso, por tener mas de 5 empleados y la perdida que tuviste");

                    perd1++;
                    ttP1 = perd1;
                    if (perdida > 500000)
                    {
                        Console.WriteLine("\n=> Establecimiento nocturnos que tuvieron perdidas superiores a 500 mil " + ttP1);
                    }
                    Console.WriteLine("\n=> Nombre de esblecimiento que recibe un bono: " + n_Establecimiento.nombreEstableci);
                    Console.WriteLine("=> Total de bonos entregados al establecimiento: " + ttP1);


                }
                else
                {
                    Console.WriteLine("\n No ganaste bono");
                }
                Console.WriteLine
                    ("***********************************************");

            }
            lista_establecimientos.Add(n_Establecimiento);

            acu = Ttp;
            total = acu + acu;

        }

        public void consultar()
        {
            Console.Clear();
            Console.WriteLine
                ("************************************");
            Console.WriteLine("\n\t\t\t\tFecha " + DateTime.Now);

            Console.WriteLine("\n\t\tConsultando registro de establecimiento");

            foreach (Establecimiento p in lista_establecimientos)
            {
                Console.WriteLine("\n Nombre del establecimiento  :" + p.NombreEstableci);
                Console.WriteLine(" Nit                           :" + p.Nit);
                Console.WriteLine(" Barrio                        :" + p.Barrio);
                Console.WriteLine(" Servicios que ofrece          :" + p.ServiciosOfrece);
                Console.WriteLine(" Cantidad empleados actuales   :" + p.CantidadEmpleadoActuales);
                Console.WriteLine(" Cantidad empleados despedidos :" + p.CantidadEmpleadosDespedidos);
                Console.WriteLine(" Perdida de dinero por persona :" + p.perdidaDineroPersona);

            }
            Console.WriteLine
                ("*************************************************************");
        }

        public void buscar()
        {
            Console.Clear();
            Console.WriteLine
                ("**************************************");
            Console.Write("\n\t\tFecha " + DateTime.Now);
            bool buscar = false;
            Console.Write("\n Ingrese el Nit del establecimiento a buscar : ");
            int nitEstablecimiento = int.Parse(Console.ReadLine());

            foreach(Establecimiento p in lista_establecimientos)
            {
                if (p.Nit == nitEstablecimiento)
                {
                    Console.Clear();
                    Console.WriteLine
                        ("*************************************************");
                    Console.WriteLine("\n Nombre del establecimeinto: " + p.NombreEstableci);
                    Console.WriteLine(" Nit: " + p.Nit);
                    Console.WriteLine(" Barrio: " + p.Barrio);
                    Console.WriteLine(" Servicio que ofrece: " + p.ServiciosOfrece);
                    Console.WriteLine(" Cantidad de empleados: " + p.CantidadEmpleadoActuales);
                    Console.WriteLine(" Cantidad empleados despedidos: " + p.cantidadEmpleadosDespedidos);
                    Console.WriteLine(" Perdida de dinero por empleados: " + p.perdidaDineroPersona);
                    Console.WriteLine
                        ("\n**********************************************");
                }
            }
            if (buscar == false)
            {
                Console.WriteLine(" El Nit del establecimiento " + nitEstablecimiento +
                    "no esta en la lista");
            }
            Console.ReadKey();
        }
        public void modificar()
        {
            Console.Clear();
            Console.WriteLine
                ("**************************************************************");
            Console.WriteLine("\n\t\t\t\t\tFecha " + DateTime.Now);

            string respuesta = "";
            bool buscar = false;

            Console.WriteLine("\n\t\tModificar establecimientos");
            do
            {
                Console.WriteLine("\n Desea modificar los datos de los establecimeintos: ");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();

                if (respuesta.Equals("Si"))
                {
                    Console.Write("\n Ingresa el Nit del establecimiento a modificar: ");
                    int nit_Establecimiento = Convert.ToInt32(Console.ReadLine());

                    foreach (Establecimiento p in lista_establecimientos)
                    {
                        if (nit_Establecimiento == p.Nit)
                        {
                            Console.WriteLine
                                ("*****************************************");
                            Console.WriteLine("\n Nombre del establecimeinto: " + p.NombreEstableci);
                            Console.WriteLine(" Nit: " + p.Nit);
                            Console.WriteLine(" Barrio: " + p.Barrio);
                            Console.WriteLine(" Servicio que ofrece: " + p.ServiciosOfrece);
                            Console.WriteLine(" Cantidad de empleados: " + p.CantidadEmpleadoActuales);
                            Console.WriteLine(" Cantidad empleados despedidos: " + p.cantidadEmpleadosDespedidos);
                            Console.WriteLine(" Perdida de dinero por empleados: " + p.perdidaDineroPersona);
                            Console.WriteLine
                                ("\n**********************************************");
                            buscar = true;

                            Console.Write("\n Ingresa el nuevo nombre del establecimiento: ");
                            p.nombreEstableci = Console.ReadLine();

                            Console.Write("\n Ingresa el nuevo Nit: ");
                            p.nit = int.Parse(Console.ReadLine());

                            Console.Write("\n Ingresa el nuevo barrio: ");
                            p.barrio = Console.ReadLine();

                            Console.Write("\n Ingresa el nuevo sevicio que ofrece: ");
                            p.serviciosOfrece = Console.ReadLine();

                            Console.Write("\n Ingresa el nueva cantidad de empleados: ");
                            p.cantidadEmpleadosActuales = int.Parse(Console.ReadLine());

                            Console.Write("\n Ingresa el nueva cantidad empleados despedidos: ");
                            p.cantidadEmpleadosDespedidos = int.Parse(Console.ReadLine());

                            Console.Write(" Ingrese la nueva perdida de dinero por empleados: ");
                            p.perdidaDineroPersona = double.Parse(Console.ReadLine());
                            buscar = true;
                            Console.ReadKey();
                        }
                        else if (respuesta.Equals("NO"))
                        {
                            Console.WriteLine("Gracias por tu atención csm");
                        }
                    }
                    if (buscar == false)
                    {
                        Console.WriteLine("El establecimiento con el Nit " + nit_Establecimiento + " no esta en la lista");
                    }
                }
            } while (respuesta.Equals("SI"));
        }
    }
}