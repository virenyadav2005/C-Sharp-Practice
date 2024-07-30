using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp
{
    

    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }

    internal class DataManager
    {
        public static List<Employee> Data()
        {
            return new List<Employee>
            {
                new Employee{Id = 1, Name = "viren",Department= "IT", Age = 18,Salary = 18000 },
                new Employee{Id = 2,Name = "dhiren", Department = "SDE",Age =18, Salary = 19000 },
                new Employee{Id = 50,Name = "abhi", Department = "Marketing",Age =35, Salary = 10000 },
                new Employee{Id = 29,Name = "naruka", Department = "Developer",Age =23, Salary = 12000 },
                new Employee{Id = 35,Name = "manish", Department = "Cloud",Age =21, Salary = 13000 },
                new Employee{Id = 42,Name = "surya", Department = "Cloud",Age =45, Salary = 19000 },
                new Employee{Id = 298,Name = "sonu", Department = "Security",Age =23, Salary = 15000 },
                new Employee{Id = 04,Name = "Ramesh", Department = "Management",Age =34, Salary = 12000 },
                new Employee{Id = 214,Name = "Gyani", Department = "Developer",Age =23, Salary = 4000 },
                new Employee{Id = 56,Name = "Depant", Department = "IOT",Age =20, Salary = 3000 },
                new Employee{Id = 43,Name = "Yash", Department = "HR",Age =34, Salary = 3000 },
                new Employee{Id = 12,Name = "Adarsh", Department = "SDE",Age =21, Salary = 20000 },
            };

        }

        internal class DemonstrateLINQ
        {
            public void mainExam()
            {
                List<Employee> employee = DataManager.Data();

                //LINQ Operations

                // 8. "Any","All","Count","Sum","Min","Max"         
                Console.WriteLine(employee.Any(e => e.Age > 30));     // returns true or false
                Console.WriteLine(employee.All(e => e.Age > 30));     // returns true or false
                Console.WriteLine(employee.Count(e => e.Age > 30));     // returns Count each and every employee who has age > 30
                Console.WriteLine(employee.Sum(e => e.Salary));     // returns  Sum of Salary of All employees
                Console.WriteLine(employee.Min(e => e.Age));     // returns Min Age
                Console.WriteLine(employee.Max(e => e.Age));     // returns Max Age


                // "MinBy",  "MaxBy"
                Employee emp1 = employee.MinBy(e => e.Age);    // it will return the employee who has minimum age
                Employee emp2 = employee.MaxBy(e => e.Age);    // it will return the employee who has minimum age

                Console.WriteLine("ID: {0}, NAME: {1}, Department: {2}, Age: {3}, Salary: {4}", emp1.Id, emp1.Name, emp1.Department, emp1.Age, emp1.Salary);




                //7. "Distinct By"
                /*
                employee = employee.DistinctBy(x => x.Department).ToList();
                */








                //6. "Take" and "Skip"
                /*
                employee = employee.Take(2).ToList();
                employee = employee.Skip(2).ToList();
                employee = employee.Skip(2).Take(5).ToList();
                */







                //5. "First"
                /*
                Employee emp = employee.First(e => e.Name == "viren");
                Employee emp1 = employee.FirstOrDefault(e => e.Name == "vvvv");

                if(emp1 != null)
                {
                Console.WriteLine("ID: {0}, NAME: {1}, Department: {2}, Age: {3}, Salary: {4}", emp.Id, emp.Name, emp.Department, emp.Age, emp.Salary);
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
                
                */







                //4. "Where Condition" 
                /*
                employee = employee.Where(e => e.Age > 25 && e.Salary > 15000).ToList();
                */






                //3. "OrderBy operation" Ascending - by default or decending
                /*
                employee = employee.OrderBy(x => x.Id).ToList();
                employee = employee.OrderBy(x => x.Id).ThenBy(x => x.Name).ToList(); // on more then one attribute 
                employee = employee.OrderByDescending(x => x.Id).ThenByDescending(x => x.Name).ToList(); // OrderByDesending
                */






                //2. "Select operation" for particular column or attribute value 
                /*
                Console.WriteLine("Select Operation in LINQ");
                IEnumerable<(string,string)> names = employee.Select(e => (e.Name, e.Department));
                IEnumerable<string> Distinctnames = employee.Select(e => e.Name ).Distinct();
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
                
                */




                // 1. Iterating 
                //employee.ForEach(employee => Console.WriteLine("ID: {0}, NAME: {1}, Department: {2}, Age: {3}, Salary: {4}", employee.Id, employee.Name, employee.Department, employee.Age, employee.Salary));


                //foreach (Employee emp in employee)
                //{
                //    Console.WriteLine("ID: {0}, NAME: {1}, Department: {2}, Age: {3}, Salary: {4}", emp.Id, emp.Name, emp.Department, emp.Age, emp.Salary);
                //}

            }
        }
        
    }

}
