using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGBEmu.GameboySystem
{
    class Gameboy
    {
        public Z80CPU GBCPU
        {
            get;
            set;
        }
        public Memory GBMemory
        {
            get;
            set;
        }

        public Gameboy(string gameToLoad)
        {
            GBMemory = new Memory(gameToLoad);
            GBCPU = new Z80CPU(GBMemory);
        }
    }
}
