using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionProblem
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
            FindAvgAgeForAll(list);
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

        //UC4 Retrieve average age in the list
        public static void FindAvgAgeForAll(List<Person> list)
        {
            try
            {
                var result = list.Average(x => x.Age);

                Console.WriteLine("Average age among all persons\t" + result);

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


