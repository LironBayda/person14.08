
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Program
    {
        static void PrintPersonArray(Person[] people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }

        }

        static void Main(string[] args)
        {
            Person a = new Person(1, 14, 1.67f, "Gal");
            Person b = new Person(3, 4, 0.80f, "Tal");
            Person c = new Person(2, 54, 1.97f, "Dvir");
            Person d = new Person(5, 24, 1.47f, "Pol");
            Person e = new Person(4, 24, 1.87f, "Ben");

            Person[] people = { a, b, c, d, e };

            Array.Sort(people);
            PrintPersonArray(people);

            Console.WriteLine();

            Array.Sort(people,Person.IdComparer);
            PrintPersonArray(people);

            Console.WriteLine();


            Array.Sort(people,Person.AgeComparer);
            PrintPersonArray(people);

            Console.WriteLine();


            Array.Sort(people,Person.HeightComparer);
            PrintPersonArray(people);

            Console.WriteLine();


            Array.Sort(people,Person.NameComparer);
            PrintPersonArray(people);
            Console.ReadLine();






        }
    }
}
