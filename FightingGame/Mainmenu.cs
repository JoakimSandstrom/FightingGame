using System;
public class Mainmenu : Gamestate
{
    static public int Menu()
    {
        return Utilities.AskForInt(1, 4, "1. PvP"+"\n"+"2. PvE"+"\n"+"3. Player Menu"+"\n"+"4. Quit", "ERROR: Choose 1 - 4");
    }
    static public void PrintTitel()
    {
        Console.Clear();
        Console.WriteLine("\n\nWelcome to my");
        Console.WriteLine("░█▀▄░█▀█░█▀▄░▀█▀░█▀█░█▀▀░░░█▀▀░▀█▀░█▀▀░█░█░▀█▀░▀█▀░█▀█░█▀▀░░░█▀▀░█▀█░█▄█░█▀▀");
        Console.WriteLine("░█▀▄░█░█░█▀▄░░█░░█░█░█░█░░░█▀▀░░█░░█░█░█▀█░░█░░░█░░█░█░█░█░░░█░█░█▀█░█░█░█▀▀");
        Console.WriteLine("░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░▀▀▀░░░▀░░░▀▀▀░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░▀▀▀░░░▀▀▀░▀░▀░▀░▀░▀▀▀");
        Console.WriteLine("\n\n\n"+"--------------------");
    }

}
