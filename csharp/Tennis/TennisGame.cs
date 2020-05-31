using System;
namespace Tennis
{
    public class TennisGame : ITennisGame
    {
        private int m_score1 = 0;
        private int m_score2 = 0;
        private string player1Name;
        private string player2Name;

        public TennisGame(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {
            return "Player 1: " + m_score1 + "Player 2: " + m_score2;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
            {
                m_score1 += 1;
                Console.WriteLine(playerName + "has scored " + m_score1 + " points");
            }
         
            else
            {
                m_score2 += 1;
                Console.WriteLine(playerName + "has scored " + m_score1 + " points");
            }
              
        }
    }
}
