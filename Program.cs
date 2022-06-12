using System;

namespace Factory__Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ToyotaAurisFactory() as ICreateCars;
            var myCar = factory.Create_aCar("Grey");
            Console.WriteLine("Make: " + myCar.Make + " " + myCar.Model + " " + myCar.Year + " " + myCar.Colour);
            Console.ReadLine();
        } 
    }
}
