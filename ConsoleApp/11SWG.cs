using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class _11SWG
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                char HumanInput, ComputerInput;
                Console.WriteLine("Enter 's'/'w'/'g'");
                HumanInput = char.Parse(Console.ReadLine());
                string str = "swg";
                Random random = new Random();
                int index = random.Next(str.Length);
                ComputerInput = str[index];
                Console.WriteLine("You:" + HumanInput);
                Console.WriteLine("Computer:" + ComputerInput);
                if ((HumanInput == 's' && ComputerInput == 's') || (HumanInput == 'w' && ComputerInput == 'w') ||
                    (HumanInput == 'g' && ComputerInput == 'g')
                    )
                {
                    Console.WriteLine("Result:Draw");
                }
                else if ((HumanInput == 's' && ComputerInput == 'w') || (HumanInput == 'w' && ComputerInput == 'g') ||
                    (HumanInput == 'g' && ComputerInput == 's')
                    )
                {
                    Console.WriteLine("Result:you won");
                }
                else if ((HumanInput == 's' && ComputerInput == 'g') || (HumanInput == 'w' && ComputerInput == 's') ||
                    (HumanInput == 'g' && ComputerInput == 'w')
                    )
                {
                    Console.WriteLine("Result:computer won");

                }
                else
                {
                    Console.WriteLine("Result:Invalid");
                }
            }

        }
    }
}
