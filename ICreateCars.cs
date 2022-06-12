using System;
using System.Collections.Generic;
using System.Text;

namespace Factory__Method
{
    internal interface ICreateCars
    {
        Car Create_aCar(string colour);
    }
}
