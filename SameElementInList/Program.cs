using System;
using System.ComponentModel;

namespace SameElementInList 
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            People p1 = new People();
            Person person1 = new Person("Mehmet", "Demir");
            Person person2 = new Person("Ali", "Bulut");
            Person person3 = new Person("Mehmet", "Yılmaz");
            Person person4 = new Person("Mert", "Kanberoğlu");
            Person person5 = new Person("Ramazan", "Altun");
            Person person6 = new Person("Mehmet", "Şahin");
            p1.AddPerson(person1);
            p1.AddPerson(person2);
            p1.AddPerson(person3);
            p1.AddPerson(person4);
            p1.AddPerson(person5);
            p1.AddPerson(person6);
            Console.WriteLine(p1.CheckPeopleWithSameName("Mehmet"));
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
        class People
        {
            public List<Person> ListOfPersons;
            public People()
            {
                this.ListOfPersons = new List<Person>();
            }
            public void AddPerson(Person p)
            {
                this.ListOfPersons.Add(p);
            }
            void DeletePerson(Person p)
            {
                this.ListOfPersons.Remove(p);
            }

            public string CheckPeopleWithSameName(string name)
            {
                //People sınıfının ListOfPersons listesindeki aynı isimli Personların sayısını ve isim ve soyisimlerini döndürür
                List<Person> temp = new List<Person>();
                foreach (Person person in this.ListOfPersons)
                {
                    if (person.Firstname == name)
                    {
                        temp.Add(person);
                    }
                }
                string str = $"{name} isimli {temp.Count} kişi bulundu :";
                foreach (Person person in temp)
                {
                    str += $"\n{person.Firstname} {person.Surname}";
                }
                return str;
            }
        }
    }
}