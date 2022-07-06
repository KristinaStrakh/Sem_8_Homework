/*Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.*/


/*int[,] table =
{
    {1, 2, 3, 4},
    {5, 6, 7, 8},
};

PrintArray(table);
Console.WriteLine();

for (int k = 0; k < table.GetLength(1); k++)
{

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1)-1; j++)
        {
            if (table[i, j] < table[i, j + 1])
            {
                int temp = table[i, j];
                table[i, j] = table[i, j + 1];
                table[i, j + 1] = temp;
            }

        }
    }
}
    
    PrintArray(table);

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
}*/

/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

/*int[,] number = new int[2, 3];
int min = int.MaxValue;
int indexLine = 0;


FillRandomArrayNumbers(number);
PrintArray(number);

for (int i = 0; i < number.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < number.GetLength(1); j++)
    {
        sum = sum + number[i, j];

    }
    if (sum < min)
    {
        min = sum;
        indexLine = i;
    }
}

Console.Write(indexLine+1);

void FillRandomArrayNumbers(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(-1, 10);
        }
    }

}

void PrintArray(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/


/*Задача 58: Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.*/

/*int[,] number = new int[2, 2];
int[,] numberTwo = new int[2, 2];
int[,] result = new int[2, 2];


FillRandomArrayNumbers(number);
FillRandomArrayNumbers(numberTwo);
PrintArray(number);
Console.WriteLine();
PrintArray(numberTwo);
Console.WriteLine();

for (int i = 0; i < number.GetLength(0); i++)
{ 
    
    for (int j = 0; j < number.GetLength(1); j++)
    {
        for (int k = 0; k < number.GetLength(0); k++)
        {
            result[i,j] += number[i,k] * numberTwo[k, j];
        }
    }
}

PrintArray(result);

void FillRandomArrayNumbers(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            number[i, j] = new Random().Next(-1, 10);
        }
    }

}

void PrintArray(int[,] number)
{
    for (int i = 0; i < number.GetLength(0); i++)
    {
        for (int j = 0; j < number.GetLength(1); j++)
        {
            Console.Write(number[i, j] + " ");
        }
        Console.WriteLine();
    }
}*/

/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/

/*int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int dimension1 = InputInt("Введите размерность 1: ");
int dimension2 = InputInt("Введите размерность 2: ");
int dimension3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if(dimension1 * dimension2 * dimension3 > countNumbers)
{
    Console.WriteLine("Массив слишком большой!");
    return;
}

int[,,] numbers = CreateArray(dimension1, dimension2, dimension3);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        for(int k = 0; k < numbers.GetLength(2); k++)
        {
            Console.Write($"[{i},{j},{k}] {numbers[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] CreateArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] digitValues = new int[countNumbers];
    int value = 10;
    for(int i = 0; i < digitValues.Length; i++)
        digitValues[i] = value++;

    for(int i = 0; i < digitValues.Length; i++)
    {
        int randomIndex = new Random().Next(0, digitValues.Length);
        int temp = digitValues[i];
        digitValues[i] = digitValues[randomIndex];
        digitValues[randomIndex] = temp;
    }

    int valueIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = digitValues[valueIndex++];
            }
        }
    }

    return array;
}*/

/*Задача 62: Заполните спирально массив 4 на 4.*/

Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while(value <= n * n)
{
    array[i, j] = value;
    if(i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++value;
}

for(int x = 0; x < array.GetLength(0); x++)
{
    for(int y = 0; y < array.GetLength(1); y++)
    {
        Console.Write(array[x, y] + " ");
    }
    Console.WriteLine();
}
