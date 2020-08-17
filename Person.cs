using System;
using System.Collections.Generic;
using System.Text;

namespace MetodiHarjoitus1_Diginikkarit
{
    class Person
    {
        public int id;
        public int money;
        public int workHours;

        public Person()
        {

        }

        public Person(int id)
        {
            this.id = id;
        }
        public void PrintPersonData()
        {
            Console.WriteLine($"\n id:{id} money:{money} workHours:{workHours}");
        }
        public void GiveMoney(int amount)
        {
            this.money += amount;
        }

        public void AddWorkHours(int hours)
        {
            this.workHours += hours;
        }
    }
}
