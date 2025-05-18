namespace Figures
{
    public class Square : Drawing
    {
        public Square(int side, ConsoleColor color)
        {
            Side = side;
            Color = color;
        }

        public int Side { get; set; }

        public override string Draw()
        {
            string output = "";
            Console.ForegroundColor = this.Color;

            for (int row = 1; row <= Side; row++)
            {
                for (int col = 1; col <= Side; col++)
                {
                    if (row == 1 || row == Side || col == 1 || col == Side)
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
            Console.WriteLine($"The face of the square is: {Side * Side}");
        }
    }
}
