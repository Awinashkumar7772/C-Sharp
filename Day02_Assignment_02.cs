namespace Day02_Assignment_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Type Conversion Demo -----");

            // 1. Implicit Conversion (automatic widening conversion)
            int intNum = 10;
            double doubleNum = intNum;
            Console.WriteLine("Implicit Conversion (int → double): " + doubleNum);

            // 2. Explicit Conversion (casting)
            double price = 99.75;
            int roundedPrice = (int)price;
            Console.WriteLine("Explicit Conversion (double → int): " + roundedPrice);

            // 3. Convert class usage
            string ageString = "25";
            int age = Convert.ToInt32(ageString);
            Console.WriteLine("String → int using Convert: " + age);

            // 4. Parsing
            string salaryString = "45000";
            int salary = int.Parse(salaryString);
            Console.WriteLine("String → int using Parse: " + salary);

            // 5. ToString() conversion
            bool flag = true;
            string flagString = flag.ToString();
            Console.WriteLine("bool → string using ToString(): " + flagString);

            // 6. Char to int
            char letter = 'A';
            int asciiValue = (int)letter;
            Console.WriteLine("char → int (ASCII value): " + asciiValue);
        }
    }
}
