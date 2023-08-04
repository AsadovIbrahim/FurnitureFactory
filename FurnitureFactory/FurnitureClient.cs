using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    public class FurnitureClient
    {
        private IFurnitureFactory factory;

        public FurnitureClient(IFurnitureFactory factory)
        {
            this.factory = factory;
        }

        public void CreateAndAssembleFurniture()
        {
            IFurniture furniture = factory.CreateFurniture();
            Console.WriteLine("Order received. Starting assembly process...");
            furniture.Assemble();
            Console.WriteLine("Furniture assembly completed.");
        }
    }

}
