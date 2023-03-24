namespace TennisKataStatePattern; 
public class ReceiverMatchPoint : IScoreState 
{
    private Game _game;
    public ReceiverMatchPoint(Game game)
    {
        _game = game;
    }
    public string BallWinner(string winner)
    {

        if (winner == "receiver")
        {
            _game.receiverScore=5;
            _game.State = _game.IsWon;
        }
        else if (++_game.serverScore == _game.receiverScore)
            _game.State = _game.Deuce;

        return _game.State.Score();
    }

    public string Score()
    {
        return $"{(SCORES)_game.serverScore} {(SCORES)_game.receiverScore}";
    }
}
