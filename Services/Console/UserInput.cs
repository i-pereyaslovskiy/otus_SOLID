using otus_Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Solid.Services.Conseole
{
    internal class UserInput : IUserInput
    {


        public int UserInputNumber()
        {

            int choice = 0;
            while (!Int32.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Wrong input! Enter choice number again:");
            }
            return choice;
        }
    }
}
