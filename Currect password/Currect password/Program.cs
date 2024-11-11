string UserName = "admin";
int Password = 123;

Console.Write("Enter UserName: ");
string nserName = Console.ReadLine();
Console.Write("Enter Password: ");
int password = int.Parse(Console.ReadLine());   

if (nserName == UserName &&  password == Password)
{
    Console.WriteLine("Welcome! ");
}
else
{
    Console.WriteLine("InCorrect Password or Username");
}