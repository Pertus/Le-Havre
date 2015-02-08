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
    partial class HarvestForm : Form
    {
        int foodFromBoats;
        int maxFood;
        int foodToPay;
        int totalFood;
        Player currentPlayer;
        Game _game;
        int loansTaken;
        public HarvestForm(Game game, Player player)
        {
            InitializeComponent();
            currentPlayer = player;
            _game = game;
            loansTaken = 0;
            foodFromBoats = player.GetAmmountOfFoodFromBoats();
            foodToPay = game.GetNextRoundCard().FoodNeeded;
            maxFood = player.Francs + player.Fish + player.SmokedFish * 2 + player.Bread * 2 + player.Meat * 3 + foodFromBoats;
            totalFood = foodFromBoats;

            player_lbl.Text = player.Color + " player's harvest";
            foodToPay_lbl.Text = "Food to eat: " + foodToPay;
            foodFromBoats_lbl.Text = "Food from boats: " + foodFromBoats;
            totalFood_lbl.Text = "Total food selected: " + totalFood;   
            maxFood_lbl.Text = "Maximum food you can pay :" + maxFood;

            francsSelector.Maximum = player.Francs;
            francsSelector.ValueChanged += UpdateTotalFood;
            fishSelector.Maximum = player.Fish;
            fishSelector.ValueChanged += UpdateTotalFood;
            smokedFishSelector.Maximum = player.SmokedFish;
            smokedFishSelector.ValueChanged += UpdateTotalFood;
            breadSelector.Maximum = player.Bread;
            breadSelector.ValueChanged += UpdateTotalFood;
            meatselector.Maximum = player.Meat;
            meatselector.ValueChanged += UpdateTotalFood;
        }

        void UpdateTotalFood(object sender, EventArgs e)
        {
            int result = foodFromBoats;
            result += Convert.ToInt32(francsSelector.Value);
            result += Convert.ToInt32(fishSelector.Value);
            result += Convert.ToInt32(smokedFishSelector.Value*2);
            result += Convert.ToInt32(breadSelector.Value*2);
            result += Convert.ToInt32(meatselector.Value*3);

            totalFood = result;
            totalFood_lbl.Text = "Total food selected: " + result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PayHarvest();
        }

        private void player1Harve_Click(object sender, EventArgs e)
        {

        }

        private void TakeLoansUntilPlayerCanPay()
        {
            while (maxFood < foodToPay)
            {
                _game.TakeLoan(currentPlayer);
                maxFood += 4;
                loansTaken++;
            }                  
        }

        private void PayHarvest()
        {
            if (totalFood < foodToPay)
            {
                if (maxFood >= foodToPay)
                {
                    MessageBox.Show("You can pay the required ammount of food!");
                }
                else if (totalFood != maxFood)
                {
                    MessageBox.Show("You have to pay as much as you can");
                }
                    //First way out
                else
                {
                    int difference = foodToPay - maxFood;
                    TakeLoansUntilPlayerCanPay();
                    int francsLeft = loansTaken * 4 - difference;

                    currentPlayer.Francs -= Convert.ToInt32(francsSelector.Value) + difference;
                    currentPlayer.Fish -= Convert.ToInt32(fishSelector.Value);
                    currentPlayer.SmokedFish -= Convert.ToInt32(smokedFishSelector.Value);
                    currentPlayer.Bread -= Convert.ToInt32(breadSelector.Value);
                    currentPlayer.Meat -= Convert.ToInt32(meatselector.Value);

                    MessageBox.Show("Harvest completed. You took " + loansTaken + " number of loans this harvest");
                    this.Close();
                }
            }
                //Second way out
            else
            {
                currentPlayer.Francs -= Convert.ToInt32(francsSelector.Value);
                currentPlayer.Fish -= Convert.ToInt32(fishSelector.Value);
                currentPlayer.SmokedFish -= Convert.ToInt32(smokedFishSelector.Value);
                currentPlayer.Bread -= Convert.ToInt32(breadSelector.Value);
                currentPlayer.Meat -= Convert.ToInt32(meatselector.Value);

                MessageBox.Show("Harvest completed. You took " + loansTaken + " number of loans this harvest!");
                this.Close();
            }
        }
    }
}
