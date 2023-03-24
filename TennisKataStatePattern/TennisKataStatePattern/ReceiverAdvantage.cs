namespace TennisKataStatePattern; 
public class ReceiverAdvantage : IScoreState 
{

    private Game _game;
    public ReceiverAdvantage(Game game)
    {
        _game = game;
    }
    public string BallWinner(string winner)
    {
        if (winner == "receiver")
        {
            _game.receiverScore++;
            _game.State = _game.IsWon;
        }
        else
        {
            _game.receiverScore--;
            _game.State = _game.Deuce;
        }

        return _game.State.Score();
    }
    public string Score()
    {
        return "Advantage Receiver";
    }
}
