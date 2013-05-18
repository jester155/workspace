#include "stdafx.h"
#include "Test.h"
#include <string>

Test::Test(void)
{
}


Test::~Test(void)
{
}

void Test::setAnswers(void)
{
	for (int i = 0 ; i < sizeof(answers) ; i++)
	{
		std::cin >> answers[i];
	}
}

void Test::setQuestions(void)
{
	for (int i = 0; i < sizeof(questions); i++)
	{
		std::cin >> questions[i];
	}
}