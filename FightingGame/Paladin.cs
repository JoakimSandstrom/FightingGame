using System;
public class Paladin : Player
{
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

        SpellName1 = "";
        SpellName2 = "";
        SpellName3 = "";
        SpellName4 = "";
    }

    public override void Spell1(Fighter target)
    {
        
    }
}
