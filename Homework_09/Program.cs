using System;

    internal class Program
{
    static void Main(string[] args)
    {
        int numbers;
        int maximumNumber = 97;
        int numberStep = 7;

        for (numbers = 5; numbers < maximumNumber; numbers += numberStep)
        {
            Console.WriteLine(numbers);
        }
    }
}