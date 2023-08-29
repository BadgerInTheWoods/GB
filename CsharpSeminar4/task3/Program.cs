// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("gimme int number");
int number = Convert.ToInt32(Console.ReadLine());

int sum(int num)
{


    int multiplicant = 1;
    for (int i = 1; i <= num; i++)
    
    {
        multiplicant = multiplicant * i;
    }
    return multiplicant;



}

Console.WriteLine($"answer is {sum(number)}");
