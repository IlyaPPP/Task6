/* Задача 50. Напишите программу, которая на вход принимает позиции
элемента в двумерном массиве, и возвращает значение этого
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] array = FillArray(3, 4); // двумерный массив из функции FillArray()
Print();
ReadLine();

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

void ReadLine()                         // функция ввода числа и проверки позиции
{
    int number;
    Console.WriteLine("Введите позицию элемента");
    int.TryParse(Console.ReadLine(), out number);
    int number1 = (number / 10) - 1;
    int number2 = (number % 10) - 1;
    if (number1 < 4 && number1 >= 0)
        if (number2 < 3 && number2 >= 0)
            Console.Write($" -> {number1}, {number2}");
        else Console.Write(" -> такого числа в массиве нет");
    else Console.Write(" -> такого числа в массиве нет");
}