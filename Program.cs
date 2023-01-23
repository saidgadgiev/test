List<String> list = new List<String>();
list.Add(Console.ReadLine());
list.Add("world");
list.Add("!");
Console.WriteLine(list[0]);


// Ввести размер массива

// int CorrectNumber(string message)
// {
//     bool isCorrect = false;
//     int result = 0;
//     while(! isCorrect)
//     {
//         Console.Write(message);
//         if (int.TryParse(Console.ReadLine(), out result)) isCorrect = true;
//         else Console.WriteLine("Enter correct number");
//     }
//     return result;
// }

// // Получить массив из случайных чисел

// Array[] InitArray(int num)
// {
//     List<String> list = new List<String>();
//     Console.Write("[");
//     for (int i = 0; i < num; i++)
//     {
//         list.Add(Console.ReadLine());
//     }
//     Console.Write("]");
//     return list;
// }


// int num = CorrectNumber("Enter a number -> ");
// Array[] array = InitArray(num);