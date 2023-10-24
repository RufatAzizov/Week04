using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public class Product
    {
        public ushort count; // starts with 0
        public uint price; // starts with 0

        public Product(ushort count, uint price) 
        {
            this.count = count;
            this.price = price;
        }
    }
}
