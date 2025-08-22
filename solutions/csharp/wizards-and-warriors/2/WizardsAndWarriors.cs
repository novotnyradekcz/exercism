using System;

abstract class Character
{
    private string _characterType;
    
    protected Character(string characterType) => this._characterType = characterType;

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {this._characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if (target.Vulnerable())
            return 10;
        else
            return 6;
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
        if (this._preparedSpell)
            return 12;
        else
            return 3;
    }

    public void PrepareSpell() => this._preparedSpell = true;

    public override bool Vulnerable()
    {
        if (this._preparedSpell)
            return false;
        else
            return true;
    }
}
