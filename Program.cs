Console.Write("Введите элементы массива через запятую: ");
        string input = Console.ReadLine();

        string[] inputArray = input.Split(',');

        string[] resultArray = FilterArrayByLength(inputArray);

        Console.WriteLine("Результирующий массив:");
        foreach (string item in resultArray)
        {
            Console.WriteLine(item);
        }