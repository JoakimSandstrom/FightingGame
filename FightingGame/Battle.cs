using System;
public class Battle : Gamestate
{
    private int action = 0;
    private bool select = true;
    private int round = 1;
    private int turn = 1;
    public Battle(Player p1,Player p2)
    {
        while(p1.HitPoints != 0 &&  p2.HitPoints != 0)
        {
            PrintBattle(p1,p2);
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
    
    public void PrintBattle(Player p1,Player p2)
    {
        Console.Clear();
        Console.WriteLine("Round:"+round+" | Turn: P"+turn+"\n"+"P1-HP: "+p1.ShowHp()+"\n"+"P2-HP: "+p2.ShowHp());
        Console.WriteLine("\n"+"--------------------");
        Console.WriteLine("1. Attack"+"\n"+"2. Spells");
    }
    public void PrintWinner(Player p1,Player p2)
    {
        Console.Clear();
        if (p1.HitPoints == 0)
        {
            Console.WriteLine("The Winner is "+p1.name);
        }
        else
        {
            Console.WriteLine("The Winner is "+p2.name);
        }
    }
    public void Attack(Player p1, Player p2)
    {
        if (turn == 1)
        {
            p1.Damage(p2);
            p1.GetDmg();
        }
        else
        {
            p2.Damage(p1);
            p2.GetDmg();
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
