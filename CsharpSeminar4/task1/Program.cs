// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("damn gimme int number");
int number = Convert.ToInt32(Console.ReadLine());

int sum (int num)
{
    int summa = 0;
    for (int i = 1; i <= num; i++)
    {
        summa += i;
    }
    return summa;
}

Console.WriteLine($"sum from 1 to number is {sum(number)}");
