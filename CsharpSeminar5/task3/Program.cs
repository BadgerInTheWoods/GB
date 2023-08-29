int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min,max + 1);
    }
    return arr;
}


void printarray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1 ) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]} ");

    }
    Console.Write("]");
}

bool haveornot(int[] arr, int number)
{
    bool b = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if( arr[i] == number) b = true;
    }
    return b;
}
Random nr = new Random();
int[] array = CreateArrayRndInt(nr.Next(3,10),-9,9);
printarray(array);
Console.WriteLine(haveornot(array,4));