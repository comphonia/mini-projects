#include "wordguess.h"
#include <string>
#include <cstring>
#include <iostream>
#include <fstream>
using namespace std;

wordguess::wordguess() : generatedKey("-1"), guessCount(1), inputString(""), alphabet("abcdefghijklmnopqrstuvwxyz")
{
	string key = generateKey();
	generatedKey = key;
	cout << "DEBUG: "
		 << "wordguess"
		 << " key: " << key << endl;
	cout << "Play Wordguess!! ";
	string input;
	do
	{
		cout << "[" << guessCount << "] Your guess [" << inputString << "] Choose: [" << alphabet << "] ";
		cin >> input;
	} while (!validateInput(input));
}

// required checks for input
bool wordguess::validateInput(string input)
{
	if (input.length() > 1)
	{
		cout << "  Invalid guess: Error: guess must be 1 character" << endl;
		return false;
	}
	if (isdigit(input[0]) || isspace(input[0]))
	{
		cout << "  Invalid guess: Error: guess must be an alphabet" << endl;
		return false;
	}
	if (isalpha(input[0]) && input.length() == 1)
	{
		// does it exist?
		if (pushChar(input[0]))
		{
			if (isWordGuessed())
			{
				//save game
				game::saveStats("wordgame", guessCount);
				cout << "You got it! " << guessCount << " attempts" << endl;
				return true;
			}
			return false;
		}
	}
	return false;
}

// check if each character input is an alphabet and appends it to a string if it does not already exist
bool wordguess::pushChar(char c)
{
	bool isError = true;
	for (int i = 0; i < alphabet.length(); i++)
	{
		if (c == alphabet[i])
		{
			alphabet[i] = '.';
			isError = false;
			break;
		}
	}

	for (int i = 0; i < inputString.length(); i++)
	{
		if (c == inputString[i])
		{
			isError = true;
		}
	}
	if (isError)
	{
		cout << " Invalid guess: Error: the letter <" << c << "> has already been used" << endl;
		return false;
	}
	populateInputString(generatedKey, c);

	return true;
}
// generate a random word
string wordguess::generateKey()
{
	readWordsFromFile();
	string key = "";
	int num = rand() % wordpool.size();
	key = wordpool[num];
	populateInputString(key, ' ');
	return key;
}
// read words into a vector from a text file
void wordguess::readWordsFromFile()
{
	ifstream inFile;
	string fileName = "wordpool.txt";
	string word;
	inFile.open(fileName);

	while (inFile >> word)
	{
		wordpool.push_back(word);
	}
	inFile.close();
}

//generate mask for the input string
void wordguess::populateInputString(string key, char input = ' ')
{
	bool isCorrect = false;
	if (inputString.length() == 0)
	{
		for (int i = 0; i < key.length(); i++)
		{
			inputString += '.';
		}
		return;
	}
	else
	{
		for (int j = 0; j < inputString.length(); j++)
		{
			if (input == key[j])
			{
				inputString[j] = key[j];
				isCorrect = true;
			}
		}
		if (isCorrect)
			guessCount++;
	}

	//	inputString = str;
}

// test to see if all the characters make up the key
bool wordguess::isWordGuessed()
{
	for (int i = 0; i < generatedKey.length(); i++)
	{
		if (inputString[i] != generatedKey[i])
			return false;
	}
	return true;
}