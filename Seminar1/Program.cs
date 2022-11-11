/*

// Задача 1 текст задачи
Console.Write("Input first a number: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input first a number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if (n1 == quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

*/

// Написать програму, которая принимает какое то одно число,
// а на выходе показывает все целые числа от - N до N.
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current;

if(number > 0)
{
    current = - number;
}
else
{
    current = number;
    number *= -1;
}

while(current <= number)
{
    Console.Write(current + " ");
    current ++;
}
*/
// Написать программу, которая принимает на вход трехзначное число
// и на выходе показывает последнюю цифру этого числа.
/*
Console.Write("Input three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000 )
{
    int lastDigit = n % 10;
    Console.WriteLine($"Last digit of {n} is {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrent input!");
}
*/