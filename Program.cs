

//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("start"); //начало

int a = 44;
int b = 5;
int c = 78;
int max = 0;
if (a < b)
{
    max = b;
}
if (b < c)
{
    max = c;
}
else
{
    max = a;
};
 if (a < c)
 {
    max = c;
 }
Console.WriteLine(max);

Console.WriteLine("end");
