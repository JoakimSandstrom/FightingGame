using System;
public class Paladin : Player
{
    Random rng = new Random();
    public Paladin()
    {
        MaxHp = 120;
        Hp = 120;
        Str = 15;
        Wis = 10;
        Def = 0.1;
        Cc = 0;
        Cd = 2;
        Dodge = 0;

        SpellName1 = "Smite";
        SpellName2 = "Regenerate";
        SpellName3 = "";
        SpellName4 = "";
    }

    public override void Spell1(Fighter target)
    {
        Console.WriteLine("You used "+SpellName1);
        Damage(target, Math.Round(TempDmgMult*DmgMult*Wis * ((0.4)*rng.NextDouble()+0.8),2));
    }
    public override void Spell2(Fighter target)
    {
        Console.WriteLine("You used "+SpellName2);
        Heal(15);
    }
    public override void Spell3(Fighter target)
    {
        
    }
    public override void Spell4(Fighter target)
    {
        Invulnerable = true;
        Console.WriteLine("You used "+SpellName4);
        Console.WriteLine("You are invulnerable untill your next turn");
    }
}
