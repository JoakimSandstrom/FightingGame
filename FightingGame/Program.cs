int choice = 0;
int character = 0;
bool select = true;

Player p1 = new Player();
Player p2 = new Player();
Mainmenu menu = new Mainmenu();
Battlemenu battle = new Battlemenu();


Console.WriteLine("\n\nWelcome to my");
Console.WriteLine("░█▀▄░█▀█░█▀▄░▀█▀░█▀█░█▀▀░░░█▀▀░▀█▀░█▀▀░█░█░▀█▀░▀█▀░█▀█░█▀▀░░░█▀▀░█▀█░█▄█░█▀▀");
Console.WriteLine("░█▀▄░█░█░█▀▄░░█░░█░█░█░█░░░█▀▀░░█░░█░█░█▀█░░█░░░█░░█░█░█░█░░░█░█░█▀█░█░█░█▀▀");
Console.WriteLine("░▀▀░░▀▀▀░▀░▀░▀▀▀░▀░▀░▀▀▀░░░▀░░░▀▀▀░▀▀▀░▀░▀░░▀░░▀▀▀░▀░▀░▀▀▀░░░▀▀▀░▀░▀░▀░▀░▀▀▀");
Console.WriteLine("\n\n\n");
Console.WriteLine("P1: Choose your Character: \n 1. Rogue \n 2. Paladin \n 3. Mage");
while(select)
{
    int.TryParse(Console.ReadLine(), out character);
    select = false;
    switch(character)
    {
        case 1:
            p1 = new Rogue();
            break;
        case 2:
            p1 = new Paladin();
            break;
        case 3:
            p1 = new Mage();
            break;
        default:
            select = true;
            Console.WriteLine("Try again. Choose by typing 1,2 or 3");
            break;
    }
    p1.weapon = new Weapon();
}
p1.SetName();


while(true)
{
    choice = menu.Menu();
    switch(choice)
    {
        case 1:
            character = 0;
            select = true;
            Console.WriteLine("P2: Choose your Character: \n 1. Rogue \n 2. Paladin \n 3. Mage");
            while(select)
            {
                int.TryParse(Console.ReadLine(), out character);
                select = false;
                switch(character)
                {
                    case 1:
                        p2 = new Rogue();
                        break;
                    case 2:
                        p2 = new Paladin();
                        break;
                    case 3:
                        p2 = new Mage();
                        break;
                    default:
                        select = true;
                        break;
                }
                p2.weapon = new Weapon();
            }
            p2.SetName();
            battle.PvP(p1,p2);
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            Environment.Exit(1);
            break;
        default:
            break;
    }
    
    Console.ReadLine();
    Console.ReadLine();
}