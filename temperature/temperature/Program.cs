Console.Write("Enter temperature: ");
int temperature = int.Parse(Console.ReadLine());
if(temperature < 0)
{
    Console.WriteLine("Freezing weather. ");
}
else if(temperature >= 0 &&  temperature < 10)
{
    Console.WriteLine("very cold weather");
}
else if(temperature >= 10 && temperature < 20)
{
    Console.WriteLine("cold weather ");
}
else if(temperature >= 20 && temperature < 30)
{
    Console.WriteLine("normal in temp");
}
else if (temperature >= 30 && temperature < 40)
{
    Console.WriteLine("its hot");
}
else if(temperature >= 40)
{
    Console.WriteLine("its very hot");
}
