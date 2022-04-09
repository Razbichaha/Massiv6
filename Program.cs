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

            foreach (int word in array)
            {
                Console.Write(word + " ");
            }

            Console.Write("\n Пузырьковый метод сортировки \n");

            for (int i = 0; i < array.Length; i++)
            {
                for (int ii = 0; ii < array.Length - 1; ii++)
                {
                    if (array[ii] > array[ii + 1])
                    {
                        int tempNumber = array[ii + 1];
                        array[ii + 1] = array[ii];
                        array[ii] = tempNumber;
                    }
                }
            }

            foreach (int word in array)
            {
                Console.Write(word + " ");
            }

            Console.ReadLine();
        }
    }
}
