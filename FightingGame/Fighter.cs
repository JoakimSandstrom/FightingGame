using System;
public class Fighter
{
    public string? Name {get;set;}
    private double hp;
    public double Hp 
    {
        get => hp;
        set => hp = Math.Max(value, 0);
    }
    public int Str {get;set;}
    public int Wis {get;set;}
    public double Def {get;set;}
    public double Cc {get;set;}
    public double Cd {get;set;}
    public double Dodge {get;set;}
    private double tDmg;
    public double Tdmg //Total Damage
    {
        get => tDmg;
        set => tDmg = Math.Max(value, 0);
    }
    public virtual void Damage(Fighter target){}
    public double ShowHp()
    {
        return Math.Round(Hp);
    }
}
