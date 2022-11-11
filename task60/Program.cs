// Задача 60. ...Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Main()
{
    int[,,] arr = new int[2,2,2];
    GetArray(arr);
    PrintArray(arr);
}

int[,,] GetArray(int[,,] array)
{
    int[] numbers=new int[array.GetLength(0)*array.GetLength(1)*array.GetLength(2)];
    int m=0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                int number;
                while(true)
                {
                    number=new Random().Next(10,100);
                    if(!numbers.Contains(number))
                    {
                        break;
                    }
                }
                numbers[m]=number;
                m++;
                array[i,j,k] = number;

            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            for(int k=0; k<array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i,j,k]}({i},{j},{k})");
            }
        }
    }
    Console.WriteLine();
}
Main();