Console.WriteLine("Fibonacci");
Console.WriteLine("********");
Console.Write("Fill in a number:");

int Number = Convert.ToInt32(Console.ReadLine());

int first = 0;
int second = 1;
int third;

Console.WriteLine();
Console.WriteLine("The fibonacci of the number " + Number);
Console.WriteLine(first);
Console.WriteLine(second);

for (int i = 0; i < Number - 2; i++)
{
    third = first + second;
    Console.WriteLine(third);

    first = second;
    second = third;
}