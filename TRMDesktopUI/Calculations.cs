using System.Collections.Generic;

namespace TRMDesktopUI
{
    public class Calculations : ICalculations
    {

        //new list - get and set and created new object in memory
        public List<string> Register { get; set; } = new List<string>();



        public double Add(double x, double y)
        {

            return x + y;
        }

    }
}
