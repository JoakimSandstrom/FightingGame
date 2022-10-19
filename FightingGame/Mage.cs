using System;
public class Mage : Player
{
    Random rng = new Random();
    public Mage()
    {
        MaxHp = 90;
        Hp = 90;
        Str = 6;
        Wis = 15;
        Def = 0;
        Cc = 0.1;
        Cd = 2;
        Dodge = 0;

        SpellName1 = "Fire Somthing"; //Simple damageing spell
        SpellName2 = "Magic Missile"; //Undodgeble attack but lower damage 
        SpellName3 = "Blood Rite"; //Increase Damage but cost HP
        SpellName4 = "Barrier"; //Block Damage for one turn, Costs a lot
    }

    public override void Spell1(Fighter target)
    {
        Tdmg = Math.Round(TempDmgMult*DmgMult*Wis * ((0.4)*rng.NextDouble()+0.8),2);
        Damage(target);
        Console.WriteLine("You used "+SpellName1);
        Console.WriteLine("You dealt "+Tdmg+" points of damage");
    }
    public override void Spell2(Fighter target)
    {
        Tdmg = Math.Round(TempDmgMult*DmgMult*Wis*0.75,2);
        Damage(target);
        Console.WriteLine("You used "+SpellName2);
        Console.WriteLine("You dealt "+Tdmg+" points of damage");
    }
    public override void Spell3(Fighter target)
    {
        TempDmgMult += 0.25;
        Hp -= (MaxHp*0.1);
        Console.WriteLine("You used "+SpellName3);
        Console.WriteLine("Damage increased by 25%");
        Console.WriteLine("You lost "+(MaxHp*0.1)+" hp");
    }
    public override void Spell4(Fighter target)
    {
        Invulnerable = true;
        Console.WriteLine("You used "+SpellName4);
        Console.WriteLine("You are invulnerable untill your next turn");
    }
}
