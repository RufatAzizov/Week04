using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public class Notebook : Product
    {
        public string brand;
        public string model;
        public byte RAM; // byte is already 0 to 255
        public uint storage; //uint starts from 0 anyway
        

        public Notebook(string model, ushort count, uint price) : base(count, price)
        {
            this.model = model;
            
        }

        
    }

    
}
