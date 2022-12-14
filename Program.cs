/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] FillArray(int[] size)
    {
    int[]array = new int[size[0]];
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(size[1], size[2]);
            if (i!=array.Length-1) Console.Write($"{array[i]}, ");
            else Console.WriteLine($"{array[i]}");
        }
    return array;
    }
int [] dataArray()
{
    int[] array = new int[3];
    Console.WriteLine("Задаем массив из случайных чисел");
    Console.Write("Укажите длину массива: ");
    array[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите нижний предел числа в массиве: ");
    array[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите верхний предел числа в массиве: ");
    array[2] = Convert.ToInt32(Console.ReadLine());
    return array;
}
int evenNumbArr(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item%2==0) count++;
    }
    return count;
}
try
{
    Console.WriteLine("Задача 1");
    int[] arrayFirstTask = FillArray(dataArray());
    Console.WriteLine($"->{evenNumbArr(arrayFirstTask)}");
}
catch (System.Exception)
{
    
    throw;
}
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int summOddNumb(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i++)
    {

        if (i%2==1) summ+=array[i];
    }
    return summ;
}
try
{
    Console.WriteLine("Задача 2");
    int[] arraySecondTask = FillArray(dataArray());
    Console.WriteLine($"->{summOddNumb(arraySecondTask)}");    
}
catch (System.Exception)
{
    throw;
}
/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
int diffMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];
    foreach (int item in array)
    {
        if (max<item) max = item;
        if (min>item) min = item;
    }
    return max-min;
}
try
{
    Console.WriteLine("Задача 3");
    int[] arrayThirdTask = FillArray(dataArray());
    Console.WriteLine($"->{diffMaxMin(arrayThirdTask)}");    
}
catch (System.Exception)
{
    
    throw;
}
/*
Задача 19 HARD - необязательная
Напишите программу, которая принимает на вход число любой размерности и проверяет, является ли оно палиндромом.
*/
string checkPalindrome(int number)
{
    int lenghtNumber = Convert.ToInt32(Math.Log10(number)) + 1;
    int cloneNumber = number;
    int reverseNumber = 0;
    for (int i = 0; i < lenghtNumber; i++)
    {
        reverseNumber += cloneNumber%10 * Convert.ToInt32(Math.Pow(10, i));
        cloneNumber /= 10;
    }
    if (number == reverseNumber) return $"Число {number} является палиндромом";
    else return $"Число {number} НЕ является палиндромом";
}
try
{
    Console.WriteLine("Задача 4");
    Console.Write("Введите число, для проверки на палиндромность: ");
    int someNumb = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(checkPalindrome(someNumb));        
}
catch (System.Exception)
{
    
    throw;
}

/*
Задача 21 HARD - необязательная
Напишите программу, которая принимает на вход координаты точек и находит расстояние между ними в N-мерном пространстве. N - задается пользователем.
*/
double getDistanse()
{
    Console.Write("Введите размерность N-мерного пространства: ");
    int nSpace = Convert.ToInt32(Console.ReadLine());
    int firstCoord = 0;
    int secondCoord = 0;
    int[][] nSpaceCoordinate = new int[2][];
    nSpaceCoordinate[0] = new int[nSpace];
    nSpaceCoordinate[1] = new int[nSpace];
    while (firstCoord<nSpace)
    {
        Console.Write($"Введите координату {firstCoord} первой точки: ");
        nSpaceCoordinate[0][firstCoord] = Convert.ToInt32(Console.ReadLine());
        firstCoord++;
    }
    while (secondCoord<nSpace)
    {
        Console.Write($"Введите координату {secondCoord} второй точки: ");
        nSpaceCoordinate[1][secondCoord] = Convert.ToInt32(Console.ReadLine());
        secondCoord++;
    }
    double powSummCoord = 0;
    for (int i = 0; i < nSpace; i++)
    {
        powSummCoord += Math.Pow((nSpaceCoordinate[0][i]-nSpaceCoordinate[1][i]), 2);
    }
    return Math.Round(Math.Sqrt(powSummCoord),2);
}
try
{
    Console.WriteLine("Задача 5");  
    Console.WriteLine($"Расстояние между Вашими точками = {getDistanse()}");  
}
catch (System.Exception)
{
    
    throw;
}