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


// Метод выбора примера для проверки решения
string [] ChooseYourExample(string [] Array1, string [] Array2, string [] Array3)
{
    
    Console.WriteLine("Which of these examples would you like to check?");
    Console.WriteLine("1: [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine($"2: [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine($"3: [“Russia”, “Denmark”, “Kazan”]");
    Console.WriteLine($"4: your own example");
    Console.WriteLine($"Input the number of your choice:");
    string [] chosenArray = {};
    int user_choice = Convert.ToInt32(Console.ReadLine());
    if (user_choice == 1)
        chosenArray = Array1;
    else if (user_choice == 2)
        chosenArray = Array2;
    else if (user_choice == 3)
        chosenArray = Array3;
    else if (user_choice == 4)
        chosenArray = InputYourExample ();
    else
    {
        while (user_choice > 4 || user_choice <= 0)
            {
                Console.WriteLine($"Choose between 1, 2, 3, and 4:");
                user_choice = Convert.ToInt32(Console.ReadLine());
            }
    }
    return chosenArray;
}

// Метод введения пользовательского примера для проверки решения

string [] InputYourExample()
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
        userArray[i] = Console.ReadLine()!;
        while (userArray[i] == "")
        {
            Console.WriteLine("Try again. You must type something:");
            userArray[i] = Console.ReadLine()!;
        }
    }
    return userArray;
}

// Метод печати массива
void PrintArray(string [] arrayToPrint)
{
    int i = 0;
    if (arrayToPrint.Length == 1)
            Console.Write("[" + '"' + arrayToPrint[i] + '"' + "]");
    else if (arrayToPrint.Length == 0)
            Console.Write("[]");
    else
    {
        for (i = 0; i < arrayToPrint.Length; i++)
        {
            {
                if (i == arrayToPrint.Length - 1)
                    Console.Write('"' + arrayToPrint[i] + '"' + "]");
                else if (i == 0)
                    Console.Write("[" + '"' + arrayToPrint[i] + '"' + ", ");
                else
                    Console.Write('"' + arrayToPrint[i] + '"' + ", ");
            }
        }
    }
}

// Метод проверки длины элементов и создания нового массива из прошедших проверку элементов
string [] ArrayAfterCheck(string [] arrayToCheck)
{
    
    int count = 0;
    for (int i = 0; i < arrayToCheck.Length; i++)
    {
        if (arrayToCheck[i].Length <= 3)
                count ++;
    }
 
    string [] arrayAfterChecking = new string [count];
    int j = 0;
    for (int i = 0; i < arrayToCheck.Length; i++)
    {
        if (arrayToCheck[i].Length <= 3)
        {
            arrayAfterChecking[j] = arrayToCheck[i];
            j++;
        }
    }
    return arrayAfterChecking; 
}


string [] arrayToChoose1 = {"Hello", "2", "world", ":-)"};
string [] arrayToChoose2 = {"1234", "1567", "-2", "computer science"};
string [] arrayToChoose3 = {"Russia", "Denmark", "Kazan"};
string [] arrayFromUser = ChooseYourExample(arrayToChoose1, arrayToChoose2, arrayToChoose3);
Console.Write("Your array is: ");
PrintArray(arrayFromUser);
string [] arrayFinal = ArrayAfterCheck(arrayFromUser);
Console.WriteLine();
Console.Write("Your result is: ");
PrintArray(arrayFinal);
