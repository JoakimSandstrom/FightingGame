using System;
public class Mainmenu : Gamestate
{
    private bool select = true;
    private int choice = 0;
    public int character = 0;
    public bool pvp = false;

    public int Menu()
    {
        PrintMenu();
        int.TryParse(Console.ReadLine(), out choice);
        switch(choice)
        {
            case 1:
                return 1;
            case 2:
                return 2;
            case 3:
                return 3;
            case 4:
                return 4;
            default:
                return 5;
        }
    }
    private void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("\n\nWelcome to my");
        Console.WriteLine("░█▀▄░█▀█░█▀▄░▀█▀░█▀█░█▀▀░░░█▀▀░▀█▀░█▀▀░█░█░▀█▀░▀█▀░█▀█░█▀▀░░░█▀▀░█▀█░█▄█░█▀▀");
        Console.WriteLine("░█▀▄░█░█░█▀▄░░█░░█░█░█░█░░░█▀▀░░█░░█░█░█▀█░░█░░░█░░█░█░█░█░░░█░█░█▀█░█░█░█▀▀");
        Console.WriteLine("░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░▀▀▀░░░▀░░░▀▀▀░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░▀▀▀░░░▀▀▀░▀░▀░▀░▀░▀▀▀");
        Console.WriteLine("\n\n\n"+"--------------------"+"\n"+"1. PvP"+"\n"+"2. PvE"+"\n"+"3. Player Menu"+"\n"+"4. Quit");
    }
    private void PvP() // Player 2 Choses their character
    {
        Console.WriteLine("Player 2!\nChoose your Character: \n 1. Rogue \n 2. Paladin \n 3. Mage");
        while(pvp == false)
        {
            int.TryParse(Console.ReadLine(), out character);
            if (0<character && character<4)
            {
                pvp = true;
            }
        }
    }
    private void PveMenu()
    {

    }
    private void PlayerMenu()
    {

    }
}
