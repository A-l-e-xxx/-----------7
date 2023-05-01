/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 m = 3, n = 4.
 0,5 7 -2 -0,2
 1 -3,3 8 -9,9
 8 7,8 -7,1 9


Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"m = {m}, n = {n}.");

double[,] array = new double[m, n];

CreateArrayDouble(array);

WriteArray(array);

Console.WriteLine();

void CreateArrayDouble(double[,] array)
{
  for (int i = 0; i < m; i++)
  {
    for (int j = 0; j < n; j++)
    {
      array[i, j] = new Random().NextDouble() * 20 - 10;
    }
  }
}

void WriteArray (double[,] array){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        double alignNumber = Math.Round(array[i, j], 1);
        Console.Write(alignNumber + " ");
      }
      Console.WriteLine();
  }
}
*/


/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет


int m = 3;
int n = 4;
Console.Write("Введите номер строки: ");
int h = int.Parse(Console.ReadLine());
Console.Write("А теперь номер столбца: ");
int w = int.Parse(Console.ReadLine());


int[,] array = new int[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i,j] = new Random().Next(0, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine("");
}

if (h <= m && w <= n){  
    Console.WriteLine($"Значение: {array[h-1,w-1]}");
}
else {
    Console.WriteLine($"{h} {w} -> попробуйте еще раз");
}
*/

/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


int m = 3;
int n = 4;

double mas = 0;
double[,] array = new double[m,n];
string res = "";

for(int i = 0; i < m; i++){
    mas = 0;
    for (int j = 0; j < n; j++){
        array[i,j] = new Random().Next(0, 10);
        Console.Write($"{array[i,j]} ");
        mas += array[i,j];
    }
    res += string.Format("{0:f1} ", mas/m);
    Console.WriteLine();
}

Console.WriteLine($"Среднее арифметическое каждого столбца: {res}");
*/