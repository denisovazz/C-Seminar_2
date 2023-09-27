Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine());
int result = number/10%10;
if (number>=100&&number<1000)
{
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("Введено не трёхзначнле число!");
}