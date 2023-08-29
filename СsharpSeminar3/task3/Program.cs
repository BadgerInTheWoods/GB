
// Console.Write("Введите координату по ои oX для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по ои oY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по ои oX для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по ои oY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2);
 
//  Console.WriteLine($"Расстояние: {d}");
int number = Convert.ToInt32(Console.ReadLine());
if ( number > 9999 && number < 100000)
      {
        int firstnumber = number / 10000;
        int secondnumber = (number / 1000) % 10;
        int fourthnumber = (number / 10) % 10;
        int fifthnumber = number % 10;
        if (firstnumber == fifthnumber && secondnumber == fourthnumber)
        {
          Console.WriteLine(True)
        }
        else
        {
          Console.WriteLine(False)
        }
      }
      else 
      {
        Console.WriteLine("Число не пятизначное")
      }