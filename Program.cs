using System;

namespace TemplatePattern
{
    public abstract class Game
    {
        protected abstract void StartGame();
        protected abstract void RunGameRules();
        protected abstract void EndGame();

        protected readonly int NumberOfPlayers;

        protected Game(int numberOfPlayers)
        {
            this.NumberOfPlayers = numberOfPlayers;
        }
        public void LetsPlay()
        {
            StartGame();
            RunGameRules();
            EndGame();
        }
    }

    public class Basketball : Game
    {
        public Basketball(int numberOfPlayers) : base(numberOfPlayers)
        {
        }

        protected override void EndGame()
        {
            Console.WriteLine("Game ended");
        }

        protected override void RunGameRules()
        {
            Console.WriteLine("Game is running");
        }

        protected override void StartGame()
        {
            Console.WriteLine("Game started");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            new Basketball(2).LetsPlay();
        }
    }
}
