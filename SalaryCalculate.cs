using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFpcusIClass
{
    internal class SalaryCalculate
    {
        
        int salary;
        double Tax;

        public void Calculate()
        {
            Console.WriteLine("Skriv din lön innan skatt: ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Skrive din kommuns skatt: ");
            Tax = Convert.ToDouble(Console.ReadLine());


            double skatt = salary * (Tax / 100);

            Console.WriteLine("Din betalade skatt är : "+ skatt);

            double lön = salary - skatt;

            Console.WriteLine("Du har ett lön på " + lön);


        }

        
    }

}
