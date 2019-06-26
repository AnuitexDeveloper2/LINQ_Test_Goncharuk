using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Test_Goncharuk
{
    class Book
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<Book>()
            {
                new Book(){Author = "Troelsen" ,Name = "LINQ", Year= 2012 },
                new Book() {Author = "Richter" , Name = "LINQ", Year = 2016 },
                new Book() {Author = "Terry Pratchet" , Name = "Theatre of cluerty ", Year = 2014},
                new Book() {Author = "Stephen King" , Name = "Dark tower", Year = 2015},
                new Book() {Author = "Troelsen" , Name = "LINQ", Year = 2017 },
                new Book() {Author = "Terry Pratchet" , Name = "The color of magic", Year = 2015},
            };
            string unique = "Что нас не убивает делает нас сильнее";
            int[] sequense = {34,21,28,23,36,11,38,25,10 };
            Console.WriteLine(string.Join(Environment.NewLine, data.Where(d => d.Year % 4 == 0 && d.Name.Contains("LINQ")).Select(d => d.Author + " " + d.Name + " " + d.Year)));
            Console.WriteLine(string.Join(Environment.NewLine, unique.Replace(" ", "").ToLower().Distinct().Count()));
            Console.WriteLine(string.Join(",",sequense.OrderBy(k =>k/10).ThenByDescending(k => k % 10)));
            Console.WriteLine(string.Join(Environment.NewLine, data.GroupBy(f => f.Author).Select(f => f.Key + "," + f.Count())));
        }
    }
}
