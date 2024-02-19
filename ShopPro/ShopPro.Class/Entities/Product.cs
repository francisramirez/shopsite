using ShopPro.Class.Core;
using System.ComponentModel.DataAnnotations;

namespace ShopPro.Class.Entities
{
    /// <summary>
    /// Entidad que representa la tabla de productos. test
    /// </summary>
    public class Product : BaseEntity
    {
        public int productid { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido.")]
        [StringLength(40, ErrorMessage = "Longitud inválida")]
        public string? productname { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public bool discontinued { get; set; }

        void SaveProduct() 
        {
            this.Save();
        }
        public override bool Exists()
        {
            throw new NotImplementedException();
        }
    }
}
