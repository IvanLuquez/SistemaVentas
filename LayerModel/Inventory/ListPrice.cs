using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayerEntity.Inventory
{
    public class ListPrice
    {
        public int idPriceList {get; set;}
        public string namePriceList {get; set;}
        public string descriptionPriceList {get; set;}
        public double pricePriceList {get; set;}
        public bool activePriceList {get; set;}
        public DateTime createPriceList {get; set;}
        public DateTime updatePriceList {get; set;}
        public int idProducto { get; set; }
    }
}
