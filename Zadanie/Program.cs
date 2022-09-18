// Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, что такого элемента нет.

int[,] FillArray(int[,] array, int m, int n)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

bool FindIndex(int[,] array, int m, int n, int number)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (array[i, j] == number)
            {
                Console.WriteLine($"Число имеет индекс: {i}, {j}");
                return true;
            }   
        }    
    }
    Console.WriteLine("Такого элемента нет");
    return false; 
}

Console.WriteLine("Задайте колличество строк в массиве:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте колличество столбцов в массиве:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
PrintArray(FillArray(array, m, n));
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
FindIndex(array, m, n, number);

