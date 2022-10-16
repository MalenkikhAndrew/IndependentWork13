using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndependentWork13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Пирогова", -100, 150, 30);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Комарова", 110, -160, 40, 110);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
