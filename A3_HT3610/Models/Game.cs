//Name: Harshal Thavrani
//    Student Id: 8733610
//    Assignment 3 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A3_HT3610.Models
{
    public class Game
    {
        public int Id { get; set; }

        public List<Tile> tiles { get; set; }

        public Player Player { get; set; }

        public double GameCoins { get; set; }

        public double cashoutcoins { get; set; }

        public double takeoutcoins { get; set; }

        public GameCondition GamePoint { get; set; }

        public string GamePointMessage { get; set; }

        //This method will help starting the game 
        public void Start()
        {
            Player.TotalCoins -= GameCoins;
            ShuffleCards();
            GamePoint = GameCondition.BEGIN;
            GamePointMessage = "Game starts. Ready to Play. Good Luck!";

        }

        //This is a helper a method which helps in shuffling the cards it decides the card value wll be 0 i.e. "Lose Card" or 
        //Greater than 0 i.e. "Win Card"
        public void ShuffleCards()
        {
            tiles = new List<Tile>();
            Random r = new Random();
            for (int i = 0; i < 12; i++)
            {
                double randomValue = 0;
                if (r.Next(1, 4) != 1)
                {
                    randomValue = (r.NextDouble() + 0.5) * 2;
                }

                var tile = new Tile()
                {
                    TileIndex = i,
                    Visible = false,
                    Value = randomValue
                };

                tiles.Add(tile);
            }
        }

        //This method Doubles the value inside the tile this method will help when a player
        //wins and continues to play and it will show a higher a value card than the previous
        public void DoubleTheTile()
        {
            foreach (Tile currentcard in tiles)
            {
                if (!currentcard.Visible && currentcard.Value > 0)
                {
                    currentcard.Value *= 2;
                }
            }
        }

        //This method turns over the tile again.
        public void TurnOverTile()
        {
            foreach (Tile currentcard in tiles)
            {
                currentcard.Visible = true;
            }
        }

        //This method reveal's tile i.e. shows player the value of tile which determines if he won or lost th game.
        public void RevealTile(int idxtile)
        {
            if (idxtile >= 0)
            {
                foreach (Tile currentcard in tiles)
                {
                    if (currentcard.TileIndex == idxtile)
                    {
                        currentcard.Visible = true;
                        if (currentcard.Value > 0)
                        {
                            GamePoint = GameCondition.WIN;
                            DoubleTheTile();
                            GamePointMessage = "You Win";
                        }
                        else
                        {
                            GamePoint = GameCondition.BUST;
                            TurnOverTile();
                            GamePointMessage = "You Lose";
                        }
                    }
                }
            }
        }
    }

    public enum GameCondition
    {
        END,
        BEGIN,
        WIN,
        BUST,

    }
}
