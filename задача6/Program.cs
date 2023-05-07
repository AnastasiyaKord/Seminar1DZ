// Напишите программу, которая на вход принимает число и выдает, является ли число четным 
// (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

{
 
int a;
 
Console.WriteLine("Введите число : ");
 
a = Convert.ToInt32(Console.ReadLine());
 
 if (a % 2 == 0)
 
    {
 
        Console.WriteLine("Введенное число является четным");
 
        Console.ReadLine();
 
    }
 
else
 
    {
 
        Console.WriteLine("Введенное число нечетное");
 
        Console.ReadLine();
 
    }
}