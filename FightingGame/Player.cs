using System;
public class Player : Fighter
{

    public string SpellName1{get; protected set;} = "";
    public string SpellName2{get; protected set;} = "";
    public string SpellName3{get; protected set;} = "";
    public string SpellName4{get; protected set;} = "";

    private bool b = false;
    Random rng = new Random();
    public Weapon weapon = new Weapon();
    public void SetName()
    //Set the players name
    {
        //Repeat untill they have choosen a name
        while(b == false)
        {
            Mainmenu.PrintTitel();
            Console.WriteLine("Name your character: ");
            string? v = Console.ReadLine();
            if (v == null) Name = "";
            else Name = v;
            
            b = Utilities.YesOrNo(1,"Do you want to name your character "+Name+"\ny/n","Type 'y' for yes or 'n' for no");
        }
    }

    //Spells

    public virtual void Spell1(Fighter target){}
    public virtual void Spell2(Fighter target){}
    public virtual void Spell3(Fighter target){}
    public virtual void Spell4(Fighter target){}
    public string ListSpells()
    {
        return "1. "+SpellName1+"\n2. "+SpellName2+"\n3. "+SpellName3+"\n4. "+SpellName4;
    }

    //Attack
    public void Attack(Fighter target)
    {
        Damage(target, Math.Round(TempDmgMult*DmgMult*Str * ((weapon.maxDamage-weapon.minDamage)*rng.NextDouble()+weapon.minDamage),2));
    }
}
