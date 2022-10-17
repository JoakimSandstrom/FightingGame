using System;
public class Battlemenu
{
    private int action = 0;
    private bool select = true;
    private int round = 1;
    private int turn = 1;

    
    public void PvP(Player p1,Player p2)
    {
        while(p1.Hp != 0 &&  p2.Hp != 0)
        {
            PrintPvP(p1,p2);
            while(select)
            {
                int.TryParse(Console.ReadLine(), out action);
                select = false;
                switch(action)
                {
                    case 1:
                        Attack(p1,p2);
                        break;
                    case 2:
                        break;
                    default:
                        select = true;
                        break;
                }
            }
            select = true;
            Turn();
            Console.ReadLine();
        }
        PrintWinner(p1,p2);
    }
    
    public void PrintPvP(Player p1,Player p2)
    {
        Console.Clear();
        Console.WriteLine("Round:"+round+" | Turn: P"+turn+"\n"+"P1-HP: "+p1.ShowHp()+"\n"+"P2-HP: "+p2.ShowHp());
        Console.WriteLine("\n"+"--------------------");
        Console.WriteLine("1. Attack"+"\n"+"2. Spells");
    }
    public void PrintWinner(Player p1,Player p2)
    {
        Console.Clear();
        if (p1.Hp == 0)
        {
            Console.WriteLine("The Winner is "+p1.Name);
        }
        else
        {
            Console.WriteLine("The Winner is "+p2.Name);
        }
    }
    public void Attack(Player p1, Player p2)
    {
        if (turn == 1)
        {
            p1.Damage(p2);
            Console.WriteLine(p1.Tdmg);
        }
        else
        {
            p2.Damage(p1);
            Console.WriteLine(p2.Tdmg);
        }
    }
    public void Round()
    {
        round += 1;
    }
    public void Turn()
    {
        if (turn==2)
        {
            turn = 1;
        }
        else
        {
            turn = 2;
        }
    }
}
