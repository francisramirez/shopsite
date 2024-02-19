using ShopPro.OOP.Base;
 

namespace ShopPro.OOP.Clases
{
    internal class Motor : Vehiculo, IBaseVehiculo
    {
        public int Kilometraje { get; set; }

        public void Apagar()
        {
            Console.WriteLine("Apagar motor");
        }

        public void Enceder()
        {
            Console.WriteLine("Enceder motor");
        }
    }
}
