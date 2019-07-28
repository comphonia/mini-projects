#pragma once
#include <string>
#include <vector>
#include "game.h"
using namespace std;

class wordguess : public game
{
private:
	string generatedKey;
	string inputString;
	string alphabet;
	int guessCount;
	vector<string> wordpool;
	bool pushChar(char);
	bool validateInput(string);
	void readWordsFromFile();
	void populateInputString(string,char);
	bool isWordGuessed();

public:
	wordguess();
	virtual string generateKey();
};