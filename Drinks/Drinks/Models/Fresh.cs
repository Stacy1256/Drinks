namespace Drinks.Models
{
    public class Fresh : Drink
    {
        private const double priceS = 4.5;
        private const double priceM = 5.5;
        private const double priceL = 6.5;
        public string Fruit { get; set; }

        public Fresh(string name, string fruit, Volume size = Volume.S)
            : base(name, size)
        {
            Fruit = fruit;
            SetPrice(size);
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