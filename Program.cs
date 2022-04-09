using System;

namespace Massiv6
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int minimumValue = 0;
            int maximumValue = 30;
            int maximumArrayLength = 30;

            int[] array = new int[maximumArrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minimumValue, maximumValue);
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.Write("\n Пузырьковый метод сортировки \n");

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = t;
                    }
                }
            }
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
