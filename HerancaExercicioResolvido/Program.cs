using System;
using System.Collections.Generic;

namespace HerancaExercicioResolvido
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new();

            Console.Write("Enter the number ef employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberEmployees; i++)
            {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hour = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    employees.Add(new OutsourcedEmployee(name, hour, valuePerHour, additionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hour, valuePerHour));
                }

                Console.WriteLine("\nPAYMENTS:");
                foreach(Employee emp in employees)
                {
                    Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2"));
                }
            }
        }
    }
}
