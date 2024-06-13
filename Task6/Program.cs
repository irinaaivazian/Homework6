namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //number's factorial
            Console.Write("Enter an integer N: ");
            int N;
            while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
            {
                Console.Write("Please enter a non-negative integer: ");
            }

            long factorial = 1;
            for (int i = 1; i <= N; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("The factorial of " + N + " is: " + factorial);
        }
    }
}
