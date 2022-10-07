int character = 0;
bool select = true;

Player p1 = new Player();
Paladin p2 = new Paladin();
Gamestate menu = new Gamestate();

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
    
    menu = new Battle(p1,p2);
    menu = new Mainmenu();
    
    Console.ReadLine();
}

