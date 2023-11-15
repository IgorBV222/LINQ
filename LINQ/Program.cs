using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LINQMetod();
        }
        private static void LINQMetod()
        {
            string[] counteries = { "Albania", "UK", "Latvia", "Monaco", "Livia", "Poland", "France", "Liberia", "Lo", "Lesotho" };
            //var result = from c in counteries
            //             where c.StartsWith("L") 
            //             orderby c.Length descending
            //             select c;

            var result = counteries.Where(x => x.StartsWith("L")).OrderByDescending(x => x.Length).First(); 
            Console.WriteLine("самое длинное слово на L: " + result +"\n");
            
            var result2 = counteries.Where(x => x.StartsWith("L")).Max(x => x.Length).ToString(); 
            Console.WriteLine("максимальное число символов в самом длинном слове на L: " + result2 + "\n");
            // вывод самого длинного слова на L
            //var tmp = counteries.Where(x => x.StartsWith("L")).OrderByDescending(x => x.Length); 
            //var result = tmp.First();
            //Console.WriteLine(result);

            var result1 = counteries.Where(x => x.StartsWith("L")).OrderByDescending(x => x.Length); 
            Console.WriteLine("сортировка по убыванию слов на L:\n");
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nPress Enter to complete");
            Console.ReadLine();
        }
    }
}
