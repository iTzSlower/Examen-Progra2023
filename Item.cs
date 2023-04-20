using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    abstract class Item
    {
        protected float price;

        protected Item(float price)
        {
            this.price = price;
        }
    }
}
