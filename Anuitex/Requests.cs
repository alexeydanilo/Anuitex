using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Anuitex
{
    static class Requests
    {
        public static void Query<T>(this Company x) // Получение сотрудниов типа дженерик.

        {

            var collection = x.Employees.OfType<T>()
            .ToList();
       

            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void Quantity<T>(this Company x) // Получение кол-во сотрудников. 

        {

            var collection = x.Employees.OfType<T>()
            .ToList()
            .Count();

            Console.WriteLine($"Кол-во сотрудников: {collection}");

        }
    }




}


