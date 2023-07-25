﻿Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine()!;

        string[] inputArray = input.Split(',');

        string[] resultArray = FilterArrayByLength(inputArray);

        Console.WriteLine("Результирующий массив:");
        foreach (string item in resultArray)
        {
            Console.WriteLine(item);
        }


        static string[] FilterArrayByLength(string[] inputArray)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }



        string[] resultArray = new string[count];
        int index = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[index] = inputArray[i];
                index++;
            }
        }

        return resultArray;
    }