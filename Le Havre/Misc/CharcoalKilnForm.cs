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
    public partial class CharcoalKilnForm : Form
    {
        Player _Player;
        public CharcoalKilnForm(Player player)
        {
            InitializeComponent();
            _Player=player;
            label1.Text = "You have " + _Player.Wood + " wood";
            numericUpDown1.Maximum = _Player.Wood;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Player.Wood -= (int)numericUpDown1.Value;
            _Player.Charcoal += (int)numericUpDown1.Value;
            this.Close();
        }
    }
}
