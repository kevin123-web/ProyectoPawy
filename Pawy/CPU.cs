using System.Collections.Generic;

namespace ProyectoIntegrador
{
    public class CPU
    {
        public int Id { get; set; }

        public string Marca { get; set; }

        public int DiscoDuro { get; set; }

        public List<CPU> Componentes { get; set; }

        public List<CPU> Precios { get; set; }
    }
}
