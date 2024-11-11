Console.Write("Enter number one: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Enter number two: ");
int num2 = int.Parse(Console.ReadLine());

Console.Write("Enter number three: ");
int num3 = int.Parse(Console.ReadLine());


int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.WriteLine($"the bigest number is: {max}");