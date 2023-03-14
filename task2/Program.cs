/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/


int digitsCounter(int number)
{
    int[] array = new int[number.ToString().Length];
    for(int i =0; i < array.Length; i++)
    {
        array[i] = number % 10;
        number /= 10;
    }
    Array.Reverse(array);

    int digitCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        digitCount += array[i]; 
    }
    return digitCount;

}

Console.WriteLine("Enter the number:");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{number} -> {digitsCounter(number)}");
