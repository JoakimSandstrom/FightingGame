using System;
public class Battle : Gamestate
{
    private int action = 0;
    private bool select = true;
    private int round = 1;
    private int turn = 1;
    public Battle(Fighter p1,Fighter p2)
    {
        while(p1.hp > 0 || p2.hp > 0)
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
            p2.ShowHp();
            Console.ReadLine();
        }
        
    }
    
    public void PrintBattle(Fighter p1,Fighter p2)
    {
        Console.Clear();
        Console.WriteLine("Round:"+round+" | Turn: P"+turn+"\n"+"P1-HP: "+p1.HitPoints+"\n"+"P2-HP: "+p2.HitPoints );
        Console.WriteLine("\n"+"--------------------");
        Console.WriteLine("1. Attack"+"\n"+"2. Spells");
    }
    public void Attack(Fighter p1, Fighter p2)
    {
        if (turn == 1)
        {
            p1.Damage(p2);
        }
        else
        {
            p2.Damage(p1);
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
