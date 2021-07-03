using System.Collections.Generic;

namespace ProyectoIntegrador
{
    public class Teclado 
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public string Tipo  { get; set; }

        public List<Teclado> Precios { get; set; }
    }
}


