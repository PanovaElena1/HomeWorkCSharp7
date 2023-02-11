// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//17 -> такого числа в массиве нет


var arr = Generate2DArray(3, 4);
Print2DArray (arr);

Console.WriteLine("Введите индекс строки");
int FirstNumb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца");
int SecondNumb = Convert.ToInt32(Console.ReadLine());
{
    if (FirstNumb < arr.GetLength(0) && SecondNumb < arr.GetLength(1)) Console.WriteLine(arr[FirstNumb, SecondNumb]);
    else Console.WriteLine ("такого числа в массиве нет");
}

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];

    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}