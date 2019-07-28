#include "baseball.h"
#include <string>
#include <iostream>
using namespace std;

baseball::baseball() : generatedKey("-1"), guessCount(1)
{
	string key = generateKey();
	generatedKey = key;
	cout << "DEBUG: "
		 << "baseball"
		 << " key: " << key << endl;
	cout << "Play Baseball!! ";
	string input;
	do
	{
		cout << "[" << guessCount << "] Your guess: ";
		cin >> input;
	} while (!validateInput(input));
}
// validate user input based on requirements
bool baseball::validateInput(string input)
{
	int num;
	try
	{
		num = stoi(input);
		if (input.length() != 3)
		{
			cout << "  Invalid guess: Error: guess must be 3 digits" << endl;
			return false;
		}
		for (int i = 0; i < input.length(); i++)
		{
			for (int j = i + 1; j < input.length(); j++)
			{
				if (input[i] == input[j])
				{
					cout << "  Invalid guess: Error: guess cannot have repeating digits" << endl;
					return false;
				}
			}
		}
		if (num == stoi(generatedKey))
		{
			showBS(input);
			cout << "  Struck out! " << guessCount << " attempts" << endl;
			//save game
			game::saveStats("baseball", guessCount);
			return true;
		}
		else
		{
			guessCount++;
			showBS(input);

			return false;
		}
	}
	catch (const std::exception &e)
	{
		cout << "  Invalid guess: Error: guess must be digits (0-9) only" << endl;
	}
	return false;
}
// show the user ball & strikes
void baseball::showBS(string input)
{
	int B = 0, S = 0;
	for (int i = 0; i < 3; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			if (generatedKey[i] == input[j] && i == j)
			{
				S++;
			}

			else if (generatedKey[i] == input[j] && i != j)
			{
				B++;
			}
		}
	}
	cout << "  B=" << B << " S=" << S << endl;
}
// generate a random unique 3 digit key
string baseball::generateKey()
{
	string key = "";
	int randBaseball[3];

	int num;
	randBaseball[0] = rand() % 10;
	for (int i = 1; i < 3; i++)
	{
		do
		{
			num = rand() % 10;
		} while (num == randBaseball[i - 1] || num == randBaseball[0]);
		randBaseball[i] = num;
	}
	for (int i : randBaseball)
	{
		key += to_string(i);
	}

	return key;
}