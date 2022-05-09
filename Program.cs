using System;

namespace AgeCounter
{
    public static class Program
    {
        static void Main(string[] arr)
        {
            int age = AgeCounter.Age(new int[] { 5, -2, 3 });
            if (age <= 0)
            {
                Console.WriteLine("The ages not may be negative number");
            }
            else if (age >= 1 & age < 18)
            {
                Console.WriteLine("The person is not adult");
            }
            else if (age > 18 & age < 99)
            { 
                Console.WriteLine("The person is adult");
            }
            else if (age > 100)
            {
                Console.WriteLine("The person is adult but it's to old");
            }
        }
    }
}