namespace Tennis
{
    public class TennisGame3 : ITennisGame
    {
        private int score2;
        private int score1;
        private string player1;
        private string player2;
        private string result;

        public TennisGame3(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        public string GetScore()
        {
            if ((score1 < 4 && score2 < 4) && (score1 + score2 < 6))
            {
                return playerMoves();
            }
            else
            {
                if (score1 == score2)
                    return "Deuce";

                result = score1 > score2 ? player1 : player2;
                return playerWinsOrAdvantages();
        
            }
        }

        public void WonPoint(string playerName)
        {
            if (playerName == "player1")
                this.score1 += 1;
            else
                this.score2 += 1;
        }

        public string playerMoves()
        {
            string[] index = { "Love", "Fifteen", "Thirty", "Forty" };
            result = index[score1];
            return (score1 == score2) ? result + "-All" : result + "-" + index[score2];
        }

        public string playerWinsOrAdvantages()
        {
            return ((score1 - score2) * (score1 - score2) == 1) ? "Advantage " + result : "Win for " + result;
        }
    }
}

