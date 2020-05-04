using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks.Models
{
    class CoffeeDrink : Liquid
    {

        public string SortOfCoffee { get; set; }
        public bool Coffeine { get; set; }


        public CoffeeDrink(string sort, bool coffeine = false)
        {
            if (string.IsNullOrEmpty(sort))
            {
                //throw new ArgumentNullException(nameof(sort));
            }

            SortOfCoffee = sort;
            Coffeine = coffeine;
        }
    }
}
