using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                
                float home2 = 2;
                float home1 = 5/home2;
                Console.WriteLine(home1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */
            //первое
            /*
            var box1 = "вывести в кансоль";
            Console.WriteLine(box1);
            var box2 = "Шааа";
            Console.WriteLine(box2);
            var box3 = box1+" "+box2;
            Console.WriteLine(box3);
            */
           // Console.WriteLine("Скажите ваше имя");
            Console.Write("Скажите ваше имя:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Ваше имя " + name1);

            Console.ReadKey();
            
            
            
        }
    }
}
