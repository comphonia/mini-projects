#include "quiz.h"
#include <stdlib.h>

quiz::quiz() {}
quiz::quiz(int i, string q)
{
	id = i;
	question = q;
	correct_option = rand() % 5 + 1;
}

void quiz::set_option(int num)
{
	selected_option = num;
}

string quiz::get_question()
{
	return question;
}

int quiz::get_id() { return id; }

bool quiz::verify_option() const
{
	if (correct_option == selected_option)
		return true;
	return false;
}
