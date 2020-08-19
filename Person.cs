using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Person: IComparable<Person>
    {
        public int Id { get;private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }
        private static readonly IComparer<Person> idComparer;
        private static readonly IComparer<Person> ageComparer;
        private static readonly IComparer<Person> heightComparer;
        private static readonly IComparer<Person> nameComparer ;

        static public IComparer<Person> IdComparer { 
            get
            { return idComparer; }
        }
        static public IComparer<Person> AgeComparer
        {
            get
            { return ageComparer; }
        }
        static public IComparer<Person> HeightComparer
        {
            get
            { return heightComparer; }
        }

        static public IComparer<Person> NameComparer
        {
            get
            { return nameComparer; }
        }

         static Person()
        {
              idComparer = new PersonCompareById();
        ageComparer = new PersonCompareByAge();
       heightComparer = new PersonCompareByHeight();
       nameComparer = new PersonCompareByName();


    }
    public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }

        int IComparable<Person>.CompareTo(Person other)
        {
            return this.Id - other.Id;
        }

        public override string ToString()
        {
            return base.ToString()+$"{Id} {Age} {Height} {Name}";
        }
    }

    class PersonCompareById : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person x, Person y)
        {
            return x.Id - y.Id;
        }
    }

    class PersonCompareByAge : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }

    class PersonCompareByHeight : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person x, Person y)
        {
            return Convert.ToInt32((x.Height - y.Height)*100);//i multiple it by 100 becuase if for example we have-17.899-17.800=0.99
            //if we convert it to int witout the multiplication we get 0. i assume that we have two digit after the dot (that represent centimeter)
        }
    }

    class PersonCompareByName : IComparer<Person>
    {
        int IComparer<Person>.Compare(Person x, Person y)
        {
            return string.Compare(x.Name, y.Name);
        }
    }

}
