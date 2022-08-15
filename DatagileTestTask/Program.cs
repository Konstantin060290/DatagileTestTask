using System;

namespace DatagileTestTask
{
    internal class Program
    {
        static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter length of array:");
                int length = int.Parse(Console.ReadLine());
                int[] array = new int[length];
                Console.WriteLine("Enter digits:");
                try
                {
                    for (int i = 0; i < length; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(array);
                    int value = 0;
                    int counter = 1;

                    for (int i = 0; i < length; i++)
                    {
                        if (i == length - 1)
                        {
                            break;
                        }
                        if (array[i + 1] == array[i])
                        {
                            value = array[i + 1];
                            counter++;
                        }
                        if (array[i + 1] != array[i] && counter > 1)
                        {
                            Console.WriteLine("Значение: {0}, Количество: {1}", value, counter);
                            counter = 1;
                            value = 0;
                        }
                    }
                    if (counter > 1)
                    {
                        Console.WriteLine("Значение: {0}, Количество: {1}", value, counter);
                        Console.WriteLine();
                    }
                }
                catch
                {
                    Console.WriteLine("Wrong symbol, please try again");
                    Console.WriteLine();
                }
            }
        }
    }
}
