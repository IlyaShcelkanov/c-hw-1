//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Clear();
Console.WriteLine("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine()!);
int count = 1;
while(count <= N)
{
    int count1 = count % 2;
    if(count1 == 0)
    {
        Console.WriteLine($"{count}");
        count++;   
    }
    else
    {
        count++;
    }
}

