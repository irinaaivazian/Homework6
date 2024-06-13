namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sum of digits
            Console.Write("Enter an integer: ");
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Please enter a valid integer: ");
            }

            int sum = 0;
            int tempNumber = Math.Abs(number);

            while (tempNumber > 0)
            {
                sum += tempNumber % 10;
                tempNumber /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
        }
    }
}
