namespace Assignment_Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int nearest = ((number + 500) / 1000) * 1000;
            Console.WriteLine("Here is the ans: " + nearest);
        }
    }
}
