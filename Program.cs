/* Написать программу, 
которая из имеющегося массива строк 
формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. */


Console.WriteLine("Привет!");
Console.WriteLine("Я учусь искать трехсимвольные строки и строить из них массивы.");
Console.Write("Введи несколько слов или цифр, чтобы мы проверили, что у меня получается: ");

string strings = Console.ReadLine();
string[] stringArray = strings.Split(' ');


// int size = stringArray.Length;
// Console.WriteLine($"{String.Join(", ",stringArray)} "); 
// Console.WriteLine($"{size} "); 