namespace Breakout1.Contracts
{
    public interface IBrick
    {
        int PositionX { get; }

        int PositionY { get; }

        bool IsColored { get; }

        char getSymbol();

        void setInvisible();

        bool getVisibility();
    }
}