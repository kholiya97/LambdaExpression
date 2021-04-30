﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome To Lambda Expression-----");
            Console.WriteLine();

            //list object creation with person 
            List<Person> list = new List<Person>();

            //method call
            AddingPersonDetails(list);
            SearchPerson(list);
            Console.ReadLine();
        }

        //UC1 person management
        public static void AddingPersonDetails(List<Person> personList) //creating method
        {
            personList.Add(new Person() { SSN = 1, Age = 24, Name = "Himanshu", Address = "Pune" });
            personList.Add(new Person() { SSN = 2, Age = 30, Name = "Kartik", Address = "Pune" });
            personList.Add(new Person() { SSN = 3, Age = 25, Name = "Krunal", Address = "Bangalore" });
            personList.Add(new Person() { SSN = 4, Age = 75, Name = "Harshpal", Address = "pune" });
            personList.Add(new Person() { SSN = 5, Age = 86, Name = "Vishal", Address = "Nainital" });
            personList.Add(new Person() { SSN = 6, Age = 15, Name = "Priyanka", Address = "Dehradun" });

        }

        //UC5 Check for specific name present in list or not
        public static void SearchPerson(List<Person> list)
        {
            try
            {
                var person = list.Where(x => x.Name == "Himanshu").First();
                if (person != null)
                {
                    Console.WriteLine("person present");

                    Console.WriteLine("Age\t" + person.Age + "Name\t" + person.Name + "\t" + "Address\t" + person.Address);
                }
                else
                {
                    Console.WriteLine("person not exist in a list");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class Person
    {

        public int SSN { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

    }
}
