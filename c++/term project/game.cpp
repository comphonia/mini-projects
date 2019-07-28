#include "game.h"
#include "baseball.h"
#include "wordguess.h"
#include "tictactoe.h"
#include <iostream>
#include <string>
#include <list>
#include <ctime>
#include <cstdlib>
using namespace std;

int game::instance = 0;
list<game::stat> game::stats;

game::game() : gptr(nullptr)
{
	srand(time(nullptr));
}

game::game(string type) : gptr(nullptr)
{
	instance++;

	if (type == "baseball")
	{
		gptr = new baseball();
		delete gptr;
	}
	else if (type == "wordguess")
	{
		gptr = new wordguess();
		delete gptr;
	}
	else if (type == "tictactoe")
	{
		gptr = new tictactoe();
		delete gptr;
	}
}

void game::showMenu()
{
	string selection;
	do
	{
		cout << "1.Baseball 2.Wordguess 3.TicTacToe 4.Stats 0.Exit: ";
		cin >> selection;
	} while (!selectMenu(selection));
}

bool game::selectMenu(string selection)
{
	int num;
	try
	{
		num = stoi(selection);
		if (num < 0 || num > 4)
		{
			cout << endl
				 << "*** Invalid menu. Choose 0-4" << endl;
			return false;
		}
		// validation passed
		switch (num)
		{
		case 0:
			exit(0);
			break;
		case 1:
			game("baseball");
			break;
		case 2:
			game("wordguess");
			break;
		case 3:
			game("tictactoe");
			break;
		case 4:
			showStats();
			return false;
			break;
		default:
			break;
		}
		return true;
	}

	catch (const std::exception &e)
	{
		cout << endl
			 << "**** Not a valid menu. Enter a digit (0-4)." << endl;
		return false;
	}

	return false;
}

void game::saveStats(string type, int attempts)
{
	stat st;
	st.gameNumber = instance;
	st.type = type;
	st.attempts = attempts;
	stats.push_back(st);
}

void game::showStats() const
{
	if (stats.size() == 0)
	{
		cout << "No game play history" << endl;
	}
	else
	{
		cout << "[game	type		attempts]" << endl;
		for (list<stat>::iterator it = stats.begin(); it != stats.end(); ++it)
		{
			cout << "[" << it->gameNumber << "]	" << it->type << "	" << it->attempts << endl;
		}
	}
}

string game::generateKey()
{
	return "-1";
}