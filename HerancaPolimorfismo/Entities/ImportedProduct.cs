using System.Globalization;

namespace HerancaPolimorfismo.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
            
        }

        public ImportedProduct(string name, double price, double customsFee)
        : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public sealed override string PriceTag()
        {
            return base.PriceTag() + " (Customs fee: $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    
        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}