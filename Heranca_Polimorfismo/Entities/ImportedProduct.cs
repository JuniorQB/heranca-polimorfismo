using System.Globalization;

namespace Heranca_Polimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; private set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) 
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return base.PriceTag() + " Custom fee: $ "+CustomsFee.("F2", CultureInfo.InvariantCulture);
        }

        public double TotalPrice()
        {
            return Price + CustomsFee ;
        }
    }
}
