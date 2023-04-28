using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurnBased_Fighting_Game
{
    public partial class Leaders : Form
    {
        public Leaders()
        {
            InitializeComponent();
        }

        private void Leaders_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.LoadBoard(this);
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}
