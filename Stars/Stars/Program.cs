namespace Stars
{
    public class Stars
    {

        public static void Main(string[] args)
        {

            int[,] arr = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                arr[i * 1, i * 1] = 1;
                arr[i, 4] = 1;
                arr[4, i] = 1;
                arr[i, 8 - i] = 1;

            }
            for (int i = 0; i < 9; i++)
            {
                for (int z = 0; z < 9; z++)
                {
                    if (arr[i, z] == 1)
                    {
                        Console.Write("*");
                        if (z == 8)
                        {
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                        if (z == 8)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            //-----------------------------------------------------------------------REVERSEPRİNTİNG-----------------------------------------------------------------------
            Console.WriteLine("-----Reverse-----");
            for (int i = 5; i < 9; i++)
            {
                for (int z = 0; z < 9; z++)
                {
                    if (arr[i, z] == 1)
                    {
                        Console.Write("*");
                        if (z == 8)
                        {
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                        if (z == 8)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
            for (int i = 0; i < 9; i++)
            {
                if (arr[4, i] == 1)
                {
                    Console.Write("*");
                    if (i == 8)
                    {
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.Write(" ");
                    if (i == 8)
                    {
                        Console.WriteLine();
                    }
                }
            }
            for (int i = 8; i >= 5; i--)
            {
                for (int z = 0; z < 9; z++)
                {
                    if (arr[i, z] == 1)
                    {
                        Console.Write("*");
                        if (z == 8)
                        {
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.Write(" ");
                        if (z == 8)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }

        }

    }
}
