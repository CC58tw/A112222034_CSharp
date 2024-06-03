using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell_Phone_Inventory
{
    class CellPhone
    {
        // Fields
        private string _brand;   // The phone's brand
        private string _model;   // The phone's model
        private decimal _price;  // Retail price

        // Constructor
        public CellPhone()
        {
            _brand = "";
            _model = "";
            _price = 0m;
        }



        // Brand property
        public string Brand
        {
            get;
            set;
        }
        // Model property
        public string Model
        {
            get;
            set;
        }
        // Price property
        public decimal Price
        {
            get;
            set;
        }
    }
}
