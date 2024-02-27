using otus_Solid.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Solid.Interfaces
{
    internal interface IGameLogic
    {
        public void InitRandomNumber();
        public bool IsAttemts();
        public AttemtResult TryAttemtResult(int number);

        public int NumderDebbug();
    }
}
