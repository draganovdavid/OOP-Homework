namespace Figures
{
    public class Rectangle : Drawing
    {
        public Rectangle(int a, int b, ConsoleColor color) 
        { 
            SideA = a;
            SideB = b;
            Color = color;
        }

        public int SideA { get; set; }

        public int SideB { get; set; }

        public override string Draw()
        {
            string output = "";
            Console.ForegroundColor = this.Color;

            for (int row = 1; row <= SideA; row++)
            {
                for (int col = 1; col <= SideB; col++)
                {
                    if (row == 1 || row == SideA || col == 1 || col == SideB)
                        output += "* ";
                    else
                        output += "  ";
                }
                output += "\n";
            }

            return output;
        }

        public override void Formula()
        {
            Console.WriteLine($"The face of the rectangle is: {SideA * SideB}");
        }
    }
}
