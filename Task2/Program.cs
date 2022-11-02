// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Enter a number: ");
string num = Console.ReadLine();
Console.WriteLine(calculate(num));

int calculate(string num)
{
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
    {
        sum = sum + Convert.ToInt32(num[i].ToString());
    }
    return sum;
}
