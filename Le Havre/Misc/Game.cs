using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeHavre.Resources;

namespace LeHavre
{
    class Game
    {
        public Player player1;
        public Player player2;
        public Player activePlayer;

        private bool AvtivePlayersMainActionDone;

        private List<Player> playerList;
        private List<RoundMarker> roundMarkerList;
        private List<Boat> boatList;
        private List<RoundCard> roundCardList;

        public int Round { get; set; }
        public int Turn { get; set; }



        public event EventHandler <EndTurnArgs> TurnEnded;
        public event EventHandler RoundEnded;

        public Game()
        {
            player1 = new Player("Blue");
            player2 = new Player("Red");
            activePlayer = player1;
            AvtivePlayersMainActionDone = false;

            roundMarkerList = new List<RoundMarker>();
            playerList = new List<Player>() { player1, player2 };
            boatList = new List<Boat>(){new Boat("Wooden Ship", 2, 14, 4, 5, 0, 3, 0),new Boat("Wooden Ship", 2, 14, 4, 5, 0, 3, 0),new Boat("Wooden Ship", 4, 14, 4, 5, 0, 3, 0),new Boat("Wooden Ship", 4, 14, 4, 5, 0, 3, 0), 
                new Boat("Wooden Ship", 6, 14, 4, 5, 0, 3, 0), new Boat("Iron Ship", 4, 20, 5, 0, 4, 3, 0), new Boat("Iron Ship", 6, 20, 5, 0, 4, 3, 0), new Boat("Iron Ship", 8, 20, 5, 0, 4, 3, 0), new Boat("Iron Ship", 10, 20, 5, 0, 4, 3, 0), 
                new Boat("Steel Ship", 16, 30, 7, 0, 0, 3, 2), new Boat("Steel Ship", 20, 30, 7, 0, 0, 3, 2), new Boat("Steel Ship", 24, 30, 7, 0, 0, 3, 2), new Boat("Luxuary Liner", 34, 100, 0, 0, 0, 3, 3), new Boat("Luxuary Liner", 30, 100, 0, 0, 0, 3, 3)};
            roundCardList = new List<RoundCard>(){new RoundCard(1, 3, true, false, false), new RoundCard(2, 4, true, false, true), new RoundCard(3, 5, true, true, false), new RoundCard(4, 7, true, false, false), new RoundCard(5, 9, true, false, true),
                new RoundCard(6, 11, true, true, false), new RoundCard(7, 13, true, false, false), new RoundCard(8, 15, true, false, true), new RoundCard(9, 16, true, true, false), new RoundCard(10, 17, true, false, false), new RoundCard(11, 18, true, false, true), 
                new RoundCard(12, 19, true, true, false), new RoundCard(13, 20, true, false, false), new RoundCard(14, 20, false, false, false)};

            ShuffleAndAddRoundMarkers();
            Round = 1;
            Turn = 1;
        }

        //test
        //public BuildingCard testCard = new BuildingCard(GetClay);

        //private static void GetClay(Player p)
        //{
        //    p.AddResource(new Clay());
        //}

        

        public void EndTurn()
        {
            //testCard.Use(activePlayer);
            
            if (AvtivePlayersMainActionDone == true)
            {
                if (activePlayer == player1)
                {
                    activePlayer = player2;
                    Turn++; 
                    if (Turn > 7)
                         EndRound();
                    OnTurnEnded(new EndTurnArgs("Red player"));
                }
                else
                {
                    activePlayer = player1;
                    Turn++;
                    if (Turn > 7)
                        EndRound();
                    OnTurnEnded(new EndTurnArgs("Blue player"));
                }
                AvtivePlayersMainActionDone = false;
                
            }
            else
                throw new InvalidOperationException();       
        }

        public void EndRound()
        {
            Turn = 1;
            Harvest();
            Round++;
            OnRoundEnded(new EventArgs());   
        }

        public RoundCard GetNextRoundCard()
        {
            return roundCardList[Round -1];
        }
        public Boat GetNextBoat()
        {
            return boatList[Round - 1];
        }

        private void ShuffleAndAddRoundMarkers()
        {
            RoundMarker r1 = new RoundMarker("Fish", "Clay", false, 1);
            RoundMarker r2 = new RoundMarker("Iron", "Franc", false, 2);
            RoundMarker r3 = new RoundMarker("Fish", "Grain", false, 3);
            RoundMarker r4 = new RoundMarker("Wood", "Clay", false, 4);
            RoundMarker r5 = new RoundMarker("Fish", "Wood", true, 5);
            RoundMarker r6 = new RoundMarker("Franc", "Wood", false, 6);
            RoundMarker r7 = new RoundMarker("Wood", "Cattle", false, 7);

            roundMarkerList.Add(r1);
            roundMarkerList.Add(r2);
            roundMarkerList.Add(r3);
            roundMarkerList.Add(r4);
            roundMarkerList.Add(r5);
            roundMarkerList.Add(r6);
            roundMarkerList.Add(r7);

            //Shuffle
            Random random = new Random();
            for (int i = roundMarkerList.Count; i > 1; i--)
            {
                int j = random.Next(i);
                RoundMarker temp = roundMarkerList[j];
                roundMarkerList[j] = roundMarkerList[i - 1];
                roundMarkerList[i - 1] = temp;
            }
        }

        public void PayInterest()
        {
            foreach (Player p in playerList)
            {
                if(p.Loans>0)
                {
                    if (p.Francs<1)
                    {
                        TakeLoan(p);
                    }
                    p.Francs -= 1;
                 }

            }
        }

        public void TakeLoan(Player player)
        {
            player.Loans++;
            player.Points -= 7;
            player.Francs += 4;
        }

        public RoundMarker GetNextRoundMarker()
        {
            return roundMarkerList[Turn - 1];
        }


        public void Harvest()
        {
            HarvestForm harvestForm1 = new HarvestForm(this, player1);
            HarvestForm harvestForm2 = new HarvestForm(this, player2);
            harvestForm1.ShowDialog();           
            harvestForm2.ShowDialog();          
        }

        private void OnTurnEnded(EndTurnArgs e)
        {
            if (TurnEnded != null)
                TurnEnded(this, e);
        }

        private void OnRoundEnded(EventArgs e)
        {
            if (RoundEnded != null)
                RoundEnded(this, e);
        }
        #region Take-Methods

        public void TakeFrancs(int amount)
        {
            if (AvtivePlayersMainActionDone == false)
            {
                activePlayer.Francs += amount;
                AvtivePlayersMainActionDone = true;
            }
            else
                throw new InvalidOperationException();
        }

        public void TakeFish(int amount)
        {
            if (AvtivePlayersMainActionDone == false)
            {
                activePlayer.Fish += amount;
                AvtivePlayersMainActionDone = true;
            }
            else
                throw new InvalidOperationException();
        }
        public void TakeWood(int amount)
        {
            if (AvtivePlayersMainActionDone == false)
            {
                activePlayer.Wood += amount;
                AvtivePlayersMainActionDone = true;
            }
            else
                throw new InvalidOperationException();
        }
        public void TakeClay(int amount)
        {
            if (AvtivePlayersMainActionDone == false)
            {
                activePlayer.Clay += amount;
                AvtivePlayersMainActionDone = true;
            }
            else
                throw new InvalidOperationException();
        }
        public void TakeGrain(int amount)
        {
            if (AvtivePlayersMainActionDone == false)
            {
                activePlayer.Grain += amount;
                AvtivePlayersMainActionDone = true;
            }
            else
                throw new InvalidOperationException();
        }
        public void TakeIron(int amount)
        {
            if (AvtivePlayersMainActionDone == false)
            {
                activePlayer.Iron += amount;
                AvtivePlayersMainActionDone = true;
            }
            else
                throw new InvalidOperationException();
        }
        public void TakeCattle(int amount)
        {
            if (AvtivePlayersMainActionDone == false)
            {
                activePlayer.Cattle += amount;
                AvtivePlayersMainActionDone = true;
            }
            else
                throw new InvalidOperationException();
        }
        #endregion
    }
}
