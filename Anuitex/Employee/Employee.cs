using System;
using System.Collections.Generic;
using System.Text;

namespace Anuitex
{
    abstract class Employee
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string MiddleName { get; set; }

        public int Experience { get; set; }

        public string Position { get; set; }


        public Employee(string name, string surname, string middlename, int experience, string position)
        {
            Name = name;
            Surname = surname;
            MiddleName = middlename;
            Experience = experience;
            Position = position;
        }

        public abstract void Job();

        public static List<Employee> operator +(List<Employee> a, Employee b)
        {
            List<Employee> result = new List<Employee>();


            foreach (Employee item in a)
            {
                result.Add(item);
            }
            result.Add(b);

            return result;
        }
        public static List<Employee> operator -(List<Employee> a, Employee b)
        {
            List<Employee> result = new List<Employee>();

            foreach (Employee item in a)
            {
                result.Add(item);
            }
            result.Remove(b);

            return result;
        }


    }
}
