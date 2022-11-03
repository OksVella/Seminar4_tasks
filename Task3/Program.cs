// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
Console.Write("Enter array size: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
fillArray(array);
printArray(array);

void printArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
         Console.Write(array[i]);
         if (i < array.Length-1)
         {
            Console.Write(", ");
         }
          
    }
}

void fillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}