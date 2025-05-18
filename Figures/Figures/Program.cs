using System.Drawing;

namespace Figures
{
    public class Program
    {
        static void Main()
        {
            try
            {
                string[] input = Console.ReadLine()!.Split();

                string figureType = input[0].ToLower();
                string figureColor = input[1];
                int[] parameters = input.Skip(2).Select(int.Parse).ToArray();

                ConsoleColor color = Enum.Parse<ConsoleColor>(figureColor, true);

                if (figureType == "square")
                {
                    if (parameters.Length > 1 || parameters.Length == 0)
                    {
                        throw new Exception("Ivalid parameters for square!");
                    }
                    Square square = new Square(parameters[0], color);

                    Console.WriteLine(square.Draw());
                    Console.ResetColor();
                    square.Formula();
                }
                else if (figureType == "rectangle")
                {
                    if (parameters.Length <= 1)
                    {
                        throw new Exception("Ivalid parameters for rectangle!");
                    }
                    Rectangle rectangle = new Rectangle(parameters[0], parameters[1], color);

                    Console.WriteLine(rectangle.Draw());
                    Console.ResetColor();
                    rectangle.Formula();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
