using Secao_10_Exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Secao_10_Exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.Write("Common, used or imported (c/u/i)? ");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (opcao == 'i' || opcao == 'I')
                {
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));

                } else if (opcao == 'u' || opcao == 'U')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, data));

                } else
                {

                    list.Add(new Product(name, price));
                }


            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product a in list)
            {
                Console.WriteLine(a.PriceTag());
            }
        }
    }
}
