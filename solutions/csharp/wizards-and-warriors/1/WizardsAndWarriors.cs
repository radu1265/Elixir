abstract class Character
{
    private string _chType;
    protected Character(string characterType)
    {
        _chType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable()
    {
        return false;
    }

    public override string ToString()
    {
        return $"Character is a {_chType}";
    }
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        return target.Vulnerable() ? 10 : 6;
    }
}

class Wizard : Character
{
    private bool _preparedSpell = false;
    
    public Wizard() : base("Wizard")
    {
    }

    public override int DamagePoints(Character target)
    {
        return _preparedSpell ? 12 : 3;
    }

    public void PrepareSpell()
    {
        _preparedSpell = true;
    }

    public override bool Vulnerable()
    {
        return !_preparedSpell;
    }
}
