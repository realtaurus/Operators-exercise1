namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;

            int quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"I am doing operators using {a} and {b}.");
            Console.WriteLine($"The sum of 17 and 4 is {sum}.");
            Console.WriteLine($"The quotient of 17 and 4 is {quotient}.");
            Console.WriteLine($"The remainder of 17 and 4 is {remainder}.");

            
            var userInPut = Console.ReadLine();
            var radius = double.Parse(userInPut);
            Console.WriteLine(AreaOfCircle(radius));
        }
        private static double AreaOfCircle(double radius)
        {
            var area = Math.PI* Math.Pow(radius, 2);
            return area;
        }
    }
}
