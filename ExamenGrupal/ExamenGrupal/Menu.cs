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
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
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

       
    }
}
