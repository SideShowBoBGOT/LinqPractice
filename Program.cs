using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using Exten;

namespace ConsoleApp18
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Random r = new Random();

            //List<int> numbers = new List<int>();
            //for (int i = 0; i < 100; i++)
            //{
            //    numbers.Add(r.Next(1, 10));
            //}
            //foreach (var num in numbers.Distinct())
            //{
            //    Console.WriteLine($"Number: {num}\tNUmber*Frequency: {num * numbers.Count(x => x == num)}\tFrequency:{numbers.Count(x => x == num)}");
            //}

            //string str = Console.ReadLine();
            //foreach (var s in str.Distinct().OrderBy(x => x))
            //{
            //    Console.WriteLine($"Character: {s}\tFrequency: {str.Count(x => x == s)}");
            //}

            //List<string> strs = new List<string>() { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI" };
            //string FirstLetter = Console.ReadLine();
            //string SecondLetter = Console.ReadLine();
            //var res = strs.Where(x => x[0].ToString() == FirstLetter).Where(x => x.Last().ToString() == SecondLetter);
            //foreach (var i in res)
            //    Console.WriteLine(i);
            string str = Console.ReadLine();
            List<string> splitStr = new List<string>();
            splitter(splitStr, str);
            foreach (var i in splitStr)
                Console.WriteLine(i);
            Console.WriteLine("======================================");
            var res = splitStr.Where(x => x == x.ToUpper());
            foreach(var i in res)
            {
                Console.WriteLine(i);
            }
        }
        public static void splitter(List<string> splitStr, string str,int index = 0)
        {
            List<char> characters = new List<char>();
            for (int i = index; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    if (characters.Count!=0)
                    {
                        splitStr.Add(new string(characters.ToArray()));
                    }
                    i++;
                    splitter(splitStr, str, i);
                    break;
                }
                else
                {
                    characters.Add(str[i]);
                    if(i==str.Length-1)
                        splitStr.Add(new string(characters.ToArray()));
                }
            }
        }
        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public int TotalMarks { get; set; }

            public static List<Student> GetAllStudetns()
            {
                List<Student> listStudents = new List<Student>
        {
            new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
            new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
            new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 },
            new Student { StudentID= 104, Name = "John", TotalMarks = 800 },
            new Student { StudentID= 105, Name = "John", TotalMarks = 800 },
            new Student { StudentID= 106, Name = "Brian", TotalMarks = 700 },
            new Student { StudentID= 107, Name = "Jade", TotalMarks = 750 },
            new Student { StudentID= 108, Name = "Ron", TotalMarks = 850 },
            new Student { StudentID= 109, Name = "Rob", TotalMarks = 950 },
            new Student { StudentID= 110, Name = "Alex", TotalMarks = 750 },
            new Student { StudentID= 111, Name = "Susan", TotalMarks = 860 },
        };

                return listStudents;
            }
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string Department { get; set; }
            public int Salary { get; set; }

            public static List<Employee> GetAllEmployees()
            {
                return new List<Employee>()
        {
            new Employee { ID = 1, Name = "Mark", Gender = "Male",
                                         Department = "IT", Salary = 45000 },
            new Employee { ID = 2, Name = "Steve", Gender = "Male",
                                         Department = "HR", Salary = 55000 },
            new Employee { ID = 3, Name = "Ben", Gender = "Male",
                                         Department = "IT", Salary = 65000 },
            new Employee { ID = 4, Name = "Philip", Gender = "Male",
                                         Department = "IT", Salary = 55000 },
            new Employee { ID = 5, Name = "Mary", Gender = "Female",
                                         Department = "HR", Salary = 48000 },
            new Employee { ID = 6, Name = "Valarie", Gender = "Female",
                                         Department = "HR", Salary = 70000 },
            new Employee { ID = 7, Name = "John", Gender = "Male",
                                         Department = "IT", Salary = 64000 },
            new Employee { ID = 8, Name = "Pam", Gender = "Female",
                                         Department = "IT", Salary = 54000 },
            new Employee { ID = 9, Name = "Stacey", Gender = "Female",
                                         Department = "HR", Salary = 84000 },
            new Employee { ID = 10, Name = "Andy", Gender = "Male",
                                         Department = "IT", Salary = 36000 }
        };
            }
        }
        public class Person
        {
            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return $"{this.FirstName}\t{this.LastName}";
            }


            //override ToString to return the person's FirstName LastName Age
        }
    }
    
}
