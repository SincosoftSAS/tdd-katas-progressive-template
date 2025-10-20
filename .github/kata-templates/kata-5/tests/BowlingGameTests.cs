using Xunit;

namespace BowlingGame.Tests
{
    public class GameTests
    {
        private Game game;

        public GameTests()
        {
            game = new Game();
        }

        [Fact]
        public void TestGutterGame()
        {
            // Ejemplo: 20 tiradas con 0 pines = 0 puntos
            RollMany(20, 0);
            Assert.Equal(0, game.Score());
        }

        [Fact]
        public void TestAllOnes()
        {
            // Ejemplo: 20 tiradas con 1 pin cada una = 20 puntos
            RollMany(20, 1);
            Assert.Equal(20, game.Score());
        }

        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                game.Roll(pins);
            }
        }
    }
}