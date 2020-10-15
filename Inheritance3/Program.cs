using System;
using Inheritance3.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"TAX PAYER #{i + 1} DATA:");
                Console.Write("Indivudual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    persons.Add(new PhysicalPerson(name, income, healthExpeditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    persons.Add(new LegalPerson(name, income, employees));
                }
            }

            Console.WriteLine();
            double sum = 0;
            Console.WriteLine("TAXES PAIED:");

            foreach(Person p in persons)
            {
                Console.WriteLine($"{p.Name}: $ {p.Tax().ToString("F2",CultureInfo.InvariantCulture)}");
                sum += p.Tax();
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {sum.ToString("F2",CultureInfo.InvariantCulture)}");

        }
    }
}
