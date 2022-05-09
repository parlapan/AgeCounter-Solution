using System;

namespace AgeCounter
{
    public static class AgeCounter
    {
        public static int Age(int[] arr)
        {
            int age = 0;

            for (int i = 0; i < arr.Length; i++)
                age += arr[i];
            return age;
        }
    }
}