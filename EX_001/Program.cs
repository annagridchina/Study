

//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("start"); //начало

int a = 120;
int b = 110;
int c = 130;
int max = a;
if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}

Console.WriteLine(max);

Console.WriteLine("end");
