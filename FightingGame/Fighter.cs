using System;
public class Fighter
{
    public string Name {get;protected set;} = "bob";
    public double MaxHp {get;protected set;}
    private double hp;
    public double Hp 
    {
        get => hp;
        set => hp = Math.Max(value, 0);
    }
    public int Str {get;protected set;}
    public int Wis {get;protected set;}
    public double Def {get;protected set;}
    public bool Invulnerable {get;protected set;} = false;
    public double Cc {get;protected set;}
    public double Cd {get;protected set;}
    public double Dodge {get;protected set;}
    public double DmgMult {get;protected set;} = 1; //Damage bonuses from weapons, skills or spells
    public double TempDmgMult {get;protected set;} = 1; //Temporary Damage bonuses from skills or spells
    private double tDmg;
    public double Tdmg //Total Damage
    {
        get => tDmg;
        set => tDmg = Math.Max(value, 0);
    }
    public virtual void Damage(Fighter target)
    {
        target.Hp -= Tdmg;
    }
    public double ShowHp()
    {
        return Math.Round(Hp);
    }
}
