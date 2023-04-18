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
        private List<Item> items;
        private bool continueFlag;

        public void Execute()
        {
            players = new List<Player>();
            npcs = new List<NPC>();
            items = new List<Item>();
            continueFlag = true;

            while (continueFlag)
            {
                AddPlayerMenu();
                AddNPCMenu();
                AddItemMenu();
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
               string option = Console.ReadLine();

                switch (opcion)
                {
                    case 1:
                        CreatePlayer();
                        break;
                    case 2:
                        CreateSeller();
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        CreatePlayerDataList()
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
            string name;
            int level;
            float price;
             Console.WriteLine ("Introducir el nombre del jugador")
               name = Console.ReadLine();
            Console.WriteLine ("Introducir el nivel del jugador")
               level = Console.ReadLine();
            Console.WriteLine("Introducir su economia del jugador")
                price = Console.ReadLine();
            
            players.Add(new Player(name, level, price));

        }

        public void CreateSeller()
        {

            string name;
            float life;
            string type;
            float money;
            Console.WriteLine("Introducir el nombre del vendedor")
               name = Console.ReadLine();
            Console.WriteLine("Introducir la vida del vendedor")
               life = Console.ReadLine();
            Console.WriteLine("Introducir el tipo del vendedor")
                type = Console.ReadLine();
            Console.WriteLine("Introducir el dinero del vendedor")
                money = Console.ReadLine();
            npcs.Add(new NPC(name, life, type, money));
        }

        

        public void CreateItem()
        {
            Console.WriteLine("¿Que items desea agregar a su inventario del jugador?");
            Console.WriteLine("1. Pociones");
            Console.WriteLine("2. Armas");
            switch (option)
            {
                case "1":

                    string name;
                    float price;
                    string type;
                    float capacity;
                    Console.WriteLine("Introducir el nombre de la poción")
                      name = Console.ReadLine();
                    Console.WriteLine("Introducir el preció de la poción")
                        price = Console.ReadLine();
                    Console.WriteLine("Introducir el tipo de la poción")
                        type = Console.ReadLine();
                    Console.WriteLine("Introducir es la capacidad de la poción")
                        capacity = Console.ReadLine();

                    items.Add(new Item(name, price, type));





                case "2":
                    string name;
                    float price;
                    string type;
                    float damage;
                    Console.WriteLine("Introducir el nombre de la arma")
                      name = Console.ReadLine();
                    Console.WriteLine("Introducir el preció de la arma")
                        price = Console.ReadLine();
                    Console.WriteLine("Introducir el tipo de la arma")
                        type = Console.ReadLine();
                    Console.WriteLine("Introducir el daño de la arma")
                        damage = Console.ReadLine();

                    items.Add(new Item(name, price, type));

            }            
        }


        public void CreatePlayerDataList()
        {
            Console.WriteLine("Que dato desea ver?")
            Console.WriteLine("Nombre: " + players.name);
            Console.WriteLine("Nivel: " + players.level);
            Console.WriteLine("Dinero: " + players.price);


            public string ShowData()
            {
                return "Name: " + Name + "\r\nLevel: " + Level + "\r\nPrice: " + Price;
            }
        }  
    }
}
