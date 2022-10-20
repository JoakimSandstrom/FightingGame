using System;
public class Battlemenu
{
    private int action;
    private bool b;
    private int round;
    private int turn;

    
    public void PvP(Player p1,Player p2)
    {
        //Resets values before combat
        action = 0;
        b = true;
        round = 1;
        turn = 1;

        while(p1.Hp != 0 &&  p2.Hp != 0)
        {
            b = true;
            action = Utilities.AskForInt(0, 3, "Round:"+round+" | Turn: P"+turn+"\n"+"P1-HP: "+p1.ShowHp()+"\n"+"P2-HP: "+p2.ShowHp()+"\n\n"+"--------------------\n1. Attack"+"\n"+"2. Spells", "ERROR: Choose 1 or 2");
            while(b)
            {
                b = false;
                switch(action)
                {
                    case 1:
                        if(turn==1)
                        {
                            p1.Attack(p2);
                        }
                        else
                        {
                            p2.Attack(p1);
                        }
                        break;
                    case 2:
                        b = Spells(p1,p2);
                        break;
                }
            }
            Turn();
            Console.WriteLine("Press 'Enter' to end your turn!");
            Console.ReadLine();
        }

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

    //Lists and let's the player pick between the available spells. They can also go back to the previous menu (PvP())
    private bool Spells(Player p1, Player p2)
    {
        //Player 1
        if (turn==1)
        {
            action = Utilities.AskForInt(0, 5, "Round:"+round+" | Turn: P"+turn+"\n"+"P1-HP: "+p1.ShowHp()+"\n"+"P2-HP: "+p2.ShowHp()+"\n\n"+"--------------------\n"+p1.ListSpells()+"\n5. Go back", "ERROR: Choose 1 - 5");
            switch(action)
            {
                case 1:
                    p1.Spell1(p2);
                    break;
                case 2:
                    p1.Spell2(p2);
                    break;
                case 3:
                    p1.Spell3(p2);
                    break;
                case 4:
                    p1.Spell4(p2);
                    break;
                case 5:
                    //Returns true so the while loop in PvP() can repeat.
                    return true;
            }
        }

        //Player 2
        else
        {
            action = Utilities.AskForInt(0, 5, "Round:"+round+" | Turn: P"+turn+"\n"+"P1-HP: "+p1.ShowHp()+"\n"+"P2-HP: "+p2.ShowHp()+"\n\n"+"--------------------\n"+p1.ListSpells()+"\n5. Go back", "ERROR: Choose 1 - 5");
            switch(action)
            {
                case 1:
                    p2.Spell1(p1);
                    break;
                case 2:
                    p2.Spell2(p1);
                    break;
                case 3:
                    p2.Spell3(p1);
                    break;
                case 4:
                    p2.Spell4(p1);
                    break;
                case 5:
                    //Returns true so the while loop in PvP() can repeat.
                    return true;
            }
        }

        //Returns false so that the while loop in Pvp() can close.
        return false;
    }


    //The turn corresponds to the player. turn 1 is always Player 1;s turn, and vice versa.
    //This is used to keep track of who is currently playing, who is attacking/casting spells and who should be targeted by spells/attacks.
    //The turn function swiches the turn between 1 and 2. If it was player 2;s turn, then the round also increases becuase one round is two turns.
    private void Turn()
    {
        if (turn==2)
        {
            turn = 1;
            round += 1;
        }
        else
        {
            turn = 2;
        }
    }
}
