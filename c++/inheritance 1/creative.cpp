#include <iostream>
#include <string>
using namespace std;
#include "quiz.h"
#include "choice_quiz.h"

int main()
{
	int counter = 0;

	//Generate question
	cout << "Single Question ----------------" << endl;
	quiz q;
	q.set_question("Guess a correct number from 0 to 5 ");

	//ask questions
	int option = 0;
	cout << q.get_question() << endl;
	cin >> option;
	q.set_option(option);
	if (q.verify_option())
	{
		cout << "Great Job, your answer was correct. " << endl;
	}
	else
	{
		cout << "Wrong answer, the correct answer is " << q.get_correctOption() << endl
			 << endl;
	}

	//Generate question
	cout << "Choice Questions ----------------" << endl;
	choice_quiz cq;
	cq.set_question("Select the correct random number ");

	//ask questions
	option = 0;
	cout << cq.get_question();
	cin >> option;
	cq.set_option(option);
	if (cq.verify_option())
	{
		cout << "Great Job, your answer was correct. " << endl;
	}
	else
	{
		cout << "Wrong answer, the correct answer is " << cq.get_correctOption();
	}
}