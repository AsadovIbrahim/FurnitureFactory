using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    public class Chair:IFurniture
    {
        public void Assemble()
        {
            Console.WriteLine("Assembling a chair");
        }

    }
}
