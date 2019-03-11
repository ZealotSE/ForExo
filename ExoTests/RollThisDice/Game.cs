using System;

namespace RollThisDice
{
    class Game
    {
        private bool gameIsFinished;
        private string gameHistory;
        private int maxRounds = 5;
        public Player[] players;
        public Dice[] dices;

        public void InitNewGame()
        {
            gameIsFinished = false;
            gameHistory = "";
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
            Console.Clear();
        }

        public void Start()
        {
            if (gameIsFinished)
            {
                Console.WriteLine("Init new game first.");
            }
            else
            {
                for (int actualRound = 0; actualRound < maxRounds; ++actualRound)
                {
                    foreach (Player k in players)
                    {
                        PlayerTurn(k);
                    }
                }
                gameIsFinished = true;
            }
        }

        public void SummarizeResult()
        {
            if (!gameIsFinished)
            {
                Console.WriteLine("Play this game first.");
            }
            else
            {
                Player winner = players[0].Points < players[1].Points ? (players[0]) : (players[1]);
                Player looser = players[0].Points > players[1].Points ? (players[0]) : (players[1]);

                Console.WriteLine("\n\n                          The game is over!\n");
                Console.WriteLine($"      Player {winner.Name} is the winner with the score of {winner.Points} points.");
                Console.WriteLine($"      Player {looser.Name} won second place with the score of {looser.Points} points.");
                Console.WriteLine("\n\n\n\n\"hist\" to see moves history\n\"exit\" to exit \nanything else to start new game.\n");

                var what = Console.ReadLine();
                if (what.Equals("hist"))
                {
                    Console.Clear();
                    WriteHistory();
                    Console.ReadKey();
                }
                if (what.Equals("exit"))
                {
                    Environment.Exit(0);
                }
            }
        }

        private void PlayerTurn(Player player)
        {
            bool nextPlayersTurn = false;
            int pointsFromThrow;
            int turnNumber = 1;

            while (!nextPlayersTurn)   // the move has the same player until the specific condition is met
            {
                pointsFromThrow = 0;

                foreach (Dice dice in dices)
                {
                    pointsFromThrow += player.RollDice(dice);
                }

                nextPlayersTurn = CheckGameRules(player, pointsFromThrow, turnNumber);
                ++turnNumber;
                gameHistory += String.Format("\n  Turn {0,2} {1,-8} rolled {2,-2}", turnNumber - 1, player.Name, pointsFromThrow);
            }
            gameHistory += "and ends his round.";
            gameHistory += ($"\n After this round player {player.Name} has {player.Points} points in total.\n\n");
        }

        private bool CheckGameRules(Player player, int pointsInTurn, int turnNumber)
        {
            if (turnNumber == 1 && (pointsInTurn == 7 || pointsInTurn == 11))   // scores 7 or 11 in first turn - end round without penalty poinst
                return true;

            if (turnNumber == 1 && (pointsInTurn == 2 || pointsInTurn == 12))   // scores 2 or 12 in first turn - end round with 33 penalty poinst
            {
                player.Points += 33;
                return true;
            }
            if (pointsInTurn == 5)                       // scores 5 in other than first round - end round without any penalty poinst
                return true;
            player.Points += pointsInTurn / turnNumber;  // get any other score - penalty points equal: scored_points/turn_number

            if (turnNumber == 10)                        // after 10 turns, turn to next player
                return true;
            else
                return false;
        }        

        private void WriteHistory()
        {
            Console.WriteLine("\n\n             Moves history from last game.\n\n");
            Console.WriteLine(gameHistory);
            Console.WriteLine("The game is over here.. press any button.");
        }
    }
}
