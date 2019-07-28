#include "choice_quiz.h"
#include <stdlib.h>
#include <ctime>
#include <iostream>
using namespace std;

choice_quiz::choice_quiz()
{
	srand((unsigned)time(0));
	set_correctOption((rand() % 5) + 1);
	for (int i = 1; i <= 5; i++)
	{
		choices.push_back(generateRandom());
	}
}

string choice_quiz::get_question()
{
	string q = "\n"; 
	cout << quiz::get_question() << endl;//explicitly getting the question from the quiz class
	for (int i = 0; i < choices.size(); i++)
	{
		cout << i + 1 << " " << choices[i] << endl;
	}
	return q;
}

int choice_quiz::generateRandom()
{
	int randNum = (rand() % 500) + 1;
	while (randNum == get_correctOption())
	{
		randNum = (rand() % 500) + 1;
		if (randNum != get_correctOption())
			break;
	}
	return randNum;
}