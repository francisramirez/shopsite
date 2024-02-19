

using ShopPro.OOP.Base;

namespace ShopPro.OOP.Clases
{
    public class Laptop : Computador
    {
        public override void AumentarSonido()
        {
            Console.WriteLine("Aumentar sonido Laptop");
        }

        public override void Enceder()
        {
            GetDatos();
            EncenderLuces();
            Console.WriteLine("Enceder la Laptop");
        }

        protected void EncenderLuces() 
        {
            Console.WriteLine("Encendiendo las luces");

        }

        private void GetDatos() { }

        public override void SubirVolumen()
        {
            Console.WriteLine("Subir volumen desde la laptop.");

        }


    }
}
