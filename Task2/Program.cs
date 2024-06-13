namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of natural numbers
            Console.WriteLine("Enter the number");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum of the first " + N + " natural numbers is: " + sum);
        }
    }
}
