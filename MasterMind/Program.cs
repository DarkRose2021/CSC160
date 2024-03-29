﻿using MasterMindLibrary;
using System;
using System.Collections.Generic;


namespace MasterMind
{
	class Program
	{
		static List<Peg> pegList = new List<Peg>()
		{
			new Peg(ConsoleColor.White, ConsoleColor.Red),
			new Peg(ConsoleColor.White, ConsoleColor.Blue),
			new Peg(ConsoleColor.Black, ConsoleColor.Green),
			new Peg(ConsoleColor.Black, ConsoleColor.Yellow),
			new Peg(ConsoleColor.Black, ConsoleColor.Cyan),
			new Peg(ConsoleColor.White, ConsoleColor.Magenta),
			new Peg(ConsoleColor.White, ConsoleColor.DarkGray),
			new Peg(ConsoleColor.White, ConsoleColor.DarkRed)
		};

		static void Main(string[] args)
		{
			List<Attempt> allAttempts = new List<Attempt>();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Welcome to Mastermind!");
			Console.ResetColor();

			//ask for difficulty

			//ask for maxTurns of turns to guess it

			//store the maxPegs based on difficulty

			//Generate an answer

			//show cheat? 
			//MMLib.Cheat(answer, pegList);

			//loop while !gameWon && maxTurns != 0
			//  get user attempt
			//  Check the attempt for a correct guess
			//  add the attempt to the attempt list
			//  determine if the game has been won or not
			//  reduce the maxTurns

			//If won, display Game Won!
			//If lost, show game loss
			//show the correct answer
		}

		static Attempt GetAttemptFromUser(int maxPegs, List<Attempt> allAttempts, int maxTurns)
		{
			//Create a new Attempt
			//Get color options based on maxPegs
			//Loop of # of pegs they need to choose
			//      clear console
			//      Display # of attempts left
			//      Show all previous attempts
			//      Show pegs they have chosen already in this attempt
			//      Ask them to pick a peg color from a menu of options
			//      Add the chosen peg to the Attempt.AttemptList
			//Return the attempt when done

			Attempt attempt = new Attempt();

			return attempt;
		}


		static void CheckAttempt(Attempt attempt, List<int> answer)
		{
			//Check the attempt.AttemptList to see if they got a match to the answer
			//If a peg is correct, increment the attempt.CorrectAnswerCount
		}
	}
}
