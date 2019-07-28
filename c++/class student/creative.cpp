#include <iostream>
#include <string>
using namespace std;
#include "quiz.h"

int main()
{
	int counter=0;
	quiz quizzes[5];
	//populate the array
	for (int i = 0; i < 5; i++)
	{
		quizzes[i] = quiz(i, "Guess the correct number for question " + to_string(i+1));
	}
	//ask questions
	for (int i = 0; i < 5; i++)
	{
		int option = 0;
		cout << quizzes[i].get_question() << endl;
		cin >> option;
		quizzes[i].set_option(option);
		if(quizzes[i].verify_option()){
			counter++;
		}
	}

	//results
	if(counter < 3){
		cout << "Try again, your score is " << counter << " out of " << 5;
	} else
	{
		cout << "Good Job, your score is " << counter << " out of " << 5;
	}
	
}