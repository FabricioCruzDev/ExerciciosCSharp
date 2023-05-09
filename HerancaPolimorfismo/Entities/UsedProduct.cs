namespace HerancaPolimorfismo.Entities
{
    public class UsedProduct : Product
    {
        public DateOnly ManufactureDate { get; set; }

        public UsedProduct()
        {
            
        }

        public UsedProduct(string name, double price, DateOnly manufactureDate)
        : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag() + " (Manufacture date: "+ ManufactureDate + ")";
        }
    }
}