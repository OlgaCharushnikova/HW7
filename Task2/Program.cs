// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void NewArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
      
    }
}

void PrintArray (int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}


void SearchElement(int[,] arr, int x)
{
    int count = 0;
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == x)
            {
                count++;
            }
        }
    }
    if (count > 0)
    {
        Console.WriteLine(x);
    }
    else
    {
        Console.WriteLine($"{x} -> такого элемента нет в массиве");
    }
   
}


Console.WriteLine("Введите размер массива: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элемент массива: ");
int x = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
NewArray(array);
PrintArray(array);
SearchElement(array, x);