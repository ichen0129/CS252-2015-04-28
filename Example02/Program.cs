using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("(1)剪刀、(2)石頭、(3)布 請出拳 ...");

            int userInput = int.Parse(Console.ReadLine());

            Random random = new Random();
            int pc = random.Next(1, 4);

            if (pc == userInput)
                Console.WriteLine("平手");
            else if (pc == 1 && userInput == 2) //pc=剪刀、user=石頭
                Console.WriteLine("你贏了!");
            else if (pc == 1 && userInput == 3) //pc=剪刀、user=布
                Console.WriteLine("PC贏了");
            else if (pc == 2 && userInput == 1) //pc=石頭、user=剪刀
                Console.WriteLine("PC贏了");
            else if (pc == 2 && userInput == 3) //pc=石頭、user=布
                Console.WriteLine("你贏了");
            else if (pc == 3 && userInput == 1) //pc=布、user=剪刀
                Console.WriteLine("你贏了");
            else if (pc == 3 && userInput == 2) //pc=布、user=石頭
                Console.WriteLine("你贏了");
        }
    }
}