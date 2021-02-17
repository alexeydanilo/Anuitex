using System;
using System.Collections.Generic;
using System.Text;

namespace Anuitex
{
    class Brigadier : Employee
    {

       
        public Brigadier(string name, string surname, string middlename, int experience, string position = "Бригадир")
                : base(name, surname, middlename, experience, position)
        {

        }

        public override void Job()
        {
            Console.WriteLine("Закупка метериала");
        }

        public void CheckingWorkers()
        {
            Console.WriteLine("Проверка рабочих");
        }
        public override string ToString()
        {

            return $" Имя:{Name}| Фамилия:{Surname} | Отчество:{MiddleName} | Опыт:{Experience}год(а) | Должность:{Position}";
        }

    }
}
