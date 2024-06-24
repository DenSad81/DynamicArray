using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        const string CommandSum = "sum";
        const string CommandExit = "exit";
        const string CommandPrint = "print";

        bool isWork = true;
        int[] array = new int[0];
        string userInput;

        while (isWork)
        {
            Console.Write($"Введите число или команду {CommandSum} или команду {CommandExit} или команду {CommandPrint}: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case CommandExit:
                    isWork = false;
                    break;

                case CommandSum:
                    int sumOfArray = 0;

                    for (int i = 0; i < array.Length; i++)
                        sumOfArray += array[i];

                    Console.WriteLine($"Сумма членов массива: {sumOfArray}");
                    break;

                case CommandPrint:

                    for (int i = 0; i < array.Length; i++)
                        Console.WriteLine(array[i]);

                    break;

                default:
                    int[] tempArray = new int[array.Length + 1];

                    for (int i = 0; i < array.Length; i++)
                        tempArray[i] = array[i];

                    array = tempArray;
                    array[array.Length - 1] = Convert.ToInt32(userInput);
                    break;
            }
        }
    }
}