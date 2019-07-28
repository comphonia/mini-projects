#include <string>
#include <iostream>
#include <cassert>
using namespace std;
#include "student.h"

int main()
{
	student s1;
	const int N = 1000;

	int out_of_range = 0;
	for (int i = 1; i <= N; i++)
	{
		try
		{
			s1.set_gpa(3.5);
			assert(s1.get_gpa() == 3.5);
			s1.set_id(i);
			assert(s1.get_id() == i);
		}
		catch (student::out_of_range_gpa e)
		{
			cout << "gpa is out of range!" << endl;
		}
		catch (student::invalid_id e)
		{
			out_of_range ++;
		}
	}

	assert(out_of_range == 50);
}