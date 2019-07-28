#pragma once
#include <string>
using namespace std;

class quiz
{
private:
	int id;
	string question;
	int correct_option;
	int selected_option;

public:
	quiz();
	quiz(int, string);
	void set_option(int);
	string get_question();
	int get_id();
	bool verify_option() const;
};
