// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
// int Quarter(int x, int y)
// {
//     if ( x>0 && y>0) return 1;
//     if ( x<0 && y>0) return 2;
//     if ( x<0 && y<0) return 3;
//     if ( x>0 && y<0) return 4;
//     return 0000000;
// }

// Console.WriteLine("insert coords");
// Console.WriteLine("x - ");
// int xcoord = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("y - ");
// int ycoord = Convert.ToInt32(Console.ReadLine());

// int quart = Quarter(xcoord,ycoord);
// string result = quart > 0? $"quarter is {quart}": "fucku";
// Console.WriteLine(result);   
string coordrange(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;

}  
int number = Convert.ToInt32(Console.ReadLine());
// if (number  <= 0 || number > 4)
// {
//     Console.Write("fail");
// }
// else
// {
//     Console.Write($"yseyhatsgood{number}");
// }
string result = coordrange(number);

Console.Write(result != null? result : "fail");