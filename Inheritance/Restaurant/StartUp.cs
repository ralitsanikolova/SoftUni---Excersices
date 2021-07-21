using System;

namespace Restaurant
{
    class StartUp
    {
        
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            decimal price = decimal.Parse(Console.ReadLine());

        
            Product product = new Product(name,price);
            Console.WriteLine(product);

        }
    }
}
