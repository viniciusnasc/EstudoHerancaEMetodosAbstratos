using MetodoAbstratoExercicioProposto.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodoAbstratoExercicioProposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> taxPayers = new();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for ( int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i+1} data:");
                Console.Write("Individual or Company (i/c)? ");
                char type = char.Parse(Console.ReadLine().ToLower());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, anualIncome, health));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employee = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, employee));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            
            foreach(Person p in taxPayers)
            {
                Console.WriteLine(p.Name + ": $ " + p.Taxes().ToString("F2", CultureInfo.InvariantCulture));
            }

            double totalTaxes = 0;

            foreach(Person p in taxPayers)
            {
                totalTaxes += p.Taxes();
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
