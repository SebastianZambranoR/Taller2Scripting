using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
    internal class Match
    {
        List<Deck> players = new List<Deck>();
        Deck matchWinner;

        internal List<Deck> Players { get => players;}
        internal Deck MatchWinner { get => matchWinner; }

        public void Addplayer(Deck player)
        {
            if(this.players.Count < 2)
            {
                this.players.Add(player);
                player.OnLose += RemovePlayer;
            }

            
        }

        void RemovePlayer(Deck player)
        {
            if (players.Contains(player))
            {
                players.Remove(player);
                Winner();
            }

        }

        void Winner()
        {
            matchWinner = players[0];
        }
    }
}
