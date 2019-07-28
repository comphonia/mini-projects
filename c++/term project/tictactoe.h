#pragma once
#include <string>
#include <vector>
#include "game.h"
using namespace std;

class tictactoe : public game
{
private:
	int guessCount;
	string bs;
	string usedSlots;
	string winner;
	int winCombos[8][3];
	bool validateInput(string);
	void printBoard();
	bool isValidSlot(int,string);
	bool isGameOver();
	void aiPlayTurn();

public:
	tictactoe();
};