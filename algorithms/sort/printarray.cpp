
#include <iostream>
#include "printarray.hpp"

void printarray(int array[])
{
	std::cout << "{ ";

	for (int i = 0; i < sizeof(array) / sizeof(array[0]); i++)
	{
		std::cout << array[i] << ", ";
	}

	std::cout << "}";
}