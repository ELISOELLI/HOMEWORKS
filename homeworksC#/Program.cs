//task2 seminar1 C#
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите два числа, чтобы узнать какое из двух чисел больше");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b) {Console.WriteLine("Первое введенное число больше второго: " + a + " - max; " + b + " - min.");}
else {Console.WriteLine("Второе введенное число больше первого: " + b + " - max; " + a + " - min.");}


//task4 seminar1 C#
/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine("Введите три числа, чтобы узнать какое из трех чисел максимальное");
int a = int.Parse(Console.ReadLine()); 
int b = int.Parse(Console.ReadLine()); 
int c = int.Parse(Console.ReadLine());

if (a > b && a > c) {Console.WriteLine(a + " максимальное число");}
else if (b > a && b > c) {Console.WriteLine(b + " максимальное число");}
else {Console.WriteLine(c + " максимальное число");}


//task6 seminar1 C# //
//* Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет */

Console.WriteLine("Введите число, чтобы узнать является ли число чётным:");
int a = int.Parse(Console.ReadLine());

if (a % 2 == 0) {Console.WriteLine("Число " + a + " четное.");}
else {Console.WriteLine("Число " + a + " нечетное.");}

// task8 seminar1 C#
//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8 

Console.WriteLine("Введите число, чтобы узнать все чётные числа данного числа:");
int a = int.Parse(Console.ReadLine());

if (a < 0) {
    Console.WriteLine("Введенное отрицательное число, попробуйте еще раз и введите положительное число.");
}
else if (a == 0 || a == 1) {Console.WriteLine("У данного чисела нет четных чисел");}
{
    int count = 1;
    while (count <= a)
    {
        if (count % 2 == 0)
        {
            Console.WriteLine(count);
        }
        count++;
    }
}    


//TASK10 SEMINAR2 C#
//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Enter a three-digit number: ");
string? numberStr = Console.ReadLine();

Console.WriteLine($"The second number - {numberStr[1]}");


//TASK13 SEMINAR2 C#
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Enter number: ");
string? strNumber = Console.ReadLine();
if (strNumber.Length < 3)
{
    Console.WriteLine("There is no third number");
}
else
{
    Console.WriteLine($"The third digit of a given number -> {strNumber[2]}");
}


//TASK15 SEMINAR2 C#
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter the number of the day of the week: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

void CheckNumberDay(int numberDay)
{
    if (numberDay >= 1 && numberDay < 6)
    {
        Console.WriteLine("Working day");
    }
    else if (numberDay == 6 || numberDay == 7)
    {
        Console.WriteLine("Weekend");
    }
    else
        Console.WriteLine("This day of the week does not exist");
}

CheckNumberDay(numberDay);


//TASK 19 SEMINAR3 C#
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> дa

string Palindrome(string str)
{
    if (str[0] == str[4] && str[1] == str[3]);
    {
        string yes = "ДА";
        return yes;
    }
    string no = "НЕТ";
    return no;
}

Console.WriteLine("Введиет пятизначное число: ");
string? str = Console.ReadLine();
Console.WriteLine($"Введеное число палиндром: {Palindrome(str)}");


//TASK21 SEMINAR3 C#
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double CalcDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
}

Console.Clear();
Console.WriteLine("Ведите координаты точки A, в 3D пространстве: ");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
int az = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите координаты точки B, в 3D пространстве: ");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());
int bz = int.Parse(Console.ReadLine());

Console.WriteLine($"Растояние между точкой A и B равно {Math.Round(CalcDistance(ax, ay, az, bx, by, bz), 2)}"); 


//TASK 23 SEMINAR3 C#
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
// Решение №1 Простое.
int cube = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= cube; i++)
{
    Console.Write(Math.Pow(i, 3) + " ");
}

Console.WriteLine();

// Решение №2 Через метод.
void Cube(int[] cube){
    for (int i = 0; i < cube.Length; i++)
    {
        cube[i] = Convert.ToInt32(Math.Pow(i, 3));
    }
}

void PrintArry(int[] coll){
  for (int i = 1; i < coll.Length; i++)
  {
    Console.Write(coll[i]+ " ");
  }
} 

int[] arry = new int[cube+1];
Cube(arry);
PrintArry(arry);


//TASK25 LESSON4 C#
//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double myPow( double a, int b) {
  double result = 1;
  for (int i = 1; i <= b; i++)
  {
    result = result * a;
  }
  return result;
}

Console.WriteLine(myPow(3, 5));
Console.WriteLine(myPow(2, 4));


//TASK27 LESSON4 C#
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int digitsSum(int number)
{
    return number.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).Sum();
}
;

string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine(digitsSum(number));
}
else
{
    Console.WriteLine("Введите целое число");
}
;


//TASK29 LESSON4 C#
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] generate8Array()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

Console.WriteLine($"[{String.Join(", ", generate8Array())}]");


//TASK34 SEMINAR 5 C#

// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] generateArray(int length, int min=-100, int max=101)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}


string prettyPrintArray(int[] array)
{
    return ($"[{String.Join(", ",array)}]");
}

int countEvenElements(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result++;
    }
    return result;
}
;

Console.Write("Введите длину случайного массива:");
if (!int.TryParse(Console.ReadLine(), out int length))
{
  Console.Write("Неправильный ввод");
} else
{
int[] array = generateArray(length, 100, 1000);
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Количество чётных чисел в массиве: ");
Console.WriteLine(countEvenElements(array));
} 


//TASK 36 SEMINAR LESSON 5 C#

// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] generateArray(int length, int min=-100, int max=101)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

string prettyPrintArray(int[] array)
{
    return ($"[{String.Join(", ",array)}]");
}

int sumOddPositions(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
            result+=array[i];
    }
    return result;
}
;

Console.Write("Введите длину случайного массива:");
if (!int.TryParse(Console.ReadLine(), out int length))
{
  Console.Write("Неправильный ввод");
} else
{
int[] array = generateArray(length);
Console.Write("Случайный массив: ");
Console.WriteLine(prettyPrintArray(array));
Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
Console.WriteLine(sumOddPositions(array));
}


//TASK38 LESSON 5 C#

//  Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] generateRealNumberArray(int length, int min = -100, int max = 100)
{
    double[] result = new double[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().NextDouble() * new Random().Next(min, max);
    }
    return result;
}

string prettyPrintArray(double[] array)
{
    return ($"[{String.Join(", ", array)}]");
}

double findMinMaxDelta(double[] array)
{
    int minIndex = 0;
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxIndex])
            maxIndex = i;
        if (array[i] < array[minIndex])
            minIndex = i;
    }
    return array[maxIndex] - array[minIndex];
}
;

Console.Write("Введите длину случайного массива:");
if (!int.TryParse(Console.ReadLine(), out int length))
{
    Console.Write("Неправильный ввод");
}
else
{
    double[] array = generateRealNumberArray(length, 0, 100);
    Console.Write("Случайный массив: ");
    Console.WriteLine(prettyPrintArray(array));
    Console.Write("Разница между максимальным и минимальным элементами массива: ");
    Console.WriteLine(findMinMaxDelta(array));
    // Console.WriteLine(findMinMaxDelta(new double[]{3, 7, 22, 2, 78}));

}

//TASK41 SEMINAR,LESSON 6 C#
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[m];

void InputNumbers(int m)
{
for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(m);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");


//TASK43 SEMINAR LESSON 6 C#
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("Введите значения b1, k1, b2, k2");
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
double xIntersection = 0;
double yIntersection = 0;
if (b1 == b2 & k1 == k2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");
else 
{
    xIntersection = (b2 - b1)/(k1 - k2);
    yIntersection = k1*xIntersection + b1;
    Console.WriteLine("точка пересечения "+"("+xIntersection+";" +yIntersection+ ")");
}


// TASK3 SEMINAR 6 C# (additional-доп.задача)
// Задайте двумерный массив со случайными числами от -10 до 10.
//Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.)

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] generate2dArray(int height = 4, int width = 3, int min = -10, int max = 11)
{
    int[,] result = new int[height, width];
    Random rnd = new Random();
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.Next(min, max);
        }
    }
    return result;
}

string prettyPrint2dArray(int[,] array)
{
    string result = "";

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result += array[i, j] + " ";
        }
        result += "\n";
    }
    return result;
}

int sumOfDiagonal(int[,] array)
{
    int sum = 0;
    int limiter =
        (array.GetLength(0) < array.GetLength(1)) ? array.GetLength(0) : array.GetLength(1);
    for (int i = 0; i < limiter; i++)
    {
        sum += array[i, i];
    }
    return sum;
}

int[,] testArray = new int[,] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
int[,] randomArray = generate2dArray();

Console.WriteLine("Тестовый массив: ");
Console.WriteLine(prettyPrint2dArray(testArray));
Console.WriteLine($"Сумма чисел на главной диагонали: {sumOfDiagonal(testArray)}");

Console.WriteLine("Случайный массив: ");
Console.WriteLine(prettyPrint2dArray(randomArray));
Console.WriteLine($"Сумма чисел на главной диагонали: {sumOfDiagonal(randomArray)}");


//TASK47 SEMINAR 7 C#
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t ");
        }
        Console.WriteLine();
    }
}


//TASK50 SEMINAR 7 C#
//  Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
  
int[,] array = new int[3, 4];
 
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(10);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
        }
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool f = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (number == array[i, j]) { f = true; };
        
                }
            }
            if (f)
                for(int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if(array[i,j] == number)
                    {
                        Console.WriteLine("Массив содержит число, его индекс: ({0},{1})", i, j);
                    }
                }
            }
            else
                Console.WriteLine("Такого числа в массиве нет");


//TASK 52 SEMINAR 7 C#
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] Array = new int[3,4];
 
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Array[i, j] = random.Next(10);
                    Console.Write(Array[i, j] + "\t");
                }
                Console.WriteLine();
}
Console.WriteLine("Найдем среднее арифметическое элементов в каждом столбце:");
for (int j = 0; j < Array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        sum += Array[i, j];
    }
    Console.Write($"{ sum / Array.GetLength(0)} ");
}
Console.ReadLine();


//TASK 54 SEMINAR 8 C#
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine($"\nОтсортированный массив: ");
OrderArrayLines(array);
WriteArray(array);

void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray(int[,] array)
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


//TASK 56 SEMINAR 8 C#
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine($"\nВведите размер массива m x n и диапазон случайных значений:");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine} - строкa с наименьшей суммой ({sumLine}) элементов ");


int SumLineElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

//TASK 58 SEMINAR 8 C#
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("ЗДРАВСТВУЙТЕ!");
Console.WriteLine("\n Задача 58");
int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5); //Для увеличения размера чисел в матрицах поменять число 5 на большее
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int size = InputInt("размерность матриц: ");
int[,] matrixA = new int[size, size];
int[,] matrixB = new int[size, size];
FillArrayRandomNumbers(matrixA);
FillArrayRandomNumbers(matrixB);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Матрица - А");
PrintArray(matrixA);
Console.WriteLine();
Console.WriteLine("Матрица - В");
PrintArray(matrixB);
Console.WriteLine();
Console.WriteLine("Произведение матриц А*В");
PrintArray(matrixC);


//TASK 60 SEMINAR 8 C#
//  ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,0,1)
// 34(0,1,0) 41(0,1,1)
// 27(1,0,0) 90(1,0,1)
// 26(1,1,0) 55(1,1,1)

int deep1 = InputInt("Введите размерность 1: ");
int deep2 = InputInt("Введите размерность 2: ");
int deep3 = InputInt("Введите размерность 3: ");
int countNums = 89;
 Console.WriteLine();

if (deep1 * deep2 * deep3 > countNums)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNums = Create3DMassive(deep1, deep2, deep3);

for (int i = 0; i < resultNums.GetLength(0); i++)
{
    for (int j = 0; j < resultNums.GetLength(1); j++)
    {
        for (int k = 0; k < resultNums.GetLength(2); k++)
        {
            Console.Write($"{resultNums[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
    
}


int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] values = new int[countNums];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}


int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

//TASK 62 SEMINAR 8 C#
//Доп. задача .Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

Console.WriteLine("HELLO !");
Console.WriteLine("\n Задача 62");
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[,] nums = new int[size, size];

int num = 1;
int i = 0;
int j = 0;

while (num <= size * size)
{
    nums[i, j] = num;
    if (i <= j + 1 && i + j < size - 1)
        ++j;
    else if (i < j && i + j >= size - 1)
        ++i;
    else if (i >= j && i + j > size - 1)
        --j;
    else
        --i;
    ++num;
}

PrintArray(nums);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

