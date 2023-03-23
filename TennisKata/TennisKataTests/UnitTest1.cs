using TennisKata;

namespace TennisKataTests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("Receiver", 0, 0, "Love Fifteen")]
    [TestCase("Receiver", 1, 0, "Fifteen Fifteen")]
    [TestCase("Receiver", 3, 1, "Forty Thirty")]
    [TestCase("Receiver", 3, 2, "Deuce")]
    [TestCase("Receiver", 3, 3, "Adv. Receiver")]
    [TestCase("Server", 3, 3, "Adv. Server")]
    [TestCase("Server", 3, 3, "Deuce", false, true)]
    [TestCase("Receiver", 3, 4, "Receiver Wins!")]
    [TestCase("Receiver", 0, 3, "Receiver Wins!")]
    public void GivenWinnerAndScore_ReturnsCorrectScoreString(string winner, int serverScore, int receiverScore, string scoreOutput, bool serverAdvantage= false, bool receiverAdvantage = false)
    {
        Game game = Game.Instance;
        game.GameSetup(serverScore, receiverScore, serverAdvantage, receiverAdvantage);

        game.Play(winner);
         
        Assert.That(game.Score(), Is.EqualTo(scoreOutput));

    }

    
}