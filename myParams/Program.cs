using System;

class Program
{
    static void Main(string[] args)
    {
        Random r = new Random();
        Console.WriteLine("How many numbers do you want?");
        int totalNums = int.Parse(Console.ReadLine());
        int[] numbers = new int[totalNums];
        for (int j = 0; j < totalNums; j++)
        {
            numbers[j] = r.Next(1,10);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine($"Total add of the numbers array={Add(numbers)}");
        Console.WriteLine($"Total mult of the numbers array={Mult(numbers)}");

    }
    static int Add(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        return total;
    }

    static int Mult(params int[] numbers)
    {
        int total = 1;
        foreach (int number in numbers)
        {
            total *= number;
        }
        return total;
    }


}

