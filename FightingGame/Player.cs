using System;
public class Player : Fighter
{

    public string SpellName1{get; protected set;} = "";
    public string SpellName2{get; protected set;} = "";
    public string SpellName3{get; protected set;} = "";
    public string SpellName4{get; protected set;} = "";

    Random rng = new Random();
    public Weapon weapon = new Weapon();
    public void Attack(Fighter target)
    {
        Tdmg = Math.Round(Str * ((weapon.maxDamage-weapon.minDamage)*rng.NextDouble()+weapon.minDamage),2);
        Damage(target);
    }
    public void SetName()
    //Set the players name
    {
        bool select = true;
        bool select1 = true;
        while(select1)
        //Repeat untill they have choosen a name
        {
            select1 = false;
            select = true;
            Console.WriteLine("Name your character: ");
            Name = Console.ReadLine();
            
            while(select)
            {
                Console.WriteLine("Do you want to name your character "+Name+"\ny/n");
                select = false;
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "y":
                        break;
                    case "n":
                        select1 = true;
                        break;
                    default:
                        select = true;
                        break;
                }
            }
        }
    }

    //Spells

    public virtual void Spell1(Fighter target){}
    public virtual void Spell2(Fighter target){}
    public virtual void Spell3(Fighter target){}
    public virtual void Spell4(Fighter target){}
}
