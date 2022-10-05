using System;
public class Fighter
{
    public string name = "Bob";
    public string className = "No Class";
    public int Class;
    public double hp;
    public int str;
    public int wis;
    public double def;
    public double cC;
    public double cD;
    public double dodge;

    private double totalDmg = 0;
    public virtual void Damage(Fighter target){}
    public double HitPoints
    {
        get
        {
            return hp;
        }
        set
        {
            hp = Math.Max(value, 0);
        }
    }
    public double ShowHp()
    {
        return Math.Round(hp);
    }
    public double Dmg
    {
        get
        {
            return totalDmg;
        }
        set
        {
            totalDmg = Math.Max(value, 0);
        }
    }
    public void GetDmg()
    {
        Console.WriteLine(totalDmg);
    }
}
