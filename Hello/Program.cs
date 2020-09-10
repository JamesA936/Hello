using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            // Asking name
            string name;

            Console.WriteLine("What is you r nam? ");

            name = Console.ReadLine();


            Sayhello(100, name)




            Console.ReadLine();
        }


        static void Sayhello(int howmanytimes, string name)
        {
            for (int num = 0; < howmanytimes; num++)
            {

                Console.WriteLine("hello " + name);
            }




        }


    }

}
