using System;
using System.Collections.Generic;

namespace Anuitex
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();


            company.Employees.Add(new Worker("Алексей", "Алексеев", "Алексеевич", 0));
            company.Employees.Add(new Worker("Иван", "Ivan", "Иванович", 3));
            company.Employees.Add(new Worker("Евгений", "Евгенов", "Евгеневич", 4));

            company.Employees.Add(new Manager("Максим", "Максимов", "Максимович", 2));
            company.Employees.Add(new Manager("Артем", "Артемов", "Артёмович", 3));
            company.Employees.Add(new Manager("Дмитрий", "Дмитриев", "Дмитревич", 2));

            company.Employees.Add(new Brigadier("Михаил", "Михаилов", "михаилович", 1));
            company.Employees.Add(new Brigadier("Гена", "Генадий", "Генадиевич", 2));
            company.Employees.Add(new Brigadier("Николай", "Николаев", "Николаевич", 3));

          



           Manager tanya = new Manager("Татьяна", "Татьяновна", "Алексеевна" , 1);
           Worker igor = new Worker("Игорь", "Игоревич", "Алексеевич", 4);

            // переопределение операторов.
            company.Employees += igor; 
            company.Employees -= tanya;
            
            
            Console.WriteLine(new string('-', 60));
            company.find("Гена"); // поиск 
            Console.WriteLine(new string('-', 60));

            company.Query<Manager>(); // Получение сотрудников типа Generic.
            Console.WriteLine(new string('-', 60));
            
            
            company.Quantity<Brigadier>(); // Получение кол-Во сотрудников.
            Console.WriteLine(new string('-', 60));
            
            
            company.ListEployees();  // Список Сотрудников 
            Console.WriteLine(new string('-', 60));
            
            
            
            Console.ReadLine();
           


        }
    }
}
