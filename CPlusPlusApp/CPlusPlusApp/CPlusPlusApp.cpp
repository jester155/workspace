// CPlusPlusApp.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "Dice.h"
#include <iostream>
#include <sstream>
#include <time.h>

using namespace std;

string myName(void);
int favNumber(void);
string coinFlip(void);
int addUp(int[] , int);
void diceTest(void);

int main()
{
	//string color;
	//string firstName;
	//stringstream sstm;
	//stringstream conculusion;

	//cout << "Hello World!" << endl;
	//sstm << "Welcome to this simple C++ Application by "  << myName();
	//cout << sstm.str() << endl;

	//cout << "What is your name? ";
	//cin >> firstName;

	//cout << "What is your favorite color? ";
	//cin >> color;
	//

	//cout << "Enter 5 numbers and I will add them up" << endl;
	//	int numbers[5];
	//for (int i = 0; i < 5; i++)
	//{
	//	cin >> numbers[i];
	//}
	//
	//conculusion << "Well " << firstName << ", this is the end of the application. If I have this correcrt:\nyour favorite color is " 
	//	<< color << " and the numbers you chose add up to " << addUp(numbers , 5); 
	//
	//cout << conculusion.str() << endl;

	diceTest();

	cout << "\nPress any key to exit";
	cin.ignore();
	getchar();
	return 0;
}

int addUp(int args[] , int length)
{
	int total = 0;
	for (int i = 0; i < length; i++)
	{
		total += args[i];
	}
	return total;
}

string myName() 
{
	return "Mark Provenzano";
}

string coinFlip()
{
	srand(time(NULL));
	int number = rand() % 2;
	if (number == 0)
	{
		return "Tails";
	}
	else
	{
		return "Heads";
	}
}

void diceTest(void)
{
	stringstream x;
	Dice dice; //.Creates an object called dice

		dice.setNumberOfDice(3);//.Sets the number of dice to 3
		cout << "Enter in three dice you would like to use. d4, d12, d6, etc." << endl;//.Prompts the user
		cout << "press enter after each input" << endl;
		dice.setMultiDice();//.Asks the user to put in tree dice in the console

		int *roller = 0;
		roller = dice.rollDice();

		string *diceToUse = NULL;
		diceToUse = dice.getSelectedDice();

		for (int i = 0; i < dice.getNumberOfDice(); i++) //.Loops to display all the results to the console.
		{
			//cout << diceToUse[i] << ": ";//.Gets the dice that the user input
			x << roller[i] << endl; //.Shows the result of each dice rolled.
		}

		cout << x.str();
}

