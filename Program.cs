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

// проверка и учет элементов
string [] CheckingElements(string [] Array)
{
  int m = 0;
  for (int i = 0;i<Array.Length;i++)
  {
    if(Array[i].Length <=3)
    m++;
  }
  string [] rez = new string [m];
  int j = 0;
  for (int i = 0;i<Array.Length;i++)
  {
    if(Array[i].Length <=3)
    {
        rez[j] = Array[i];
        j++;
    }
  }
  return rez;
}