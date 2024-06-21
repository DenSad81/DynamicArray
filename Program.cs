using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        const string Sum = "sum";
        const string Exit = "exit";
        const string Print = "print";
        bool isCiklWork = true;
        int[] array = new int[0];
        string dataFromUser;
        int pozitionInArray = 0;

        while (isCiklWork)
        {
            Console.Write($"Введите число или команду {Sum} или команду {Exit} или команду {Print}: ");
            dataFromUser = Console.ReadLine();

            switch (dataFromUser)
            {
                case Exit:
                    isCiklWork = false;
                    break;

                case Sum:
                    int sumOfArray = 0;
                    for (int i = 0; i < array.Length; i++)
                        sumOfArray += array[i];

                    Console.WriteLine($"Сумма членов массива: {sumOfArray}");
                    break;

                case Print:
                    for (int i = 0; i < array.Length; i++)
                        Console.WriteLine(array[i]);

                    break;

                default:
                    int[] tempArray = new int[array.Length + 1];
                    for (int i = 0; i < array.Length; i++)
                        tempArray[i] = array[i];

                    array = tempArray;
                    array[pozitionInArray] = Convert.ToInt32(dataFromUser);
                    pozitionInArray++;
                    break;
            }
        }
    }
}