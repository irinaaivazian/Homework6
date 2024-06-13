namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vowels count
            Console.Write("Enter a string: ");
            string input = Console.ReadLine().ToLower();

            int vowelCount = 0;
            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine("Number of vowels: " + vowelCount);
        }
    }
}
