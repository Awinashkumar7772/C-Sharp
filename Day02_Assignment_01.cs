namespace Day02_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____Welcome to Medical Store _____");
            Console.WriteLine("Enter the patients age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the patients symptoms");
            string symptom = Console.ReadLine();

            string medicine = PrecribedMedicine(symptom, age);

            Console.WriteLine(medicine);

            static string PrecribedMedicine(string symptom,int age)
            {
                switch (symptom)
                {
                    case "Fever":
                        if (age < 12)
                            return "Give Paracetamol syruo 5ml twice a day";
                        else
                            return "Give Paracetamol 500mg tablet twice a day";
                    case "cold":
                        if (age < 12)
                            return "Give: Cetzine Syrup 5ml at night";
                        else
                            return "Give: Cetzine 10mg tablet at night";

                    case "headache":
                        if (age < 12)
                            return "Give: Mild pain relief syrup (5ml)";
                        else
                            return "Give: Aspirin 300mg (if no allergy)";

                    case "cough":
                        if (age < 12)
                            return "Give: Cough Syrup 5ml twice a day";
                        else
                            return "Give: Dextromethorphan Syrup 10ml twice a day";

                    default:
                        return "Symptom not recognized. Please consult a real doctor.";
                }
            }
            }

        }
    }

