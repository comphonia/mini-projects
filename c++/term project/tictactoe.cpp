#include "tictactoe.h"
#include <string>
#include <cstring>
#include <iostream>
#include <fstream>
using namespace std;

tictactoe::tictactoe() : guessCount(0), bs(""), usedSlots(""), winner("none"), winCombos{
																				   {0, 1, 2},
																				   {3, 4, 5},
																				   {6, 7, 8},
																				   {0, 3, 6},
																				   {1, 4, 7},
																				   {2, 5, 8},
																				   {0, 4, 8},
																				   {6, 4, 2}}
{
	bs = "123456789";
	cout << endl
		 << "INSTRUCTION: "
		 << "try to beat the AI, slots with numbers are empty" << endl;
	cout << "Play TicTacToe!! your piece is x" << endl;
	string input;
	do
	{
		//display board
		printBoard();
		cout << "Choose a slot: ";

		//get input
		cin >> input;
	} while (!validateInput(input));
}

// required checks for input
bool tictactoe::validateInput(string input)
{
	int num;
	try
	{
		num = stoi(input);
		if (num < 1 || num > 9)
		{
			cout << endl
				 << "*** Invalid space. Choose 1-9" << endl;
			return false;
		}
		else
		{
			num = num - 1;
			if (isValidSlot(num, "player"))
			{
				if (!isGameOver())
				{
					aiPlayTurn();
					return isGameOver();
				}
				else
					return true;
			}
			else
			{
				cout << "Slot <" << num + 1 << "> already occupied, select an empty slot." << endl;
				return false;
			}
		}
	}

	catch (const std::exception &e)
	{
		cout << endl
			 << "**** Not a valid space. Enter a digit (1-9)." << endl;
		return false;
	}

	return false;
}

//print a new board with board slots
void tictactoe::printBoard()
{
	cout << "|-----------|" << endl;
	cout << "| " << bs[0] << " | " << bs[1] << " | " << bs[2] << " |" << endl;
	cout << "| " << bs[3] << " | " << bs[4] << " | " << bs[5] << " |" << endl;
	cout << "| " << bs[6] << " | " << bs[7] << " | " << bs[8] << " |" << endl;
	cout << "|-----------|" << endl;
}

// check is slot is unused and add a char to the slot
bool tictactoe::isValidSlot(int num, string player)
{
	//char entry = bs[num];
	for (int i = 0; i < usedSlots.length(); i++)
	{
		if (num == usedSlots[i])
		{
			return false;
		}
	}
	usedSlots += num;
	if (player == "player")
	{
		guessCount++;
		bs[num] = 'x';
	}
	else if (player == "AI")
	{
		cout << "AI chose slot: " << bs[num] << endl;
		bs[num] = 'o';
	}
	return true;
}

//check for a mill or a full board
bool tictactoe::isGameOver()
{
	bool isEmpty = false;
	// check for a player win (x)
	for (int i = 0; i < 9; i++)
	{
		if (bs[winCombos[i][0]] == 'x' && bs[winCombos[i][1]] == 'x' && bs[winCombos[i][2]] == 'x')
		{
			winner = "player";
			printBoard();
			//save game
			game::saveStats("tictactoe", guessCount);
			cout << "Game Ended: You Won " << guessCount << " attempts" << endl;
			return true;
		}
		else if (bs[winCombos[i][0]] == 'o' && bs[winCombos[i][1]] == 'o' && bs[winCombos[i][2]] == 'o')
		{
			winner = "AI";
			printBoard();
			cout << "Game Ended: AI Wins" << endl;
			return true;
		}
	}

	//check for draw
	if (usedSlots.length() >= 9)
	{
		winner = "none";
		printBoard();
		cout << "Game Ended: DRAW" << endl;
		return true;
	}

	return false;
}

//novice ai plays turn on available slot as o
void tictactoe::aiPlayTurn()
{
	int num;
	do
	{
		num = rand() % 9;
	} while (!isValidSlot(num, "AI"));
}