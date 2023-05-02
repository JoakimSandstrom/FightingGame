using System;
public class Fighter
{
    public string Name {get;protected set;} = "bob";
    public int MaxHp {get;protected set;}
    private double hp;
    public double Hp 
    {
        get => hp;
        protected set => hp = Math.Max(value, 0);
    }
    public int Str {get;protected set;} //Attack Damage Multiplier
    public int Wis {get;protected set;} //Spell Damage Multiplier
    public double Def {get;protected set;} //Damage Reduction Multiplier
    public bool Invulnerable {get;set;} = false; //Takes No Damage If True
    public double Cc {get;protected set;} //Crit Chance
    public double Cd {get;protected set;} //Crit Damage Multiplier
    public double Dodge {get;protected set;} //Chance To Not Take Damage
    public double DmgMult {get;protected set;} = 1; //Damage bonuses from weapons, skills or spells
    public double TempDmgMult {get;protected set;} = 1; //Temporary Damage bonuses from skills or spells

    public void Damage(Fighter target, double amount) //Deal Damage And Display The Amount Dealt If The Target Is Not Invulnerable
    {
        if (target.Invulnerable) Console.WriteLine("The Target Was Invulnerable And Took No Damage");
        else 
        {
            target.Hp -= amount;
            Console.WriteLine("You Dealt "+amount+" Points Of Damage");
        }
    }
    
    public void Heal(int heal)
    {
        Hp += heal;
    }
}
