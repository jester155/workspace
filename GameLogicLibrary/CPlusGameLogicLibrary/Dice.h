#pragma once
#include <string>
#include <algorithm>
#include <iostream>
#include <vector>
#include <array>

using namespace std;

class Dice
{
private:
	array<string,6> diceName;
	array<int,6> diceSides;
	vector<string> selectedDice;
	int numberOfDice;

public:
	Dice(void);
	~Dice(void);
	int Dice::getNumberOfDice();
	void Dice::setNumberOfDice(int);
	void Dice::setSelectedDice(string);
	void Dice::setMultipleDice();
	string* Dice::getSelectedDie();
	int* Dice::rollDice();
	void Dice::resetDice();
};

