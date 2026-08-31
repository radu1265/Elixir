public class Player
{
    public int RollDie()
    {
        Random r = new Random();
        return r.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        Random r = new Random();
        return r.NextDouble() * 100;
    }
}
