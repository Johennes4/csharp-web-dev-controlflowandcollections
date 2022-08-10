using System;

namespace ArrayExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arrays!");

            int[] numArray = { 1, 1, 2, 3, 5, 8 };

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);


            }

            foreach (int num in numArray)
            {
                Console.WriteLine(num);
            }

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] % 2 != 0)
                {
                    Console.WriteLine(numArray[i]);
                }
            };
        }
    }
}
