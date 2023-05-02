using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            Console.WriteLine("Enter n");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter The Values of array");
            for(int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            for(int j = 0; j < array.Length; j++)
            {
                if (j % 2 == 0)
                {
                    continue;
                }
                else if (j % 2 != 0)
                {
                    Console.WriteLine(array[j]);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
