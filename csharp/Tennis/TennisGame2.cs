using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {
        private int p1point = 0;
        private int p2point = 0;

        private string p1res = "";
        private string p2res = "";
        private string player1Name;
        private string player2Name;
        private string score = "Deuce";

        Dictionary<int, string> result =
                new Dictionary<int, string>();

        // Add some elements to the dictionary. There are no
        // duplicate keys, but some of the values are duplicates.


        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            result.Add(0, "Love");
            result.Add(1, "Fifteen");
            result.Add(2, "Thirty");
            result.Add(3, "Forty");
        }

        public string GetScore()
        {

            playerMoves();
            playerWinsOrAdvantages();


            return score;
        }


        public void SetScore(int number)
        {
            for (int i = 0; i < number; i++)
            {
                WonPoint(player1Name);
                WonPoint(player2Name);
            }
        }

        private void scoreResult()
        {
            if (p1res == p2res)
            {
                score = p1res == "Forty" ? "Deuce" : p1res + "-All";
            } else
            {
                score = p1res + "-" + p2res;
            }
          
        }

        private void playerMoves()
        {
        if (p1point < 4 && p2point < 4)
            {
                p1res = result[p1point];
                p2res = result[p2point];
                scoreResult();
            } 
     
         
        }

        private void playerWinsOrAdvantages()
        {

            if (p1point > p2point && p2point >= 3)
            {
                score = "Advantage player1";
            }

            if (p1point >= 4 && p2point >= 0 && (p1point - p2point) >= 2)
            {
                score = "Win for player1";
            }

            if (p2point > p1point && p1point >= 3)
            {
                score = "Advantage player2";
            }

            if (p2point >= 4 && p1point >= 0 && (p2point - p1point) >= 2)
            {
                score = "Win for player2";
            }
        }

        public void WonPoint(string playerName)
        {
            _ = (playerName == "player1") ? p1point++ : p2point++;
        }

        
    }
}