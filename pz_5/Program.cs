using System;
{ int i;
    Console.WriteLine("Задание 1:");
    for (i = 20; i <= 100; i++)
    {
        Console.WriteLine("" + i);
    };
}
Console.WriteLine("Задание 2");
for (int i = 0; i < 6; i += 1)
{
    Console.Write($"{(char)(i + 'Е')}\t");
}
Console.WriteLine(" ");
Console.WriteLine("Задание 3");

for (int i = 0; i < 6; i++)

{

    Console.WriteLine(new string('#', 9));

};

{

    Console.WriteLine("Задание 4");

    for (int i = 0; i <= 100; i += 5)

    {

        Console.WriteLine(i);

    }
    Console.WriteLine("Задание 5");

    for (int i = 5, j = 99; Math.Abs(i - j) != 4; i++, j--)

    {

        Console.WriteLine("{0} {1}", i, j);
    }
}