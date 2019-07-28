#include "fraction.h"
#include <cassert>
#include <iostream>
using namespace std;

int main()
{
	fraction c;
	fraction a(3, 1), b(2, 1);
	bool d;
	//add
	c = a + b;
	assert(c == 5);
	//subtract
	c = a - b;
	assert(c == 1);
	//multiply
	c = a * b;
	assert(c == 6);
	//divide
	c = a / b;
	assert(c == 1.5);
	//greater than comparison
	d = a > b;
	assert(d == true);
	//less than comparison
	d = a < b;
	assert(d == false);
	//greater or equal to comparison
	d = a >= b;
	assert(d == true);
	//less or equal to comparison
	d = a <= b;
	assert(d == false);
	//equal to comparison
	d = a == b;
	assert(d == false);
	//preincrement
	assert(++a == 4);
	//postincrement
	assert(a++ == 4); // a = 5
	//predecrement
	assert(--a == 4); // a = 4
	//postdecrement
	assert(a-- == 4);
	assert(a == 3);
	//ostream
	cout << "Final value of a: " << a;
}