using System;
using System.Collections.Generic;
using System.Text;

namespace Anuitex
{
    class Manager : Employee
    {
       
        public Manager(string name, string surname, string middlename, int experience, string position = "Менджер")
            :base(name,surname,middlename,experience,position)    
        {
            
        }
        public override void Job()
        {
            Console.WriteLine("Сбор заказов");
        }

        public void GiveTask()
        {
            Console.WriteLine("Выдача задания");
        }

        public override string ToString()
        {

            return $" Имя:{Name} | Фамилия:{Surname} | Отчество:{MiddleName} | Опыт:{Experience}год(а) | Должность:{Position}";
        }

    }
}
