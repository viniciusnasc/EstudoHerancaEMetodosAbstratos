using HerancaExercicioProposto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace HerancaExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new();

            Console.Write("Enter the number of products: ");
            int numberProducts = int.Parse(Console.ReadLine());

            for(int i = 0; i< numberProducts; i++)
            {
                Console.WriteLine($"Product #{i+1} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char typeProduct = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (typeProduct == 'c')
                {
                    products.Add(new Product(name, price));
                }
                else if (typeProduct =='u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufacture));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());

                    products.Add(new ImportedProduct(name, price, fee));
                }
            }

            Console.WriteLine("\nPRICE TAGS: ");

            foreach(Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }

        }
    }
}
