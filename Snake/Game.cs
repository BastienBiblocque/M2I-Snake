using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Snake
{
    internal class Game
    {
        List<Player> PlayerList = new List<Player>();
        Dice Dice = new Dice();
        Boolean StillPlay;

        public Game()
        {
            PlayerList.Add(new Player("Bastien"));
            PlayerList.Add(new Player("JP"));

            StillPlay = true;

            while (StillPlay)
                StillPlay = PlayTurn(PlayerList, StillPlay, Dice);
        }

        private static Boolean PlayTurn(List<Player> PlayerList, Boolean StillPlay, Dice Dice)
        {
            foreach (Player player in PlayerList)
            {
                StillPlay = Game.PlayTurnAndReturnStillPlay(player, Dice);
                if (!StillPlay)
                    break;
            }
            return StillPlay;
        }

        private static Boolean PlayTurnAndReturnStillPlay(Player player, Dice Dice)
        {
            player.Score = RollDiceAndAdd(player.Score, Dice);
            if (player.Score > 50)
                player.Score = 25;
            else if (player.Score == 50)
                return DisplayWinner(player.Name);
            return true;
        }

        private static int RollDiceAndAdd(int PlayerScore, Dice Dice)
        {
            return PlayerScore + Dice.rollDice();
        }

        private static Boolean DisplayWinner(String playerName)
        {
            Console.WriteLine(playerName + " WIN");
            return false;
        }
    
    }
}
