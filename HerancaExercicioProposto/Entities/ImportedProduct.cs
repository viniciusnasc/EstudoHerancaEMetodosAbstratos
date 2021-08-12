using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaExercicioProposto.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        { }

        public ImportedProduct(string nome, double price, double customsFee) : base(nome, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFee.ToString("F2") + ")"; 
        }
    }
}
