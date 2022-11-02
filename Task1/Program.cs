// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в целую степень B.
int numA = new Random().Next(1, 10);
int numB = new Random().Next(1, 10);

Console.WriteLine("A = " + numA);
Console.WriteLine("B = " + numB);
Console.WriteLine(calculate(numA, numB));

int calculate(int numA, int numB)
{
    int result = numA;
    for (int i=1; i<numB; i++)
    {
        result = result * numA;
    }

    return result;
}