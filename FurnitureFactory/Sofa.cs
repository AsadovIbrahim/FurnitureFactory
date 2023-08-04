using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    public class Sofa:IFurniture
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a sofa");
        }
    }
}
