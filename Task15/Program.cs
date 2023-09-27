Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
 
if (number<1||number>7)
{
    System.Console.WriteLine("Такого дня недели нет.");
}

if (number==6||number==7)
{
    System.Console.WriteLine("Выходной");
}

if (number>0&&number<6)
{
    System.Console.WriteLine("Не выходной");
}