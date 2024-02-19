using ShopPro.OOP.Base;

namespace ShopPro.OOP.Clases
{
    public class Autobuses : Vehiculo, IBaseVehiculo
    {
        public int Kilometraje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Apagar()
        {
            Console.WriteLine("Apagar autobuses");
        }

        public void Enceder()
        {
            Console.WriteLine("Enceder autobuses");
        }
    }
}
