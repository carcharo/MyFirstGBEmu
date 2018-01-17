using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyFirstGBEmu.GameboySystem
{
    class Memory
    {
        // Define the various areas of memory - seen in SharpDMG and seemed interesting approach.
        // Alternative would be one RAM array and then load in the various parts. 

        // At the moment only simple cartridges will work eg tetris where there is no paging

        // TODO - Review public vs private
        public byte[] ROM
        {
            get;
            set;
        }

        public byte [] RAM
        {
            get;
            set;
        }
        public byte[] ZeroPage
        {
            get;
            set;
        }
        public byte[] VRAM
        {
            get;
            set;
        }
        public byte[] OAM
        {
            get;
            set;
        }
        public byte[] HardwareIO
        {
            get;
            set;
        }
        public byte[] BIOS
        {
            get;
            set;
        }
        public bool IsGBBIOSEnabled = true;

        public Memory (string gb_filename)
        {
            // Read the ROM and bios from gb file, note no paging as yet
            ROM = File.ReadAllBytes(gb_filename);
            BIOS = File.ReadAllBytes("bios.bin");
            // Set the sizes of the other areas
            RAM = new byte[0x2000];
            ZeroPage = new byte[128];
            VRAM = new byte[0x2000];
            OAM = new byte[160];
            HardwareIO = new byte[128];
        }

    }
}
