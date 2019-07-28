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
	void set_question(string);
	void set_option(int);
	virtual void set_correctOption(int);
	virtual string get_question();
	int get_correctOption() const;
	int get_id();
	bool verify_option() const;
};
