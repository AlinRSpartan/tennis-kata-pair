namespace TennisKataStatePattern;

public interface IScoreState
{
    public abstract string BallWinner(string winner);

    public abstract string Score();
}
