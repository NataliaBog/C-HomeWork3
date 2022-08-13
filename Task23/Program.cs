//Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Куб из чисел от 1 до " + num1 + " являются:   ");

for(int count = 1; count <num1; count++)
{
    double num2 = Math.Pow(count,3);
    Console.Write(num2 + ", ");
}
Console.WriteLine(Math.Pow(num1,3));

Console.WriteLine(); 