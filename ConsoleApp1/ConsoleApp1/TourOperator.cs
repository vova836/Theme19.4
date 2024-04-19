using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Создаем класс Туристическая фирма
    /// </summary>
    class TourOperator
    {  
        /// <summary>
        /// Создаем свойства поля классу Туристическая фирма
        /// </summary>
        public string Name { get; set; }
        public int YearEstablished { get; set; }
        public string INN { get; set; }
        public decimal Profit { get; set; }

        /// <summary>
        /// Создаем методы класса Туристическая фирма
        /// </summary>
        /// <param name="name"></param>
        /// <param name="yearEstablished"></param>
        /// <param name="inn"></param>
        /// <param name="profit"></param>
        public TourOperator(string name, int yearEstablished, string inn, decimal profit)
        {
            Name = name;
            YearEstablished = yearEstablished;
            INN = inn;
            Profit = profit;
        }

        /// <summary>
        /// Создваем метод вывода о информации из класса Туристическая фирма
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Туристическое агентство: {Name}\nГод создания: {YearEstablished}\nИИН: {INN}\nПрибыль за текущий год: {Profit}\n");
        }
    }

}
