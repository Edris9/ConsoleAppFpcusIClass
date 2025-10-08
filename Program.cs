using System.Runtime.InteropServices.Marshalling;

namespace ConsoleAppFpcusIClass
{
    internal class Program
    
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lön Kalkylator: ");

            SalaryCalculate salaryCalculate = new SalaryCalculate();
            
            Console.WriteLine("skriv ditt namn först: ");
            String Name = Console.ReadLine();
            //
            Console.WriteLine("Hej " + Name);
            salaryCalculate.Calculate();
        }
    }
}
