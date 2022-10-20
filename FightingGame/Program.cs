Player p1 = new Player();
Player p2 = new Player();
Battlemenu battle = new Battlemenu();


int character = Utilities.AskForInt(1, 3, "P1: Choose your Character: \n 1. Rogue \n 2. Paladin \n 3. Mage", "ERROR: Choose 1, 2 or 3");

//P1 Chooses Character
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
}
p1.weapon = new Weapon();
p1.SetName();


while(true) //Menu
{
    int choice = Mainmenu.Menu();

    switch(choice)
    {
        case 1:
            //P2 Chooses Character
            character = Utilities.AskForInt(1, 3, "P2: Choose your Character: \n 1. Rogue \n 2. Paladin \n 3. Mage", "ERROR: Choose 1, 2 or 3");
            switch (character)
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
            }
            p2.weapon = new Weapon();
            p2.SetName();
            battle.PvP(p1, p2);
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            Environment.Exit(1);
            break;
    }
    Console.ReadLine();
}