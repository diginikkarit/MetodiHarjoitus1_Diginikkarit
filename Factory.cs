using System;
using System.Collections.Generic;
using System.Text;

namespace MetodiHarjoitus1_Diginikkarit
{
    class Factory
    {
        public string name;
        public int funds;
        public int cumulativeHours;
        public int paidSalaries;
        public int totalProducts;
        public int salaryPaidPerHour;

        public Factory()
        {

        }

        public Factory(string name, int funds,int salaryPaidPerHour)
        {
            this.name = name;
            this.funds = funds;
            this.salaryPaidPerHour = salaryPaidPerHour;
        }

        public void PrintFactoryData()
        {
            Console.WriteLine($"\nName: {name} Funds: {funds} Cumulative hours: {cumulativeHours} Paid Salaries: {paidSalaries}h Total Products: {totalProducts}");
        }

        public void PaySalary(Person employee, int amount)
        {
            this.funds -= amount;
            employee.money += amount;
            paidSalaries += amount;
        }

        public void GetWork(Person worker, int hours)
        {
            this.cumulativeHours += hours;
            worker.workHours += hours;
            this.totalProducts += 1 * hours;

            //Pay salary by the hour
            int calculatedSalary = hours * salaryPaidPerHour;
            PaySalary(worker, calculatedSalary);

            //void PaySalary()
            //{
            //    this.PaySalary(worker, calculatedSalary);
            //}

            //PaySalary();
        }

    }
}
