using System;
using System.Collections.Generic;
using System.Text;

namespace Anuitex
{
    class Worker : Employee
    {
        
          public Worker(string name, string surname, string middlename, int experience, string position = "Рабочий")
                : base(name, surname, middlename, experience, position)
        {

        }

        public override void Job()
        {
            Console.WriteLine("Выпуск продукции");
        }

        public override string ToString()
        {

            return $" Имя:{Name} | Фамилия:{Surname} | Отчество:{MiddleName} | Опыт:{Experience}год(а) | Должность:{Position}";
        }

    }
}


