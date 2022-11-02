using System;

namespace ArraySort 
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            int[] arr = { 5, 18, 62, 12, 1, 3, 7};
            int temp;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

        }
    }
}