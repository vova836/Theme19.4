using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TourOperator> agencies = new List<TourOperator>
        {
            new TourOperator("Агентство1", 2015, "123456789", 100000),
            new TourOperator("Агентство2", 2010, "987654321", 150000),
            new TourOperator("Агентство3", 1995, "456789123", 120000)
        };

            decimal totalProfit = agencies.Sum(a => a.Profit);
            Console.WriteLine($"Суммарная прибыль всех агентств: {totalProfit}");

            TourOperator maxProfitAgency = agencies.OrderByDescending(a => a.Profit).First();
            Console.WriteLine($"Агентство с самой высокой прибылью: {maxProfitAgency.Name} с прибылью { maxProfitAgency.Profit}");

            string bankruptAgencyINN = "987654321"; //  ИНН агентства-банкрота
            var bankruptAgency = agencies.FirstOrDefault(a => a.INN == bankruptAgencyINN);
            if (bankruptAgency != null)
            {
                agencies.Remove(bankruptAgency);
                Console.WriteLine($"Банкротное агентство {bankruptAgency.Name} удален из списка.");
            }

            TourOperator newAgency = new TourOperator("Новое Агенство", 2021, "654987321", 80000);
            agencies.Add(newAgency);

            agencies = agencies.OrderBy(a => a.Profit).ToList();
            Console.WriteLine("Список агентств, отсортированный по прибыли:");
            foreach (var agency in agencies)
            {
                agency.GetInfo();
            }
            Console.ReadKey();
        }      
    }
}
