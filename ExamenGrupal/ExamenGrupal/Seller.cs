using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Seller : NPC
    {
        public int money;
        public List<string> itemList;

        public Seller(string name, float life, string type, int money, List<string> itemList) : base(name, life, type)
        {
            this.money = money;
            this.itemList = itemList;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to the " + name + " shop!");
            while (true)
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Show available items");
                Console.WriteLine("2. Sell item");
                Console.WriteLine("3. Exit");

                string input = Console.ReadLine();
                int choice;
                if (Int32.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Available items: " + string.Join(", ", itemList));
                            break;
                        case 2:
                            Console.WriteLine("Enter the item name to sell: ");
                            string itemToSell = Console.ReadLine();
                            if (itemList.Contains(itemToSell))
                            {
                                money += 10;
                                itemList.Remove(itemToSell);
                                Console.WriteLine("Item sold!");
                            }
                            else
                            {
                                Console.WriteLine("Item not found in the list of items.");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Exiting...");
                            return;
                        default:
                            Console.WriteLine("Invalid. Try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid. Try again.");
                }
            }
        }
        public override void HabilitiesNPC()
        {
             
        }
    }
}
