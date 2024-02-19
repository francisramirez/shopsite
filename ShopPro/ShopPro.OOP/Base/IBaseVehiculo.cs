

namespace ShopPro.OOP.Base
{
    public interface IBaseVehiculo
    {
        void Enceder();
        void Apagar();

        public int Kilometraje { get; set; }
    }
}
