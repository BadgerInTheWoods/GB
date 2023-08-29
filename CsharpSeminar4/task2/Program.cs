// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int schet(int number)
{
    if (number < 0){
        number = number * -1;
    }
    
    int count = 3;
    while (number > 999)
    {
        number = number / 10;
        count += 1;
    }
    return count;
}
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(schet(num));