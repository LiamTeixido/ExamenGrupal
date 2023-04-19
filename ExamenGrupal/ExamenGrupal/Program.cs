using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenGrupal
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Execute();

            /*while (true)
            {
                Console.WriteLine("Press X to exit");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key==ConsoleKey.X)
                {
                    break;
                }
            }
            */
        }
    }
}
