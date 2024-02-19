

using ShopPro.OOP.Base;

namespace ShopPro.OOP.Clases
{
    public class Carro : Vehiculo, IBaseVehiculo
    {
        public int Kilometraje { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Apagar()
        {
            throw new NotImplementedException();
        }

        public void Enceder()
        {
            throw new NotImplementedException();
        }
    }
}
