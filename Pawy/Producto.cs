
namespace ProyectoIntegrador
{
    class Producto
    {
        public static void InformacionMonitor(string[] args)
        {
            Monitor pantalla = new Monitor();
            pantalla.Id = 1;
            pantalla.Marca = "LG";
        }
        public static void InformacionMouse(string[] args)
        {
            Mouse raton = new Mouse();
            raton.Id = 1;
            raton.Marca = "Scorpion";
        }
        public static void InformacionCPU(string[] args)
        {
            CPU cpu = new CPU();
            cpu.Id = 1;
            cpu.Marca = "DELL";
        }
        public static void InformacionLocal(string[] args)
        {
            Local local = new Local();
            local.Id = 1;
            local.Dirreccion = "Garcia Moreno";
        }
        public static void InformacionTeclado(string[] args)
        {
            Teclado teclado = new Teclado();
            teclado.Id = 1;
            teclado.Marca = "Geniuos";
        }
    }    
}
