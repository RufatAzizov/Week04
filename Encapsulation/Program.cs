using Encapsulation.Models;
using System.Security.Cryptography.X509Certificates;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook Macbook = new Notebook("Air 15", 5, 2399 );
            Macbook.RAM = 8;
            Macbook.storage = 256;
            
            
            Notebook HP = new Notebook ("Pavilion", 3, 1299);
            HP.RAM = 16;
            HP.storage = 1024;

            
            Console.WriteLine("What notebook do you want to add? \n");
            Console.WriteLine("Set RAM parameters in Gb: ");
            byte userRAM = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("\nSet storage capacity in Gb: ");
            uint userStorage = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Brand: ");
            string userBrand = Console.ReadLine();
            Console.WriteLine("\nEnter notebook model: ");
            string userModel = Console.ReadLine();

            if (userRAM <= 128 && userRAM > 0)
            {


            }









        }

        
    }

    
}