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
  int count = 0;
  for (int i = 0;i<Array.Length;i++)
  {
    if(Array[i].Length <=3)
    count++;
  }
  string [] rezult = new string [count];
  int j = 0;
  for (int i = 0;i<Array.Length;i++)
  {
    if(Array[i].Length <=3)
    {
        rezult[j] = Array[i];
        j++;
    }
  }
  return rezult;
}

//метод вывода  массива

void printA(string [] Array2)
{
      for (int i = 0;i<Array2.Length;i++)
    {
    Console.Write($"{Array2[i]}, ");
    }
    }

printA(CheckingElements (stringArray));