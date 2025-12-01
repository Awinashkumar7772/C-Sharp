namespace Assignment_Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height in inches: ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = (inches * 2.54);
            if (centimeters > 180)
            {
                Console.WriteLine("Your are tall.");
            }
            else if (centimeters > 150)
            {
                Console.WriteLine("Your are of medium height.");
            }
            else
            {
                Console.WriteLine("Your are not tall...");
            }
            
        }
    }
}
