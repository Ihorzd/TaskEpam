using System;
using System.Collections;
using System.Collections.Generic;

namespace Task3Epam
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public IEnumerable PhoneNumber { get; set; }
    }
    class Program
    {
        static void Main()
        {

            var list = new List<Person>
            {
               new Person { Name = "Alisa", Age = 14, PhoneNumber = "0935778944"},
               new Person { Name = "Julia", Age = 24, PhoneNumber = "093576744"},
               new Person { Name = "Ira", Age = 15, PhoneNumber = "0936778944"},
               new Person { Name = "Nazar", Age = 11, PhoneNumber = "09356780744"},
               new Person { Name = "Stepan", Age = 19, PhoneNumber = "09357756784"},
               new Person { Name = "Ihor", Age = 44, PhoneNumber = "0935778944"},
               new Person { Name = "Olia", Age = 54, PhoneNumber = "093577896587"}
            };
        foreach(Person element in list )
            { 
                foreach(Person twoelement in element)
             }
            
        }
    }
}
