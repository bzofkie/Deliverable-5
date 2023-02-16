using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_5
{
    class Program
    {
        static int[] random_array(int array_len)
        {
            Random random = new Random();
            int[] MyArray = new int[array_len];
            for(int i = 0; i< array_len; i++)
            {
                MyArray[i] = random.Next(10, 50);
            }
            return MyArray;
        }
        static int sum(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum = sum + item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter an integer between 5 and 15");
                int input = int.Parse(Console.ReadLine());

                int[] sampleArray = random_array(input);

                Console.WriteLine("The elements in the random array are: ");

                foreach (int element in sampleArray)
                {
                    Console.Write(element + " ");
                }

                Console.WriteLine(" ");
                Console.WriteLine("The sum is: " + sum(random_array(input)));

            }
            catch
            {
                Console.WriteLine("Enter an integer between 5 and 15");
            }
            
        }
    }
}
