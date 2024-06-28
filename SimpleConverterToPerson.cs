using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGspi
{
    internal class SimpleConverterToPerson
    {
        public List<Person> FilterEmployees(List<Dictionary<string, string>> employees)
        {
            List<Person> filteredEmployees = new();

            Person person = new();

            decimal minSalary = 70000;
            char firstChar = 'К';

            foreach (var emp in employees)
            {
                if (decimal.Parse(emp["Зарплата"]) > minSalary)
                {
                    if (emp["Фамилия"].StartsWith('К'))
                    {
                        person =new ();
                        person.Salary = decimal.Parse(emp["Зарплата"]);
                        person.SecondName = emp["Фамилия"];
                        person.Name = emp["Имя"];
                        person.Department = emp["Отдел"];
                            
                        filteredEmployees.Add(person);

                    }
                }
            }

            return filteredEmployees;
        }

        public void PrintList(List<Person> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine("Имя: " + emp.Name);
                Console.WriteLine("Фамилия: " + emp.SecondName);
                Console.WriteLine("Отдел: " + emp.Department);
                Console.WriteLine("Зарплата: " + emp.Salary);
                Console.WriteLine();
            }
        }
    }
}
