namespace TicTacToe
{
	class Program
	{
		static void Main(String[] args)
		{
			//tic tac toe board, defaulted to space
			char[,] aryBoard = new char[3, 3];

			//player names
			string[] aryPlayerNames = { "Player 1", "Player 2" };

			//player symbols
			char[] arySymobls = { 'X', 'O' };

			bool bDone = false;
			int intWhoseTurn = 0;
			int intTotalTurns = 0;


			Console.WriteLine("Enter Player 1's Name:");
			aryPlayerNames[0] = Console.ReadLine();

			Console.WriteLine("Enter Player 2's Name:");
			aryPlayerNames[1] = Console.ReadLine();

			do
			{
				Console.WriteLine();
				for (int row = 0; row < aryBoard.GetLength(0); row++)
				{
					Console.Write("|");
					for (int col = 0; col < aryBoard.GetLength(1); col++)
					{

						Console.Write(" {0} ", aryBoard[row, col]);
						Console.Write("|");
					}
					Console.WriteLine();
					Console.Write("----------");
					Console.WriteLine();
				}
				Console.WriteLine();


				int chosenRow;
				int chosenCol;
				bool validInput = false;
				do
				{
					Console.WriteLine($"{aryPlayerNames[intWhoseTurn]} enter row (1-3)");
					bool validRow = int.TryParse(Console.ReadLine(), out chosenRow);

					Console.WriteLine($"{aryPlayerNames[intWhoseTurn]} enter column (1-3)");
					bool validCol = int.TryParse(Console.ReadLine(), out chosenCol);

					if (aryBoard[(chosenRow - 1), (chosenCol - 1)] == '\0')
					{
						if (chosenRow <= 3 & chosenRow != 0 & chosenCol != 0 & chosenCol <= 3)
						{
							if (intWhoseTurn == 0)
							{
								aryBoard[(chosenRow - 1), (chosenCol - 1)] = 'X';

							}
							else if (intWhoseTurn == 1)
							{
								aryBoard[(chosenRow - 1), (chosenCol - 1)] = 'O';
							}

							intWhoseTurn++;
							intTotalTurns++;

							if (intWhoseTurn > 1)
							{
								intWhoseTurn = 0;
							}

							validInput = true;
						}
					}
				}
				while (!validInput);

				bool xWIn = checkForWinner(aryBoard, 'X');
				bool oWin = checkForWinner(aryBoard, 'O');
				bool catGame = checkCatGame(aryBoard);
				if (xWIn || oWin || catGame)
				{
					Console.WriteLine();
					for (int row = 0; row < aryBoard.GetLength(0); row++)
					{
						Console.Write("|");
						for (int col = 0; col < aryBoard.GetLength(1); col++)
						{

							Console.Write(" {0} ", aryBoard[row, col]);
							Console.Write("|");
						}
						Console.WriteLine();
						Console.Write("----------");
						Console.WriteLine();
					}
					Console.WriteLine();

					if (xWIn)
					{
						Console.WriteLine($"{aryPlayerNames[0]} Wins!");
					}
					else if (oWin)
					{
						Console.WriteLine($"{aryPlayerNames[1]} Wins!");
					}
					else if (catGame)
					{
						Console.WriteLine("Tie Game");
					}
					bDone = true;
				}
			}
			while (!bDone);
		}

		static bool checkCatGame(char[,] aryBoard)
		{
			int filled = 0;

			for (int row = 0; row < aryBoard.GetLength(0); row++)
			{
				for (int col = 0; col < aryBoard.GetLength(1); col++)
				{
					if (aryBoard[row, col] != '\0')
					{
						filled++;
					}
				}
			}

			if (filled == 9)
			{
				return true;
			}

			return false;
		}

		static bool checkForWinner(char[,] aryBoard, char chPlayerSymbol)
		{
			for (int row = 0; row < aryBoard.GetLength(0); row++)
			{
				//check horizontal  
				if (aryBoard[0, 0] == chPlayerSymbol && aryBoard[1, 0] == chPlayerSymbol && aryBoard[2, 0] == chPlayerSymbol)
				{
					return true;
				}

				for (int col = 0; col < aryBoard.GetLength(1); col++)
				{
					//check vertical
					if (aryBoard[0, 0] == chPlayerSymbol && aryBoard[0, 1] == chPlayerSymbol && aryBoard[0, 2] == chPlayerSymbol)
					{
						return true;
					}

					//check diagonal top left to bottom right
					if (aryBoard[0, 0] == chPlayerSymbol && aryBoard[1, 1] == chPlayerSymbol && aryBoard[2, 2] == chPlayerSymbol)
					{
						return true;
					}

					//check diagonal top right to bottom left
					if (aryBoard[2, 0] == chPlayerSymbol && aryBoard[1, 1] == chPlayerSymbol && aryBoard[0, 2] == chPlayerSymbol)
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}