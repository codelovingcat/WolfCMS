namespace WolfCMS.Entities.Concrete
{
    public class Product : BaseClass
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string QuantiityPerUnit { get; set; } //TODO : Araştırılacak.
    }
}
