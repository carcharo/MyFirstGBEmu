using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstGBEmu.GameboySystem;

namespace MyFirstGBEmu
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private Gameboy system = new Gameboy("tetris.gb");

        private void MainScreen_Load(object sender, EventArgs e)
        {
            cpuInstrucList.Items.Clear();
        }

        private void stepOneBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
