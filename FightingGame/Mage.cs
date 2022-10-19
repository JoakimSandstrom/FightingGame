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
    }
    public override void Spell2(Fighter target)
    {
        Tdmg = Math.Round(TempDmgMult*DmgMult*Wis*0.75,2);
        Damage(target);
    }
    public override void Spell3(Fighter target)
    {
        TempDmgMult *= 1.25;
        Hp -= (MaxHp*0.1);
    }
    public override void Spell4(Fighter target)
    {
        Invulnerable = true;
    }
}
