namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pyramid
            Console.Write("Enter the number of levels for the pyramid: ");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("Please enter a positive integer: ");
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
