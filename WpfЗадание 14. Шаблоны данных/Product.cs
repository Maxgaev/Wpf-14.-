using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfЗадание_14.Шаблоны_данных
{
    internal class Product
    {
        public enum ProductTypes
        { 
            Food,
            Appliance
        }

        public string ProdName { get; set; }
        public double ProdPrice { get; set; }
        public string ProdImage { get; set; }
        public ProductTypes ProdType { get; set; }

        public override string ToString()
        {
            return ProdName;
        }


    }
}
