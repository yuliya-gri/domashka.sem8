// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 11);
}
void MultyArray(int[,] firstArray, int[,] secondArray, int[,] resultArray)
{
    for( int i = 0; i < resultArray.GetLength(0); i++)
    {
        for( int j = 0; j < resultArray.GetLength(1); j++)
        {
            int mult = 0;
            for(int k = 0; k < firstArray.GetLength(1); k++)
            {
                mult += firstArray[i, k] * secondArray[k, j];
            }
    resultArray[i, j] = mult;
        }
    }
}   
Console.WriteLine("Введите количество строк  массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] firstArray = new int[rows, cols];
Console.WriteLine("первый массив");
FillArray(firstArray);
PrintArray(firstArray);
Console.WriteLine("второй массив");
int[,] secondArray = new int[rows, cols ];

FillArray(secondArray);
PrintArray(secondArray);

int[,] resultArray = new int[ rows, cols];
Console.WriteLine("результирующий массив");
MultyArray(firstArray, secondArray, resultArray);
PrintArray(resultArray);


