// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void Main()
{
    int[,] arr = new int[5,6];
    arr=GetArray(arr);
    PrintArray(arr);
    Console.WriteLine();
    int[,] newArray = SortRows(arr);
    PrintArray(newArray);
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


int[,] SortRows(int[,] arr)
{
    int [,] result= new int[arr.GetLength(0), arr.GetLength(1)];
    for(int i=0; i<arr.GetLength(0); i++)
    {
        int[] temp = new int[6];
        for(int j=0; j<arr.GetLength(1); j++)
        {
            temp[j]=arr[i,j];
        }
        Array.Sort(temp);
        Array.Reverse(temp);
        for(int j=0; j<arr.GetLength(1); j++)
        {
            result[i,j]=temp[j];
        }
    }
    return result;
     

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
}
Main();
