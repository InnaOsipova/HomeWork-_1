//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число больше 1");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (number <=1)
{
    Console.WriteLine("Введите число больше 1");
    number = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Вывод списка четных чисел:  ");

while (count <= number)
{
    if ((count % 2 == 0) && (count != 0))
    {
      Console.Write(count);
      Console.Write("; "); 
    }
    count++;
}