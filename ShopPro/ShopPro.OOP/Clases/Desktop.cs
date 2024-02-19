
using ShopPro.OOP.Base;

namespace ShopPro.OOP.Clases
{
    public class Desktop : Computador
    {
        public override void AumentarSonido()
        {
            Console.WriteLine("Aumentar sonido desktop");
        }

        public override void Enceder()
        {

            Console.WriteLine("Enciene el Desktop");
        }
    }
}
