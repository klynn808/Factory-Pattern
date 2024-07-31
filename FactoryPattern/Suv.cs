using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Suv : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("To some people I look and drive better than a van.");
        }
    }
}
