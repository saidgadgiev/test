// Ввести размер массива

int CorrectNumber(string message)
{
    bool isCorrect = false;
    int result = 0;
    while(! isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
        else Console.WriteLine("Enter correct number");
    }
    return result;
}

// Получить массив из случайных чисел

String[] InitArray(int num)
{
    string[] list = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива -> ");
        list[i] = Console.ReadLine();
        // Console.WriteLine(list[i]);
    }
    // Console.Write("]");
    return list;
}

// Печать массива

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + (i < array.Length-1 ?", ":""));
    }
    Console.Write("]");
}    

int num = CorrectNumber("Введите длинну строкового массива не больше 10 -> ");
string[] array = InitArray(num);
PrintArray(array);