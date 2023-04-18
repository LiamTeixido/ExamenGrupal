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
                
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        DeleteItem();
                        break;
                    case 2:
                        SelectAndAddItem();
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona una opción válida.");
                        break;
                }
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

    }
}
