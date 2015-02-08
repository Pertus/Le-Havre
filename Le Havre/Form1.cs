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
    public partial class Form1 : Form
    {
        Game game;
        private int francs;
        private int fish;
        private int wood;
        private int clay;
        private int grain;
        private int iron;
        private int cattle;
        public Form1()
        {
            InitializeComponent();

            game = new Game();

            francs_lbl.Text = francs.ToString();
            fish_lbl.Text = fish.ToString();
            wood_lbl.Text = wood.ToString();
            clay_lbl.Text = clay.ToString();
            grain_lbl.Text = grain.ToString();
            iron_lbl.Text = iron.ToString();
            cattle_lbl.Text = cattle.ToString();

            

            turn_lbl.Text = "Blue player's turn";

            game.TurnEnded += game_TurnEnded;
            game.RoundEnded += game_RoundEnded;
            UpdatePlayerResources();
            RevealNewRoundmarker();
            AddNewResources(game.GetNextRoundMarker());
            MoveBoat();
            UpdateRoundCard();
        }

        void game_RoundEnded(object sender, EventArgs e)
        {
            UpdateRoundCard();
            
        }

        void game_TurnEnded(object sender, EndTurnArgs e)
        {
            turn_lbl.Text = e.NewActivePlayer + "'s turn";
            if (game.Round == 1)
                RevealNewRoundmarker();
            if(game.Turn<8)
                AddNewResources(game.GetNextRoundMarker());

            UpdatePlayerResources();
            MoveBoat();         
        }

        private void UpdateRoundCard()
        {
            RoundCard currentRoundCard = game.GetNextRoundCard();

            RC_round_lbl.Text = "Round: " + currentRoundCard.RoundNr.ToString();
            RC_food_lbl.Text = "Food needed: " + currentRoundCard.FoodNeeded.ToString();

            if (currentRoundCard.Harvest == true)
                RC_harvest_lbl.Text = "Harvest";
            else
                RC_harvest_lbl.Text = "No Harvest";
            if (currentRoundCard.BuildBuilding == true)
                RC_building_lbl.Text = "Standard Building";
            else
                RC_building_lbl.Text = "";
            if (currentRoundCard.SpecialBuilding == true)
                RC_specialbuilding_lbl.Text = "Special Building";
            else
                RC_specialbuilding_lbl.Text = "";
        }

        private void MoveBoat()
        {
            switch(game.Turn)
            {
                case(1):
                    if (game.activePlayer == game.player1)
                        boatspace1.BackColor = Color.Blue;
                    else
                        boatspace1.BackColor = Color.Red;
                    boatSpace6.BackColor = Color.SaddleBrown;                  
                    break;
                case (2):
                    if (game.activePlayer == game.player1)
                        boatSpace2.BackColor = Color.Blue;
                    else
                        boatSpace2.BackColor = Color.Red;
                    boatSpace7.BackColor = Color.SaddleBrown;
                    break;
                case (3):
                    if (game.activePlayer == game.player1)
                        boatSpace3.BackColor = Color.Blue;
                    else
                        boatSpace3.BackColor = Color.Red;
                    boatspace1.BackColor = Color.SaddleBrown;
                    break;
                case (4):
                    if (game.activePlayer == game.player1)
                        boatSpace4.BackColor = Color.Blue;
                    else
                        boatSpace4.BackColor = Color.Red;
                    boatSpace2.BackColor = Color.SaddleBrown;
                    break;
                case (5):
                    if (game.activePlayer == game.player1)
                        boatSpace5.BackColor = Color.Blue;
                    else
                        boatSpace5.BackColor = Color.Red;
                    boatSpace3.BackColor = Color.SaddleBrown;
                    break;
                case (6):
                    if (game.activePlayer == game.player1)
                        boatSpace6.BackColor = Color.Blue;
                    else
                        boatSpace6.BackColor = Color.Red;
                    boatSpace4.BackColor = Color.SaddleBrown;
                    break;
                case (7):
                    if (game.activePlayer == game.player1)
                        boatSpace7.BackColor = Color.Blue;
                    else
                        boatSpace7.BackColor = Color.Red;
                    boatSpace5.BackColor = Color.SaddleBrown;
                    break;               

                }
        }

        private void AddNewResources(RoundMarker roundMarker)
        {
            switch (roundMarker.Id)
            {
                case(1): fish++;
                    clay++;
                    fish_lbl.Text = fish.ToString();
                    clay_lbl.Text = clay.ToString();
                    break;
                case (2): iron++;
                    francs++;
                    iron_lbl.Text = iron.ToString();
                    francs_lbl.Text = francs.ToString();
                    break;
                case (3): fish++;
                    grain++;
                    fish_lbl.Text = fish.ToString();
                    grain_lbl.Text = grain.ToString();
                    break;
                case (4): wood++;
                    clay++;
                    wood_lbl.Text = wood.ToString();
                    clay_lbl.Text = clay.ToString();
                    break;
                case (5): fish++;
                    wood++;
                    fish_lbl.Text = fish.ToString();
                    wood_lbl.Text = wood.ToString();
                    game.PayInterest();
                    UpdatePlayerResources();
                    break;
                case (6): francs++;
                    wood++;
                    francs_lbl.Text = francs.ToString();
                    wood_lbl.Text = wood.ToString();
                    break;
                case (7): wood++;
                    cattle++;
                    wood_lbl.Text = wood.ToString();
                    cattle_lbl.Text = cattle.ToString();
                    break;
            }
        }

        private void RevealNewRoundmarker()
        {
            switch(game.Turn)
            {
                case (1): rm1l1.Text = game.GetNextRoundMarker().FirstResource;
                    rm1l2.Text = game.GetNextRoundMarker().SecondResource;
                    if (game.GetNextRoundMarker().Interest == false)
                        rm1l3.Text = "";
                    else
                        rm1l3.Text = "Interest";
                    break;
                case (2): rm2l1.Text = game.GetNextRoundMarker().FirstResource;
                    rm2l2.Text = game.GetNextRoundMarker().SecondResource;
                    if (game.GetNextRoundMarker().Interest == false)
                        rm2l3.Text = "";
                    else
                        rm2l3.Text = "Interest";
                    break;
                case (3): rm3l1.Text = game.GetNextRoundMarker().FirstResource;
                    rm3l2.Text = game.GetNextRoundMarker().SecondResource;
                    if (game.GetNextRoundMarker().Interest == false)
                        rm3l3.Text = "";
                    else
                        rm3l3.Text = "Interest";
                    break;
                case (4): rm4l1.Text = game.GetNextRoundMarker().FirstResource;
                    rm4l2.Text = game.GetNextRoundMarker().SecondResource;
                    if (game.GetNextRoundMarker().Interest == false)
                        rm4l3.Text = "";
                    else
                        rm4l3.Text = "Interest";
                    break;
                case (5): rm5l1.Text = game.GetNextRoundMarker().FirstResource;
                    rm5l2.Text = game.GetNextRoundMarker().SecondResource;
                    if (game.GetNextRoundMarker().Interest == false)
                        rm5l3.Text = "";
                    else
                        rm5l3.Text = "Interest";
                    break;
                case (6): rm6l1.Text = game.GetNextRoundMarker().FirstResource;
                    rm6l2.Text = game.GetNextRoundMarker().SecondResource;
                    if (game.GetNextRoundMarker().Interest == false)
                        rm6l3.Text = "";
                    else
                        rm6l3.Text = "Interest";
                    break;
                case (7): rm7l1.Text = game.GetNextRoundMarker().FirstResource;
                    rm7l2.Text = game.GetNextRoundMarker().SecondResource;
                    if (game.GetNextRoundMarker().Interest == false)
                        rm7l3.Text = "";
                    else
                        rm7l3.Text = "Interest";
                    break;



                }


        }

        private void UpdatePlayerResources()
        {
            player1Points_lbl.Text = "Points: " + game.player1.CalculatePoints();
            player1Francs_lbl.Text = "Francs: " + game.player1.Francs;
            player1Fish_lbl.Text = "Fish: " + game.player1.Fish;
            player1Wood_lbl.Text = "Wood: " + game.player1.Wood;
            player1Clay_lbl.Text = "Clay: " + game.player1.Clay;
            player1Grain_lbl.Text = "Grain: " + game.player1.Grain;
            player1Iron_lbl.Text = "Iron: " + game.player1.Iron;
            player1Cattle_lbl.Text = "Cattle: " + game.player1.Cattle;
            player1Coal_lbl.Text = "Coal: " + game.player1.Coal;
            player1Hides_lbl.Text = "Hides: " + game.player1.Hides;
            player1SmokedFish_lbl.Text = "Smoked fish: " + game.player1.SmokedFish;
            player1Charcoal_lbl.Text = "Charcoal: " + game.player1.Charcoal;
            player1Bricks_lbl.Text = "Bricks: " + game.player1.Bricks;
            player1Bread_lbl.Text = "Bread: " + game.player1.Bread;
            player1Steel_lbl.Text = "Steel: " + game.player1.Steel;
            player1Meat_lbl.Text = "Meat: " + game.player1.Meat;
            player1Coke_lbl.Text = "Coke: " + game.player1.Coke;
            player1Leather_lbl.Text = "Leather: " + game.player1.Leather;
            player1Loans_lbl.Text = "Loans: " + game.player1.Loans;

            player2Points_lbl.Text = "Points: " + game.player2.CalculatePoints();
            player2Francs_lbl.Text = "Francs: " + game.player2.Francs;
            player2Fish_lbl.Text = "Fish: " + game.player2.Fish;
            player2Wood_lbl.Text = "Wood: " + game.player2.Wood;
            player2Clay_lbl.Text = "Clay: " + game.player2.Clay;
            player2Grain_lbl.Text = "Grain: " + game.player2.Grain;
            player2Iron_lbl.Text = "Iron: " + game.player2.Iron;
            player2Cattle_lbl.Text = "Cattle: " + game.player2.Cattle;
            player2Coal_lbl.Text = "Coal: " + game.player2.Coal;
            player2Hides_lbl.Text = "Hides: " + game.player2.Hides;
            player2SmokedFish_lbl.Text = "Smoked fish: " + game.player2.SmokedFish;
            player2Charcoal_lbl.Text = "Charcoal: " + game.player2.Charcoal;
            player2Bricks_lbl.Text = "Bricks: " + game.player2.Bricks;
            player2Bread_lbl.Text = "Bread: " + game.player2.Bread;
            player2Steel_lbl.Text = "Steel: " + game.player2.Steel;
            player2Meat_lbl.Text = "Meat: " + game.player2.Meat;
            player2Coke_lbl.Text = "Coke: " + game.player2.Coke;
            player2Leather_lbl.Text = "Leather: " + game.player2.Leather;
            player2Loans_lbl.Text = "Loans: " + game.player2.Loans;


        }
        #region click methods

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                game.EndTurn();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You have to do a main action before you can end your turn");
            }
        }

        private void francs_pb_Click(object sender, EventArgs e)
        {
            try
            {
                game.TakeFrancs(Convert.ToInt32(francs_lbl.Text));
                francs = 0;
                francs_lbl.Text = francs.ToString();
                UpdatePlayerResources();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You can only do one main action!");
            }
        }

        private void fish_pb_Click(object sender, EventArgs e)
        {
            try
            {
                game.TakeFish(Convert.ToInt32(fish_lbl.Text));
                fish = 0;
                fish_lbl.Text = fish.ToString();
                UpdatePlayerResources();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You can only do one main action!");
            }
        }

        private void wood_pb_Click(object sender, EventArgs e)
        {
            try
            {
                game.TakeWood(Convert.ToInt32(wood_lbl.Text));
                wood = 0;
                wood_lbl.Text = wood.ToString();
                UpdatePlayerResources();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You can only do one main action!");
            }
        }

        private void clay_pb_Click(object sender, EventArgs e)
        {
            try
            {
                game.TakeClay(Convert.ToInt32(clay_lbl.Text));
                clay = 0;
                clay_lbl.Text = clay.ToString();
                UpdatePlayerResources();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You can only do one main action!");
            }
        }

        private void v_Click(object sender, EventArgs e)
        {
            try
            {
                game.TakeGrain(Convert.ToInt32(grain_lbl.Text));
                grain = 0;
                grain_lbl.Text = grain.ToString();
                UpdatePlayerResources();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You can only do one main action!");
            }
        }

        private void iron_pb_Click(object sender, EventArgs e)
        {
            try
            {
                game.TakeIron(Convert.ToInt32(iron_lbl.Text));
                iron = 0;
                iron_lbl.Text = iron.ToString();
                UpdatePlayerResources();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You can only do one main action!");
            }
        }

        private void cattle_pb_Click(object sender, EventArgs e)
        {
            try
            {
                game.TakeCattle(Convert.ToInt32(cattle_lbl.Text));
                cattle = 0;
                cattle_lbl.Text = cattle.ToString();
                UpdatePlayerResources();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("You can only do one main action!");
            }
        }
        #endregion
    }
}
