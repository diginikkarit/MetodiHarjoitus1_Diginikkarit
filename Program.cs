using System;
using System.Collections.Generic;

namespace MetodiHarjoitus1_Diginikkarit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Factory HooEtEm = new Factory("HenkkaMaukka", 10000, 2);

            Person tyyppi1 = new Person(1);
            Person tyyppi2 = new Person(2);
            Person tyyppi3 = new Person(3);
            Person tyyppi4 = new Person(4);

            HooEtEm.GetWork(tyyppi1, 2);
            HooEtEm.GetWork(tyyppi2, 5);
            HooEtEm.GetWork(tyyppi3, 12);
            HooEtEm.GetWork(tyyppi3, 4);

            //pitää olla system.collections.generic
            List<Person> people = new List<Person>();
            people.Add(tyyppi1);
            people.Add(tyyppi3);

            Console.WriteLine("listalla : "+people.Count);
            people.Remove(tyyppi1);

            Console.WriteLine("listalla : " + people.Count);

        }
    }
}
