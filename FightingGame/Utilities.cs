using System;

public class Utilities
{
    public static int AskForInt(int header, int maxValue, string message, string error)
    {
        Console.Clear();
        bool success = false;
        int result = 0;
        bool repeat = false;
        while (success == false)
        {
            Console.Clear();
            //Adds a header on top if asked
            switch(header)
            {
                case 1:
                    Mainmenu.PrintTitel();
                    break;
                case 2:
                    break;
            }
            Console.WriteLine(message);
            if (repeat) Console.WriteLine(error);

            success = int.TryParse(Console.ReadLine(), out result);
            if (result > maxValue || result <= 0) success = false;

            if (success == false) repeat = true;
        }
        return result;
    }

    //Returns true for 'y' (yes) and false for 'n' (no)
    public static bool YesOrNo(int header, string message, string error)
    {
        bool success = false;
        string result = "y";
        bool repeat = false;
        while (success == false)
        {
            Console.Clear();
            //Adds a header on top if asked
            switch(header)
            {
                case 1:
                    Mainmenu.PrintTitel();
                    break;
                case 2:
                    break;
            }
            Console.WriteLine(message);
            if (repeat) Console.WriteLine(error);

            string? v = Console.ReadLine();
            if (v == null) result = "";
            else result = v;

            if (result != "y" && result != "n") success = false;
            else success = true;

            if (success == false) repeat = true;
        }
        if (result == "y") return true;
        else return false;
    }
}
