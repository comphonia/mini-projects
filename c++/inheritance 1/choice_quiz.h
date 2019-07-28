#pragma once
#include "quiz.h"
#include <vector>
using namespace std;

class choice_quiz : public quiz
{
private:
	vector<int> choices;

public:
	choice_quiz();
	virtual string get_question();
	int generateRandom();
};