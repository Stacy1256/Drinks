namespace Drinks.Models
{
    class Fresh : Drink
    {
        private const double priceS = 4.5;
        private const double priceM = 5.5;
        private const double priceL = 6.5;
        public string Fruit { get; set; }

        public Fresh(string name, string fruit, Volume size = Volume.S, double price = priceS)
            : base(name, size, price)
        {
            Fruit = fruit;
        }

        public override void SetPrice(Volume size)
        {
            switch (size)
            {
                case Volume.S:
                    Price = priceS;
                    break;
                case Volume.M:
                    Price = priceM;
                    break;
                case Volume.L:
                    Price = priceL;
                    break;
            }
        }
    }
}