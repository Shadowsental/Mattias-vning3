using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiasÖvning3
{
    public interface IUI
    {
        string GetStringInput();

        void PrintString(string message);

        void PrintString2(string massage, string format)
        {
            Console.WriteLine(massage);
        }
    }
}
