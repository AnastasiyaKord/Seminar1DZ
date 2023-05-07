// Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

{
 
    int a, b, c;
    
    int max;

    Console.WriteLine("Введите три числа : ");
 
    a = Convert.ToInt32(Console.ReadLine());
 
    b = Convert.ToInt32(Console.ReadLine());

    c = Convert.ToInt32(Console.ReadLine());

    max = a;

if (b > max) max = b;

if (c > max) max = c;

Console.WriteLine("{0} = max", max);
}

 
    