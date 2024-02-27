using otus_Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Solid.Services.Conseole
{
    internal class Message : IMessage
    {
        public void ShowMassage(string s)
        {
            Console.Write(s);
        }

        public void ShowMassageLine(string s)
        {
            Console.WriteLine(s);
        }
    }
}
