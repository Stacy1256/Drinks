using System;

namespace Drinks.Models
{
    class Drink : Liquid
    {
        private const double priceS = 3.5;
        private const double priceM = 4.5;
        private const double priceL = 5.5;

        public string Name { get; set; }
        public Volume Size { get; set; }
        public double Price { get; set; }
        
        public Drink(string name, Volume size = Volume.S, double price = priceS)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Size = size;
            Price = Price;
        }

        public virtual void SetPrice(Volume size)
        {
            switch (size)
            {
                case Volume.S :
                    Price = priceS;
                    break;
                case Volume.M :
                    Price = priceM;
                    break;
                case Volume.L :
                    Price = priceL;
                    break;
            }
        }

    }
}
