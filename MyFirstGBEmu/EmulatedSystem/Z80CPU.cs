using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGBEmu.GameboySystem
{
    class Z80CPU
    {

        Memory GBMemory;
        #region Define the registers both private and public

        // TODO review level of public access as may not be required once emulator is move complete

        // The 8 bit registers, the 16 bit versions eg AF,BC,DE,HL will be methods
        // Remember f register is also the flags so provide bool access for them

        private Byte a;
        private Byte b;
        private Byte c;
        private Byte d;
        private Byte e;
        private Byte f;
        private Byte h;
        private Byte l;

        public Byte A
        {
            get { return a; }
            set { a = value; }
        }

        public Byte B
        {
            get { return b; }
            set { b = value; }
        }
        public Byte C
        {
            get { return c; }
            set { c = value; }
        }
        public Byte D
        {
            get { return d; }
            set { d = value; }
        }
        public Byte E
        {
            get { return e; }
            set { e = value; }
        }
        public Byte F
        {
            get { return f; }
            set { f = value; }
        }
        public Byte H
        {
            get { return h; }
            set { h = value; }
        }
        public Byte L
        {
            get { return l; }
            set { l = value; }
        }

        // Getters / Setters for the register pairs

        public ushort AF
        {
            get
            {
                byte[] tempArray = new byte[2] { a, f };
                return BitConverter.ToUInt16(tempArray, 0);
            }
            set
            {
                byte[] tempArray = BitConverter.GetBytes(value);
                a = tempArray[0];
                f = tempArray[1];
            }
        }

        public ushort BC
        {
            get
            {
                byte[] tempArray = new byte[2] { b, c };
                return BitConverter.ToUInt16(tempArray, 0);
            }
            set
            {
                byte[] tempArray = BitConverter.GetBytes(value);
                b = tempArray[0];
                c = tempArray[1];
            }
        }
        public ushort DE
        {
            get
            {
                byte[] tempArray = new byte[2] { d, e };
                return BitConverter.ToUInt16(tempArray, 0);
            }
            set
            {
                byte[] tempArray = BitConverter.GetBytes(value);
                d = tempArray[0];
                e = tempArray[1];
            }
        }
        public ushort HL
        {
            get
            {
                byte[] tempArray = new byte[2] { h, l };
                return BitConverter.ToUInt16(tempArray, 0);
            }
            set
            {
                byte[] tempArray = BitConverter.GetBytes(value);
                h = tempArray[0];
                l = tempArray[1];
            }
        }


        #endregion

        #region Access to the flags for register F
        public bool ZeroFlag
        {
            get { return ((f & (0x01 << 7)) != 0); }
            set
            {
                if (value)
                {
                    BitSet(ref f, 7);
                }
                else
                {
                    BitZero(ref f, 7);
                }
            }

        }
        public bool UnderflowFlag
        {
            get { return ((f & (0x01 << 6)) != 0); }
            set
            {
                if (value)
                {
                    BitSet(ref f, 6);
                }
                else
                {
                    BitZero(ref f, 6);
                }
            }

        }
        public bool NibbleCarryFlag
        {
            get { return ((f & (0x01 << 5)) != 0); }
            set
            {
                if (value)
                {
                    BitSet(ref f, 5);
                }
                else
                {
                    BitZero(ref f, 5);
                }
            }

        }
        public bool FullCarryFlag
        {
            get { return ((f & (0x01 << 4)) != 0); }
            set
            {
                if (value)
                {
                    BitSet(ref f, 4);
                }
                else
                {
                    BitZero(ref f, 4);
                }
            }

        }

        #endregion
        #region SP,PC,clocks and timers
        // Define the stack pointer and program counter

        public ushort SP
        {
            get;
            set;
        }
        public ushort PC
        {
            get;
            set;
        }

        // Running clocks
        public int MClock
        {
            get;
            set;
        }
        public int TClock
        {
            get;
            set;
        }

        // Timers for each cycle
        public int M
        {
            get;
            set;
        }
        public int T
        {
            get { return M * 4; }
        }
        #endregion

        #region Load Game / CPU starting position and reset methods

        // When loading a game will always force the CPU reset
        public Z80CPU(Memory game)
        {
            GBMemory = game;
            ResetCPU();
        }


        public void ResetCPU()
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            e = 0;
            f = 0;
            h = 0;
            l = 0;
            SP = 0;
            PC = 0;
            M = 0;
        }

           
   
        #endregion

        #region Methods for byte or bit operations

        // Set a given bit in referenced byte
        // | means bit OR
        private void BitSet(ref byte _byte, int bit)
        {
            _byte |= (byte)(1 << bit);
            M = 2;
        }

        // Zero a given bit in referenced byte
        // ~ means bit NOT
        private void BitZero(ref byte _byte, int bit)
        {
            _byte &= (byte)(~(1 << bit));
            M = 2;
        }
        #endregion

    }


}
