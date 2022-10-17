int character = 0;
bool select = true;
int choice = 0;

Player p1 = new Player();
Paladin p2 = new Paladin();
Mainmenu menu = new Mainmenu();
Battlemenu battle = new Battlemenu();

Console.WriteLine("Choose your Character: \n 1. Rogue \n 2. Paladin \n 3. Mage");
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
            break;
    }
    p1.weapon = new Weapon();
}


while(true)
{
    choice = menu.Menu();
    switch(choice)
    {
        case 1:
            battle.Battle(p1,p2);
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
}

