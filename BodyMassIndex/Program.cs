namespace BodyMassIndex
{
    internal class Program
    {
        public class BmiCalculator
        {
            public double CalculateBmi(double weight, double height)
            {
                return weight / (height * height);
            }

            public string GetStatus(double bmi)
            {
                if (bmi < 18.5)
                {
                    return "Underweight";
                }
                else if (bmi >= 18.5 && bmi < 25.0)
                {
                    return "Normal weight";
                }
                else if (bmi >= 25.0 && bmi < 30.0)
                {
                    return "Overweight";
                }
                else
                {
                    return "Obese";
                }
            }
        }

            static void Main(string[] args)
            {
                Console.WriteLine("=== Body Mass Index (BMI) Calculator ===");
                Console.WriteLine();

                Console.Write("Enter your weight in kg (e.g., 70.5): ");
                double weight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your height in meters (e.g., 1.75): ");
                double height = Convert.ToDouble(Console.ReadLine());

                BmiCalculator calculator = new BmiCalculator();

                double bmiResult = calculator.CalculateBmi(weight, height);
                string statusResult = calculator.GetStatus(bmiResult);

                Console.WriteLine();
                Console.WriteLine($"Your BMI: {bmiResult:F2}");
                Console.WriteLine($"Status: {statusResult}");

                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
            
            }
        }
    }
