#include "stdafx.h"
#include "Dice.h"

Dice::Dice(void)
{
}

Dice::~Dice(void)
{
}

void Dice::setNumberOfDice(int number)
{
	numberOfDice = number;
}

int Dice::getNumberOfDice()
{
	return numberOfDice;
}

void Dice::setSelectedDice(string selectedDie)
{
	if(find(selectedDice.begin(), selectedDice.end(), selectedDie) != selectedDice.end())
		for (int i = 0; i < diceSides.size(); i++)
			if(diceName[i] == selectedDie)
			{
				selectedDice.push_back(selectedDie);
				break;
			}
}

void Dice::setMultipleDice()
{
	for (int i = 0; i < numberOfDice; i++)
	{
		string choice;
		cin >> choice;
		for (int j = 0; j < diceName.size(); j++)
			if(diceName[j] == choice)
				selectedDice.push_back(choice);
	}
}