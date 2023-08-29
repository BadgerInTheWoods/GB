
int Quarter(int x, int y)
{
    if ( x>0 && y>0) return 1;
    if ( x<0 && y>0) return 2;
    if ( x<0 && y<0) return 3;
    if ( x>0 && y<0) return 4;
    return 0000000;
}

Console.WriteLine("insert coords");
Console.WriteLine("x - ");
int xcoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y - ");
int ycoord = Convert.ToInt32(Console.ReadLine());

int quart = Quarter(xcoord,ycoord);
string result = quart > 0? $"quarter is {quart}": "fucku";
Console.WriteLine(result);     