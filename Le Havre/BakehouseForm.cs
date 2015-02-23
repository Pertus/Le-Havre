using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeHavre
{
    public partial class BakehouseForm : Form
    {
        Player _Player;
        public BakehouseForm(Player player)
        {
            InitializeComponent();
            _Player=player;
            label1.Text = "You have " + _Player.Grain + " grain and " + _Player.TotalEnergy + " energy.";


            numericUpDown1.Maximum = CalculateTotalBakableBread();
        }

        private void BakehouseForm_Load(object sender, EventArgs e)
        {

        }
        private int CalculateTotalBakableBread()
        {
            int result = 0;

            if (_Player.TotalEnergy * 2 >= _Player.Grain)
                result = _Player.Grain;
            else
                result = _Player.TotalEnergy * 2;
   
            return result;
        }

        private void Bake()
        {
            _Player.Grain -= (int)numericUpDown1.Value;
            _Player.Bread += (int)numericUpDown1.Value;
            _Player.Francs += (int)numericUpDown1.Value / 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bake();
            new PayEnergyForm(numericUpDown1.Value/2, _Player).ShowDialog();
            this.Close();
        }
    }
}
