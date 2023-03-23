namespace TennisKata;

public class Player
{
    public int Score = 0;
    public bool Advantage = false;
    public bool Winner = false;
    public bool Deuce = false;
    public Player() { }

    public void ToggleAdvantage()
    {
        if (Advantage) Advantage = false;
        else Advantage = true;
    }

    public void AddPoint()
    {
        if(!Advantage) Score++;
        else Winner = true;

        if (Score == 4 && !Deuce) Winner = true;


    }

    public void ToggleDeuce()
    {
        if (Deuce) Deuce = false;
        else Deuce = true;
    }
}
