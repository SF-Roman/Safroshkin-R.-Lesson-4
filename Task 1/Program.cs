using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Задача 1 
    /// Сафрошкин Роман
    /// </summary>
    /// К сожалению, больше пока не успеваю выполнить, улетел в коммандировки. По возращению обязательно сделаю остальные задачи, но сейчас, для сдачи в срок, отправляю минимум для 
    /// прохода дальше. 

    class Program
    {

        static int PairsNum(int[] array, int n)
        {
            int PairsCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    PairsCount++;
                }
            }
            return PairsCount;
        }

        static void Main(string[] args)
        {
            const int arrLen = 20;
            int[] myArray = new int[arrLen];
            Random random = new Random();
            int result;

            Console.WriteLine("Эта программа считает пары в массиве, в которых хотя бы одно число делится на три.");
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < arrLen + 1; i++)
            {
                myArray[i] = random.Next(-10000, 10000);
                Console.Write(myArray[i] + "\n");
            }
            Console.WriteLine(" ");

            result = PairsNum(myArray, arrLen);

            Console.WriteLine($"Количество пар: {result}");

            Console.ReadKey();
        }
    }

}
