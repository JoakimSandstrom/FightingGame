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
}
