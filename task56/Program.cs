// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void Main()
{
    int[,] ourArr = new int[5,3];
    GetArray(ourArr);
    PrintArray(ourArr);
    SumOfRows(ourArr);
}

int[,] GetArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void SumOfRows(int[,]arr)
{
    int tempSum=0;
    int rowMin=0;
    for(int i=0; i<arr.GetLength(0); i++)
    {
        int currRowSum=0;
        for(int j=0; j<arr.GetLength(1); j++)
        {
            currRowSum+=arr[i,j];
        }
        if(i==0)
        {
            tempSum=currRowSum;
        }
        else if(currRowSum<tempSum)
        {
            tempSum=currRowSum;
            rowMin=i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {++rowMin} строке");
}
Main();
