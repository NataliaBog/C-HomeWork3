// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

Console.WriteLine("Введите 5-ти значный номер");
double num = Convert.ToInt32(Console.ReadLine());
if(9999 < num && num < 100000)
{
    int i = 0;
    double[] array = new double [5];
    double num_ms = num;

    while(i < 5)
    {
        array[i] = num_ms % 10;
        num_ms = (num_ms - (num_ms % 10)) / 10;
        i++;
    }

    double mun = 0;
    int factor = 10000;

    for(i = 0; i < 5; i++)
    {
        mun = mun + array[i] * factor;
        factor = factor / 10;
    }

    if(mun==num)
    {
        Console.WriteLine("Ваш номер - палиндром!");
    }
    else
    {
        Console.WriteLine("Ваш номер - НЕ ПАЛИНДРОМ");
    }

}
else Console.WriteLine("Ошибка номера");