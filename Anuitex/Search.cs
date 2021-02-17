using System;
using System.Collections.Generic;
using System.Text;

namespace Anuitex
{
    static class Search 
    {
        public static void find(this Company x, string name)  // поиск сотрудника по имени. 
        {
            bool count = true;
            foreach (var item in x.Employees)
            {

                if (name == item.Name)
                {
                    Console.WriteLine("Сотрундник найден!");
                    Console.WriteLine(item.ToString()); ;
                    count = false;
                }

            }
            if (count)
            {
                Console.WriteLine("Сотрудник не найден.");
            }
            
        }

        public static void ListEployees(this Company x)  // список всех сотрудников. 
        {
            Console.WriteLine("Список сотрудников компании:");
            foreach (var item in x.Employees)
            {
                Console.WriteLine(item.ToString());
                
            }
        }
    }
}