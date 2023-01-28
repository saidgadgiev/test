/*
Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
    ["1234", "1567", "-2", "computer science"] -> ["-2"]
    ["Russia", "Denmark", "Kazan"] -> []
*/


// Ввести с клавиатура элементы массива

String[] InitArray(int num)
{
    string[] list = new string[num];
    for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i+1}-й элемент массива -> ");
        list[i] = Console.ReadLine()??"";
    }
    return list;
}

// Печать массива

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("\""+array[i]+"\"" + (i < array.Length-1 ?", ":""));
    }
    Console.Write("]");
}    

// Перебор элементов в массиве и проверка 
// количества символов в массиве удовлетворяющее условию задачи
int SimvolArray(string[] array) 
{
    int maxElements = 3;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
	    if(array[i].Length <= maxElements){
		    count++;
	    }   
    }
    return count;
}
//  Создание второго  массива из сущ массива удовлетворяющее условию задачи
String[] FinalArray(string[] array, int count)
{
    string[] arr = new string[count]; // Создает второй пустой массив
    int maxElements = 3;
    int j = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= maxElements) // условиче чтоб кол символов не превышало 3
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}

Random rnd = new Random();
int num = rnd.Next(3,10); // Случайное число для размера массива
Console.WriteLine($"Длинна массива будет равна {num} эле. ");
string[] array = InitArray(num);

PrintArray(array);
int count = SimvolArray(array);
Console.Write(" -> ");
PrintArray(FinalArray(array, count));


