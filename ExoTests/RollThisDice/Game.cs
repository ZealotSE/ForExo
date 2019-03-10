using System;

namespace RollThisDice
{
    class Game
    {
        private string gameHistory;
        public Player[] players;
        public Dice[] dices;
        private int maxRounds;

        public Game()
        {
            players = new Player[]
            {
                new Player("Pierwszy"),
                new Player("Drugi")
            };
            dices = new Dice[]
            {
                new Dice(),
                new Dice()
            };
            maxRounds = 5;
        }

        public void Start()
        {   
            for (int actualRound = 0; actualRound < maxRounds; ++actualRound)
            {
                foreach (Player k in players)
                {
                    PlayerTurn(k);
                }
            }
            Summarize();
        }

        public void PlayerTurn(Player player)
        {
            int turnNumber = 1;
            bool nextPlayersTurn = false;
            while (!nextPlayersTurn)
            {
                int pointsFromThrows = 0;
                foreach (Dice dice in dices)
                {
                    pointsFromThrows += player.RollDice(dice);
                }                
                nextPlayersTurn = CheckGameRules(player, pointsFromThrows, turnNumber);
                ++turnNumber;
                gameHistory += ($"{player.Name} rolled {pointsFromThrows} in {turnNumber} turn\n");
            }
            gameHistory += ($"{player.Name} got {player.Points} points after round, next players turn\n\n");
        }

        private bool CheckGameRules(Player player, int pointsInTurn, int turnNumber)
        {
            if (turnNumber == 1 && (pointsInTurn == 7 || pointsInTurn == 11))
                return true;

            if (turnNumber == 1 && (pointsInTurn == 2 || pointsInTurn == 12))
            {
                player.Points += 33;
                return true;
            }

            if (pointsInTurn == 5)
                return true;

            player.Points += pointsInTurn / turnNumber;
            if (turnNumber == 10)
                return true;
            else
                return false;
        } 

        private void Summarize()
        {
            string winner = players[0].Points < players[1].Points ? players[0].Name : players[1].Name;
            Console.WriteLine($"After five round the winner is player {winner}.");
            Console.WriteLine($"Player {players[0].Name} got {players[0].Points} points, player {players[1].Name} got {players[1].Points} points\n");
        }

        public void WriteHistory()
        {
            Console.WriteLine(gameHistory);
        }
    }
}
