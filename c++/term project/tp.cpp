#include <iostream>
#include "game.h"
using namespace std;

//driver
int main()
{
	cout << "Select a menu:" << endl;
	game g;

	while (true)
	{
		g.showMenu();
	}
}