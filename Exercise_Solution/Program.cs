// Задача: Написать программу, которая из имеющегося 
// массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 

// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



// Метод введения пользовательского примера для проверки решения
string[] InputYourExampleArray ()
{
    Console.Write("Input the number of elements in your array: ");
    int arraySize = Convert.ToInt32(Console.ReadLine());
    while (arraySize <= 0)
    {
        Console.Write("Try again with your number > 0: ");
        arraySize = Convert.ToInt32(Console.ReadLine());
    }

    string [] userArray = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.WriteLine($"Input your word №{i+1}:");
        userArray[i] = Console.ReadLine();
        while (userArray[i] == "")
        {
            Console.WriteLine("Try again. You must type something:");
            userArray[i] = Console.ReadLine();
        }
    }
    return userArray;
}

