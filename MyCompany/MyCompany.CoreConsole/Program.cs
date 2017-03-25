using MyCompany.Business.Abstract;
using MyCompany.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.CoreConsole
{
    public class Program
    { 
        public static void Main(string[] args)
        {
           
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Process is starting...");
            using (var mycontext = new MyContext())
            {
                foreach (var product in mycontext.Products)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Products Name : {0}", product.ProductName);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Process is finished...");
            Console.ReadKey();
            
        }
    }
}
