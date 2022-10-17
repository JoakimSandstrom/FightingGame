using System;
public class Player : Fighter
{
    Random rng = new Random();
    public Weapon weapon = new Weapon();
    public override void Damage(Fighter target)
    {
        Tdmg = Math.Round(Str * ((weapon.maxDamage-weapon.minDamage)*rng.NextDouble()+weapon.minDamage),2);
        target.Hp -= Tdmg;
    }
    public void SetName()
    {
        bool select = true;
        bool select1 = true;
        while(select1)
        {
            select1 = false;
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
}
