namespace Assignment
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radiues of the circle");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = (double)(3.14 * (radius) * radius);
            Console.WriteLine("Here is the area of circle: " + area);

        }
    }
}
