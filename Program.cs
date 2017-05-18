namespace Breakout1
{
    using Contracts;

    public class Program
    {
        public static void Main()
        {
            IGamer currentGamer = new Gamer();
            Score score = new Score(currentGamer);
            Engine engine = new Engine(score);

            engine.Run();
        }
    }
}