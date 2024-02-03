using System.ComponentModel.DataAnnotations;

namespace ShopPro.Class.Entities
{
    /// <summary>
    /// Entidad que representa la tabla de productos.
    /// </summary>
    public class Product
    {
        public int productid { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido.")]
        [StringLength(40, ErrorMessage = "Longitud inválida")]
        public string? productname { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public bool discontinued { get; set; }
        public DateTime creation_date { get; set; }
        public int creation_user { get; set; }
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }

        public int? delete_user { get; set; }

        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
