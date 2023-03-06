/* Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] array = FillArray(3, 4); // двумерный массив из функции FillArray()
Print();
Average();

int[,] FillArray(int str, int col)       // функция на присвоение каждому
{                                           // эллементу массива числа
    int[,] arr = new int[3, 4];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
    return arr;
}

void Print()                             // функция вывода массива
{
    Console.WriteLine($"{array[0, 0]}, {array[0, 1]}, {array[0, 2]}, {array[0, 3]}, ");
    Console.WriteLine($"{array[1, 0]}, {array[1, 1]}, {array[1, 2]}, {array[1, 3]}, ");
    Console.WriteLine($"{array[2, 0]}, {array[2, 1]}, {array[2, 2]}, {array[2, 3]}, ");
}

void Average()                           // функция нахождения среднего арифметического
{                                        // каждого столбца массива
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ += array[j, i];
        }
        double average = Math.Round((summ / 3.0), 1);
        Console.Write($"{average}, ");
    }
}