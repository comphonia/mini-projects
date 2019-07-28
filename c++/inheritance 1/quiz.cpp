#include "quiz.h"
#include <stdlib.h>
#include <ctime>
#include <iostream>

quiz::quiz()
{
	srand((unsigned)time(0)); 
	set_correctOption((rand() % 5)+ 1);
}

void quiz::set_question(string q)
{
	question = q;
}
void quiz::set_correctOption(int num)
{
	correct_option = num;
}

void quiz::set_option(int num)
{
	selected_option = num;
}

string quiz::get_question()
{
	return question;
}

int quiz::get_correctOption() const
{
	return this->correct_option;
}

int quiz::get_id() { return id; }

bool quiz::verify_option() const
{
	if (correct_option == selected_option)
		return true;
	return false;
}
