using System;

namespace SameElementInList 
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Person> peopleWithSameName = new List<Person>();
            Person person1 = new Person("Mehmet", "Demir");
            Person person2 = new Person("Ali", "Bulut");
            Person person3 = new Person("Mehmet", "Yılmaz");
            Person person4 = new Person("Mert", "Kanberoğlu");
            Person person5 = new Person("Ramazan", "Altun");
            Person person6 = new Person("Mehmet", "Şahin");
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);
            people.Add(person6);

            foreach (Person person in people)
            {
                if(person.Firstname == "Mehmet")
                {
                    peopleWithSameName.Add(person);
                }
            }
            Console.WriteLine($"Mehmet isimli {peopleWithSameName.Count} kişi bulundu :");
            foreach(Person person in peopleWithSameName)
            {
                Console.WriteLine($"{person.Firstname} {person.Surname}");
            }

        }
        class Person
        {
            public string Firstname { get; set; }
            public string Surname { get; set; }
            public Person(string firstname, string surname)
            {
                Firstname = firstname;
                Surname = surname;
            }
        }
    }
}