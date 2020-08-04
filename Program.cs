using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

// https://www.youtube.com/watch?v=kW84q8WOBdU&list=PLLWMQd6PeGY12yNE714jffLFnMVZCwvvZ&index=2

namespace RandomNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random random = new Random(1); ==> akan salah jika menggunakan seed value Random(1)
            Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    //Console.WriteLine(random.Next(5,11));
            //    //Console.WriteLine(random.NextDouble());
            //    Console.WriteLine(random.NextDouble() * 10);
            //    //SimpleMethod(random);
            //}

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel{FirstName = "Tim"},
                new PersonModel{FirstName = "Sue"},
                new PersonModel{FirstName = "Mary"},
                new PersonModel{FirstName = "George"},
                new PersonModel{FirstName = "Jane"},
                new PersonModel{FirstName = "Nancy"},
                new PersonModel{FirstName = "Bob"}
            };

            //var sortedPeople = people.OrderByDescending(x => x.FirstName);                    
            var sortedPeople = people.OrderBy(x => random.Next());

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }

            Console.ReadLine();
        }

        private static void SimpleMethod(Random random)
        {
            Console.WriteLine(random.Next());
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
    }
}
