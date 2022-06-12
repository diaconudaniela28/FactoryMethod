using System;
using System.Collections.Generic;
using System.Text;

namespace Factory__Method
{
    internal class ToyotaAurisFactory : ICreateCars
    {
        public Car Create_aCar(string colour)
        {
            return new ToyotaAuris() { Colour = colour };
        }
    }
}
