#pragma once
#include <string>
#include "game.h"
using namespace std;

class baseball : public game
{
private:
	string generatedKey;
	int guessCount;
	bool validateInput(string);
	void showBS(string);

public:
	baseball();
	virtual string generateKey();
};