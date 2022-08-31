using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace йоу
{
    internal class Program
    {
     

        static void Main(string[] args)
        {

           

                Console.WriteLine("Введи число: ");

            int a = int.Parse(Console.ReadLine());

            string str =a.ToString();

            int[]myArray=new int[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                myArray[i] = int.Parse(str[i]);
            }

            Console.WriteLine(myArray[2]);






          
                

         

            

        }
    }
}
