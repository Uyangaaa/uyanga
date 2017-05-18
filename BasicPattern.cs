namespace Breakout1.Models.Patterns
{
    using System;
    using Breakout1.Contracts;

    internal class BasicPattern : IFillingPattern
    {
        public void FillWall(IWall wall)
        {
            Console.SetCursorPosition(0, 1);

            for (int row = 0; row < wall.Height; row++)
            {
                for (int column = 0; column < wall.Width; column++)
                {
                    if (column <= 1 || column >= wall.Width - 2 || row == 0 || row == wall.Height - 1)
                    {
                        wall.FilledWall[row, column] = new Brick(row, column, false);
                    }
                    else
                    {
                        wall.FilledWall[row, column] = new Brick(row, column, true);
                    }
                }
            }
        }
    }
}