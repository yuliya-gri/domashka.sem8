// задайте двумерный массив и напишишите программу, который упорядочит по убыванию
// элементы каждой строки двумерного массива 


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
void OrderArrayLines(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
        {
            for(int k =0; k < array.GetLength(1)-1;k++)
            {
                if( array[i, k] < array[i, k +1])
                {
                    int temp = array[i, k +1];
                    array[i, k +1] = array[i, k];
                    array[i, k] = temp;
                   
                }
                
            }
        }
    
    }
    
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Отсортированный массив: ");
Console.WriteLine();
OrderArrayLines(array);
PrintArray(array);