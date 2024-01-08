using System.Globalization;

namespace Heranca_Polimorfismo.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; private set; }
        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) 
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name+" (used) $ "+Price.ToString("F2", CultureInfo.InvariantCulture)+" (Manufacture date: "+ManufactureDate.ToString("dd/mm/yyyy")+" )";
        } 
    }
}
