using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba_1
{
    internal class Program
    {
        public static int[] AddTenNumbers()
        {
            Console.WriteLine("You have to enter 10 numbers");
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"enter {i + 1} number");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            return array;
        }



        public static void SortArray(int[] array)
        {


            for (int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                for (int k = i + 1; k < array.Length; k++)
                {
                    if (array[k] <= min)
                    {
                        min = array[k];
                        array[k] = array[i];
                        array[i] = min;


                    }

                }

            }


        }



        public static int difference(int[] array)
        {
            SortArray(array);
            int difference = array[array.Length - 1] - array[0];
            Console.WriteLine($"difference between biggest and smallest elements is {difference}");
            return difference;

        }


        public static void printCustomElements(int[] array)
        {
            Console.WriteLine("custom elements are");
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2 == 0 && array[i] % 3 == 0) || array[i] % 2 != 0)
                {
                    Console.Write($"{array[i]} ");

                }
            }
            Console.WriteLine();
        }



        public static void sum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];

            }
            Console.WriteLine($"sum of array elements is {sum}");
        }
        static void Main(string[] args)
        {
            int[] array = AddTenNumbers();


            SortArray(array);
            Console.WriteLine("sorted array is");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");

            }
            Console.WriteLine();

            difference(array);

            printCustomElements(array);

            sum(array);




            Console.ReadLine();

        }
    }
}
