int character = 0;
Player p1 = new Player();
Console.WriteLine("Choose your Character: \n 1. Rogue \n 2. Paladin \n 3. Mage");
bool select = true;
Paladin p2 = new Paladin();
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
    Battle meny = new Battle(p1,p2);
    
    
    Console.ReadLine();
}

