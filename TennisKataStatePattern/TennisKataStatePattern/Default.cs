namespace TennisKataStatePattern;

public class Default : IScoreState
{
    private Game _game;
    public Default(Game game)
    {
        _game = game;
    }
    public string BallWinner(string winner)
    {
        if (winner.ToLower() == "server")
        {
            _game.serverScore++;
            
            if (_game.serverScore == 3) 
                _game.State = _game.ServerMatchPoint;
            
            else if (_game.serverScore == 3 && _game.receiverScore == 3)
                _game.State = _game.Deuce;
        }
        if (winner.ToLower() == "receiver")
        {
            _game.receiverScore++;

            if (_game.receiverScore == 3)
                _game.State = _game.ReceiverMatchPoint;

            else if (_game.receiverScore == 3 && _game.serverScore == 3)
                _game.State = _game.Deuce;
        }

        return _game.State.Score();
    }

    public string Score()
    {
        return $"{(SCORES)_game.serverScore} {(SCORES)_game.receiverScore}";
    }
}
