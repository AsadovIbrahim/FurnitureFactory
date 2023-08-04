﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureFactory
{
    public class TableFactory : IFurnitureFactory
    {
        public IFurniture CreateFurniture()
        {
            return new Table();
        }
    }

}
