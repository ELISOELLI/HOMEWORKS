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
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
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
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Enter a three-digit number: ");
string? numberStr = Console.ReadLine();

Console.WriteLine($"The second number - {numberStr[1]}");


//TASK13 SEMINAR2 C#
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
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
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
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