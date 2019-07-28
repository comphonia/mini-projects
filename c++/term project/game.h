#pragma once
#include <list>
#include <string>
#include <iostream>
using namespace std;

class game
{
private:
	struct stat
	{
		int gameNumber;
		string type;
		int attempts;
	};
	static int instance;
	game *gptr;
	static list<stat> stats;

public:
	game();
	game(string);
	void showMenu();
	bool selectMenu(string);
	void saveStats(string, int);
	void showStats() const;
	void getGameType() const;
	virtual string generateKey();
};