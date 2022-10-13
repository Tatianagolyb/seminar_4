// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

int GetSum (int A)
{
    int sum =0;
    int a1=A%10;
    int a2 =A/10%10;
    int a3 =A/100%10;
    int a4 =A/1000;

    for (int i=0; i<=A; i++)
    {
        sum= a1+a2+a3+a4;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int n= int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(n));
