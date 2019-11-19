using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 10;
            int[] array = new int[10] {100, 50, 20, 40, 10, 60, 80, 70, 90, 30};
            Console.WriteLine("The array before selection sort is:");
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine(array[i]);
            }
            int tmp, minKey;
            for (int j = 0; j < arraySize-1; j++)
            {
                minKey = j;
                for (int k = j +1; k < arraySize; k++)
                {
                    if (array[k] < array[minKey])
                    {
                        minKey = k;
                    }
                }
                tmp = array[minKey];
                array[minKey] = array[j];
                array[j] = tmp;
            }
            Console.WriteLine("The array after the selection sort:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadLine();

        }
    }
}
