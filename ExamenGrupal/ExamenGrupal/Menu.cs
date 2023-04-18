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
        static List<Seller> sellers;
        static List<Items> items;
        private bool continueFlag;
        bool endingFlag = true;
        bool exit = false;

        public void Execute()
        {
            players = new List<Player>();
            npcs = new List<NPC>();
            enemies = new List<Enemy>();
            sellers = new List<Seller>();
            items = new List<Items>();
            continueFlag = true;

            while (continueFlag)
            {
                EndingMenu();
            }
        }

        private void EndingMenu()
        {
            bool endingFlag = true;
            bool exit = false;

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
                        //CreateSeller();
                        CreateNPC();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        CreatePlayerDataList();
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        break;
                    case 7:
                       
                        break;
                    case 8:
                       
                        break;
                    case 9:
                       
                        break;
                    case 10:
                        exit = true;
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

        //public void CreateSeller()
        //{

        //    string name;
        //    float life;
        //    string type;
        //    float money;
        //    Console.WriteLine("Introducir el nombre del vendedor");
        //       name = Console.ReadLine();
        //    Console.WriteLine("Introducir la vida del vendedor");
        //       life = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Introducir el tipo del vendedor");
        //        type = Console.ReadLine();
        //    Console.WriteLine("Introducir el dinero del vendedor");
        //        money = Convert.ToInt32(Console.ReadLine());
        //    npcs.Add(new NPC(name, life, type, money));
        //}

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

                    Seller seller = new Seller(name, life, type, money, itemList);
                    sellers.Add(seller);
                    npcs.Add(seller);
                    break;
                case "Talker":
                    Console.Write("Enter Texts (separated by commas): ");
                    string input = Console.ReadLine();

                    List<string> textList = input.Split(',').Select(item => item.Trim()).ToList();

                    Talkers talker = new Talkers(name, life, type, textList);
                    npcs.Add(talker);
                    break;
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


        public void CreatePlayerDataList()
        {
            //Console.WriteLine("Que dato desea ver?");
            //Console.WriteLine("Nombre: " + players.name);
            //Console.WriteLine("Nivel: " + players.level);
            //Console.WriteLine("Dinero: " + players.price);


            //public string ShowData()
            //{
            //    return "Name: " + Name + "\r\nLevel: " + Level + "\r\nPrice: " + Price;
            //}
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

        public void SelectAndAddItem()
        {
            int i = 0;
            if (items.Count > 0)
            {
                foreach(Items item in items)
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
                    // DARLE OBJETO A NPC.
                }
            }
            else
            {
                Console.WriteLine("No hay Items que dar.");
            }
        }
    }
}
