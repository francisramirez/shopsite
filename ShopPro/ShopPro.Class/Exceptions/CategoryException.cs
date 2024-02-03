

namespace ShopPro.Class.Exceptions
{
    public class CategoryException : Exception
    {
        public CategoryException(string message) : base(message)
        {
            SaveError(message);
        }

        void SaveError(string message) 
        { 
            // Logica para guardar el error en la base de datos y tambien
            //enviar el error por correo //
        }
    }
}
