using System;
public class Mainmenu : Gamestate
{
    private bool select = true;
    private int choice = 0;
    public int character = 0;
    public bool pvp = false;

    public void Menu()
    {
        PrintMenu();
        while(select)
        {
            int.TryParse(Console.ReadLine(), out choice);
            select = false;
            switch(choice)
            {
                case 1:
                    PvP();
                    break;
                case 2:
                    PveMenu();
                    break;
                case 3:
                    PlayerMenu();
                    break;
                case 4:
                    Quit();
                    break;
                default:
                    select = true;
                    break;
            }
        }
        select = true;
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
    private void Quit()
    {
        Environment.Exit(1);
    }
}
