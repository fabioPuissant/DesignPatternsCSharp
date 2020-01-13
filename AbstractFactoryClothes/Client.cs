using AbstractFactoryClothes.AbstractProducts;
using AbstractFactoryClothes.Factories;

namespace AbstractFactoryClothes
{
    public class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        public Client(ClothesFactory clothesFactory)
        {
            _shirt = clothesFactory.CreateShirt();
            _trousers = clothesFactory.CreateTrousers();
        }

        public string DescribeYourClothes()
        {
            return $"Today I'm dressed in: {_shirt.GetType().Name} and {_trousers.GetType().Name}";
        }
    }
}
