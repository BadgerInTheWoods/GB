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

int[] viseversa(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] != 0) arr[i] = arr[i] * -1;
    }
    return arr;
}

Random nr = new Random();
int[] array = CreateArrayRndInt(nr.Next(3,10),-9,9);
printarray(array);
int[] vv = viseversa(array);
printarray(vv);