

using ShopPro.Class.Core;

namespace ShopPro.Class.Entities
{
    public class Supplier : BaseEntity
    {
        public int supplierid { get; set; }
        public string? companyname { get; set; }
        public string? contactname { get; set; }
        public string? contacttitle { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public string? country { get; set; }
        public string? fax { get; set; }

        void SaveSupplier()
        {
            base.Save();
        }
        public override bool Exists()
        {
            throw new NotImplementedException();
        }
    }
}
