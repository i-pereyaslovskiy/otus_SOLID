using otus_Solid.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_Solid.Services
{
    public class TimeDelay : ITimeDelay
    {
        public void Delay(int msec)
        {
            Thread.Sleep(msec);
        }
    }
}
