/* Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] array = FillArray(3, 4); // двумерный массив из функции FillArray()


double[,] FillArray(int str, int col)       // функция на присвоение каждому
{                                           // эллементу массива вещественного числа
    double[,] arr = new double[3, 4];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = Convert.ToDouble(new Random().Next(-99, 100) / 10.0);
        }
    }
    return arr;
}

Console.WriteLine($"{array[0, 0]}, {array[0, 1]}, {array[0, 2]}, {array[0, 3]}, ");
Console.WriteLine($"{array[1, 0]}, {array[1, 1]}, {array[1, 2]}, {array[1, 3]}, ");
Console.WriteLine($"{array[2, 0]}, {array[2, 1]}, {array[2, 2]}, {array[2, 3]}, ");
