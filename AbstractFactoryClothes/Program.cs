using System;
using AbstractFactoryClothes.Factories;

namespace AbstractFactoryClothes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client entrepreneur = new Client(new ElegantClothesFactory());
            string entrepreneurClothes = entrepreneur.DescribeYourClothes();
            Console.WriteLine($"The entrepreneur is wearing: {entrepreneurClothes}");

            Client student = new Client(new CasualClothesFactory());
            string studentClothes = student.DescribeYourClothes();
            Console.WriteLine($"The student is wearing: {studentClothes}");

        }
    }
}
