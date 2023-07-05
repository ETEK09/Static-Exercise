namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Fahrentheit -> Celsious: {TempConverter.FahrenheitToCelsius(32)}");
            Console.WriteLine();

            Console.WriteLine($"Celsius -> Fahrenrheit: {TempConverter.CelsiusToFahrenheit(0)}");
            Console.WriteLine();
        }
    }
}
