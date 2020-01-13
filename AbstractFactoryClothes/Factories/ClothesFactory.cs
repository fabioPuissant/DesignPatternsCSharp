using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactoryClothes.AbstractProducts;

namespace AbstractFactoryClothes.Factories
{
    public abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousers();

    }
}
