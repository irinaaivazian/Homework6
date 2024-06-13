namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prime numbers
            Console.Write("Enter the starting integer: ");
            int start;
            while (!int.TryParse(Console.ReadLine(), out start))
            {
                Console.Write("Please enter a valid integer for the start: ");
            }

            Console.Write("Enter the ending integer: ");
            int end;
            while (!int.TryParse(Console.ReadLine(), out end) || end < start)
            {
                Console.Write("Please enter a valid integer greater than or equal to the start: ");
            }

            Console.WriteLine($"Prime numbers between {start} and {end}:");
            for (int num = start; num <= end; num++)
            {
                if (IsPrime(num))
                {
                    Console.Write(num + " ");
                }
            }

            Console.WriteLine();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
