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
    public partial class SmokehouseForm : Form
    {
        Player _Player;
        public SmokehouseForm(Player player)
        {
            InitializeComponent();
            _Player=player;
            label1.Text = "You have " + _Player.Fish + " fish";
            if (_Player.Fish < 6)
                numericUpDown1.Maximum = _Player.Fish;
            else
                numericUpDown1.Maximum = 6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Player.Fish -= (int)numericUpDown1.Value;
            _Player.SmokedFish += (int)numericUpDown1.Value;
            _Player.Francs += (int)numericUpDown1.Value / 2;

            new PayEnergyForm(1, _Player).ShowDialog();
            this.Close();
        }
    }
}
