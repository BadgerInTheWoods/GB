// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void Fillar(int[] array)
{
    var Rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Rand.Next(2);
    }
}
int[] ar = new int[8];
void printar(int[] array){
    int i = 0;
    while(i < array.Length){
        Console.Write($"{array[i]} ");
        i++;
    }
}
Fillar(ar);
printar(ar);
// int[] array = new int[8]; // 0 1 2 3 4 5 6 7

// int[] array1 = new int[8] { 5, 7, 8, 5, 23, 87, -5, 4 };
// int[] array2 = new int[] { 5, 7, 8, 5, 23, 87, -5, 4 };
// int[] array3 = { 5, 7, 8, 5, 23, 87, -5, 4 };

// var array4 = new int[8];

// array[6] = 6456;
// array[2] = 34;



// // PrintArray
// for (int i = 1; i < array.Length; i++) // 8
// {
//     Console.Write(array[i] + " ");
// }