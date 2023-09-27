Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());

if (number> 100)
{
    while (number>999)
    {
         number/=10;
    }


int result = number %10;
System.Console.WriteLine(result);
}

else if (number<100)
{
    System.Console.WriteLine("Третьей цифры нет.");
}
 