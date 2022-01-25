// See https://aka.ms/new-console-template for more information
int b,expo,i;
int result = 1;
Console.WriteLine("enter base value");
b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter exponent value");
expo = Convert.ToInt32(Console.ReadLine());
for (i = 1; i <= expo; i++)
{
    result = result * b;
}
    Console.WriteLine(result);   


