using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeHavre.Misc
{
    public partial class AbattoirForm : Form
    {
        Player _Player;

        public AbattoirForm(Player player)
        {
            InitializeComponent();

            _Player = player;
            numericUpDown1.Maximum = _Player.Cattle;
            label1.Text = "You have " + _Player.Cattle + " cattle";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Player.Cattle -= (int)numericUpDown1.Value;
            _Player.Meat += (int)numericUpDown1.Value;
            _Player.Hides += (int)numericUpDown1.Value;
            this.Close();
        }
    }
}
