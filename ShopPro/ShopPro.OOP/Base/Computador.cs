 

namespace ShopPro.OOP.Base
{
    public abstract class Computador
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Memoria { get; set; }

        public abstract void Enceder();
        public abstract void AumentarSonido();

        public void BajarVolumen() 
        {
            Console.WriteLine("Bajar volumen");
        }
        public virtual void SubirVolumen() 
        {
            Console.WriteLine("Subir volumen desde la clase base");
        }

    }
}
