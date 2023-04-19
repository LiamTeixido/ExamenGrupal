using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Menu
    {
        static List<Player> players;
        static List<NPC> npcs;
        static List<Enemy> enemies;
        static List<Shopkeeper> sellers;
        static List<Items> items;
        private bool continueFlag;
        bool endingFlag = true;
        bool exit = false;

        public void Execute()
        {
            players = new List<Player>();
            npcs = new List<NPC>();
            enemies = new List<Enemy>();
            sellers = new List<Shopkeeper>();
            items = new List<Items>();
            continueFlag = true;

            MenuPrincipal();
        }

        public void MenuPrincipal()
        {
            while (endingFlag)
            {
                Console.WriteLine("========== MENÚ DE OPCIONES ==========");
                Console.WriteLine("1. Crear jugador");
                Console.WriteLine("2. Crear NPC y agregarlo a la lista de NPCs");
                Console.WriteLine("3. Crear item y agregarlo a la lista de items");
                Console.WriteLine("4. Listar los datos del jugador");
                Console.WriteLine("5. Listar los datos de los NPCs");
                Console.WriteLine("6. Listar los datos de los items");
                Console.WriteLine("7. Eliminar un NPC");
                Console.WriteLine("8. Eliminar un item");
                Console.WriteLine("9. Seleccionar un item y agregarlo a un jugador o NPC");
                Console.WriteLine("10. Salir del programa");
                Console.WriteLine("======================================");

                Console.Write("Ingresa el número de opción: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        CreatePlayer();
                        break;
                    case 2:
                        CreateNPC();
                        break;
                    case 3:
                        CreateItem();
                        break;
                    case 4:
                        PlayerData();
                        break;
                    case 5:
                        NPCData();
                        break;
                    case 6:
                        ItemData();
                        break;
                    case 7:
                        DeleteNPC();
                        break;
                    case 8:
                        DeleteItem();
                        break;
                    case 9:
                        SelectAndAddItem();
                        break;
                    case 10:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                        break;
                }
            }

        }

        public void CreatePlayer()
        {
            Console.WriteLine("Introducir el nombre del jugador");
            string name = Console.ReadLine();
            Console.WriteLine("Introducir el nivel del jugador");
            int level = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducir su economia del jugador");
            int money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducir su experiencia del jugador");
            int exp = Convert.ToInt32(Console.ReadLine());

            List<Items> itemList = new List<Items>();

            players.Add(new Player(name, itemList, exp, level, money));
        }

        public void PlayerData()
        {
            if (players.Count > 0)
            {
                foreach (Player player in players)
                {
                    Console.WriteLine("---------");
                    Console.WriteLine(player.ShowData());
                }
            }
            else
            {
                Console.WriteLine("No hay PLAYERS.\n");
            }

        }

        public void CreateNPC()
        {
            Console.Write("Enter NPC Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Life: ");
            int life = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter NPC Type (Enemy, Seller, Converser): ");
            string type = Console.ReadLine();

            List<Items> itemList = new List<Items>();

            switch (type)
            {
                case "Enemy":
                    Console.Write("Enter Damage: ");
                    int damage = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Experience: ");
                    int experience = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Level: ");
                    int level = Convert.ToInt32(Console.ReadLine());

                    Enemy enemy = new Enemy(name, life, type, damage, itemList, level, experience);
                    enemies.Add(enemy);
                    npcs.Add(enemy);
                    break;
                case "Seller":
                    Console.Write("Enter Money: ");
                    int money = Convert.ToInt32(Console.ReadLine());

                    Shopkeeper seller = new Shopkeeper(name, life, type, money, itemList);
                    sellers.Add(seller);
                    npcs.Add(seller);
                    break;
                case "Converser":
                    Console.Write("Enter Texts (separated by commas): ");
                    string input = Console.ReadLine();

                    List<string> textList = input.Split(',').Select(item => item.Trim()).ToList();

                    Talkers converser = new Talkers(name, life, type, textList);
                    npcs.Add(converser);
                    break;
            }
        }

        public void NPCData()
        {
            if (npcs.Count > 0)
            {
                foreach (NPC npc in npcs)
                {
                    Console.WriteLine("---------");
                    if (npc is Enemy enemy)
                    {
                        Console.WriteLine(enemy.ShowData());
                    }
                    else if (npc is Shopkeeper seller)
                    {
                        Console.WriteLine(seller.ShowData());
                    }
                    else if (npc is Talkers converser)
                    {
                        Console.WriteLine(converser.ShowData());
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay NPCS.\n");
            }
        }

        public void DeleteNPC()
        {
            int i = 0;
            foreach (NPC npc in npcs)
            {
                Console.WriteLine(i + ". " + npc.name);
                i++;
            }
            Console.WriteLine("¿Qué NPC quieres borrar?: (número)");
            int option = Convert.ToInt32(Console.ReadLine());
            npcs.RemoveAt(option);
        }

        public void CreateItem()
        {
            Console.WriteLine("¿Que items desea agregar a su inventario del jugador?\n1. Poción\n2. Arma");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introducir el nombre del item");
            string name = Console.ReadLine();
            Console.WriteLine("Introducir el precio del item");
            int price = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Introducir es la capacidad de la poción");
                    int capacity = Convert.ToInt32(Console.ReadLine());

                    items.Add(new Potion(name, "Poción", price, capacity));
                    break;
                case 2:
                    Console.WriteLine("Introducir el daño del arma");
                    int damage = Convert.ToInt32(Console.ReadLine());

                    items.Add(new Potion(name, "Arma", price, damage));
                    break;
            }
        }

        public void ItemData()
        {
            if (items.Count > 0)
            {
                foreach (Items item in items)
                {
                    Console.WriteLine("---------");
                    if (item is Weapon weapon)
                    {
                        Console.WriteLine(weapon.ShowData());
                    }
                    else if (item is Potion potion)
                    {
                        Console.WriteLine(potion.ShowData());
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay ITEMS.\n");
            }

        }

        public void DeleteItem()
        {
            if (items.Count > 0)
            {
                int i = 0;
                foreach (Items item in items)
                {
                    Console.WriteLine(i + ". " + item.name);
                    i++;
                }
                Console.WriteLine("¿Qué Item quieres borrar?: (número)");
                int option = Convert.ToInt32(Console.ReadLine());
                items.RemoveAt(option);
            }
            else
            {
                Console.WriteLine("No hay items que borrar.");
            }
        }

        public void SelectAndAddItem()
        {
            int i = 0;
            if (items.Count > 0)
            {
                foreach (Items item in items)
                {
                    Console.WriteLine(i + ". " + item.name);
                    i++;
                }
                Console.WriteLine("¿Qué Item quieres seleccionar?: (número)");
                int itemSelected = Convert.ToInt32(Console.ReadLine());
                i = 0;
                Console.WriteLine("¿Se lo quieres dar a un Player o NPC?: ");
                string answer = Console.ReadLine();
                if (answer == "Player")
                {
                    if (players.Count > 0)
                    {
                        foreach (Player player in players)
                        {
                            Console.WriteLine(i + ". " + player.name);
                            i++;
                        }
                        Console.WriteLine("¿A qué Player se lo quieres dar?: (número)");
                        int playerNumber = Convert.ToInt32(Console.ReadLine());
                        players[playerNumber].itemList.Add(items[itemSelected]);
                        Console.WriteLine($"Se añadió el item {items[itemSelected].name} al Player {players[playerNumber].name}");
                    }
                    else
                    {
                        Console.WriteLine("No hay Players para dárselo.");
                    }

                }
                else if (answer == "NPC")
                {
                    Console.WriteLine("¿A qué tipo de NPC se lo quieres dar?: Enemy o Seller");
                    string answer2 = Console.ReadLine();
                    if (answer2 == "Enemy")
                    {
                        if (enemies.Count > 0)
                        {
                            foreach (Enemy enemy in enemies)
                            {
                                Console.WriteLine(i + ". " + enemy.name);
                                i++;
                            }
                            Console.WriteLine("¿A qué Enemy se lo quieres dar?: (número)");
                            int enemyNumber = Convert.ToInt32(Console.ReadLine());
                            enemies[enemyNumber].itemList.Add(items[itemSelected]);
                            Console.WriteLine($"Se añadió el item {items[itemSelected].name} al Enemy {enemies[enemyNumber].name}");
                        }
                        else
                        {
                            Console.WriteLine("No hay Enemies para dárselo.");
                        }
                    }
                    else if (answer2 == "Shopkeeper")
                    {
                        if (sellers.Count > 0)
                        {
                            foreach (Shopkeeper seller in sellers)
                            {
                                Console.WriteLine(i + ". " + seller.name);
                                i++;
                            }
                            Console.WriteLine("¿A qué Seller se lo quieres dar?: (número)");
                            int sellerNumber = Convert.ToInt32(Console.ReadLine());
                            sellers[sellerNumber].itemList.Add(items[itemSelected]);
                            Console.WriteLine($"Se añadió el item {items[itemSelected].name} al Enemy {sellers[sellerNumber].name}");
                        }
                        else
                        {
                            Console.WriteLine("No hay Shopkeepers para dárselo.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay Items que dar.");
            }
        }
        public void Exit()
        {
            endingFlag = false;
        }

    }
}
