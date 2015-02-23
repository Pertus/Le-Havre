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
    public partial class PayEnergyForm : Form
    {
        decimal energyToPay;
        Player _Player;
        int totalEnergyPaid;

        public PayEnergyForm(decimal energyAmmount, Player player)
        {
            InitializeComponent();

            energyToPay = energyAmmount;
            _Player=player;
            label1.Text = "Energy to pay: " + energyToPay;
            coal_numeric.Maximum = player.Coal;
            charcoal_numeric.Maximum = player.Charcoal;
            coke_numeric.Maximum = _Player.Coke;
            coal_numeric.ValueChanged += UpdateEnergyPaid;
            charcoal_numeric.ValueChanged += UpdateEnergyPaid;
            coke_numeric.ValueChanged += UpdateEnergyPaid;
        }

        void UpdateEnergyPaid(object sender, EventArgs e)
        {
            totalEnergyPaid = Convert.ToInt32(coal_numeric.Value * 3 + charcoal_numeric.Value * 3 + coke_numeric.Value * 10);
            totalEnergyPaid_lbl.Text = "Total energy paid: " + totalEnergyPaid;
        }

        private void PayEnergyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalEnergyPaid < energyToPay)
                MessageBox.Show("You have to pay at least " + energyToPay + " energy!");
            else
            {
                _Player.Coal -= (int)coal_numeric.Value;
                _Player.Charcoal -= (int)charcoal_numeric.Value;
                _Player.Coke -= (int)coke_numeric.Value;
                this.Close();
            }
        }
    }
}
