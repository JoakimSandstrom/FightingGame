using System;
public class Player
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
    public Weapon weapon;

    private bool madeChoice = false;
    public Player()
    {
        while(madeChoice == false)
        {
            Console.WriteLine("Choose a Class: 1.Rogue | 2.Paladin | 3.Wizard:");
            madeChoice = int.TryParse(Console.ReadLine(),out Class);
            
            switch(Class)
            {
                case 1:
                    Rogue();
                    break;
                case 2:
                    Paladin();
                    break;
                case 3:
                    Wizard();
                    break;
                default:
                    break;
            }
        }
    }
    public void Rogue()
    {
        hp = 100;
        str = 10;
        wis = 8;
        def = 0;
        cC = 0.1;
        cD = 2;
        dodge = 0.1;
    }
    public void Paladin()
    {
        hp = 120;
        str = 15;
        wis = 10;
        def = 0.1;
        cC = 0;
        cD = 2;
        dodge = 0;
    }
    public void Wizard()
    {
        hp = 90;
        str = 6;
        wis = 15;
        def = 0;
        cC = 0.1;
        cD = 2;
        dodge = 0;
    }
}
