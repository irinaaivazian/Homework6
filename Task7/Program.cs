namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibonacci sequence
            Console.Write("Enter an integer N: ");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
            {
                Console.Write("Please enter a positive integer: ");
            }

            int a = 0, b = 1;
            Console.Write("Fibonacci sequence: ");

            for (int i = 1; i <= N; i++)
            {
                Console.Write(a + " ");

                int next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine();
        }
    }
}
