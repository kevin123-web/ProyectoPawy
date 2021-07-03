using System;

namespace ProyectoIntegrador
{
    class PawyTecnology:Producto //Pawy = Products always with you
    {
        public static void Main(string[] args)
        {
            Saludo(args);
            Console.WriteLine("Que tipo de producto quiere adquirir para tu computadora");
            string producto;
            producto = Console.ReadLine();
            Console.WriteLine("El producto elegido es : " + producto);

        }
        public static void Saludo(string[] args)
        {
            Console.Write("Bienvenido a Pawy Tecnology 3.0");
            Console.ReadLine();
        }


    }
}
