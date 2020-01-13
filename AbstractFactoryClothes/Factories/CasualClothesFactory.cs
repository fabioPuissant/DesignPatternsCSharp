using AbstractFactoryClothes.AbstractProducts;
using AbstractFactoryClothes.Products;

namespace AbstractFactoryClothes.Factories
{
    public class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}