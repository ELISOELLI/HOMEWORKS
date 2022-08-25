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