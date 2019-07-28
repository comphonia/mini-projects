#include <iostream>
#include <cassert>
using namespace std;

#include "fcstack.h"

int main()
{
	fcstack fcs1(3);
	fcs1.push(1);
	assert(!fcs1.empty());
	fcs1.push(2);
	fcs1.push(3);
	assert(fcs1.full());
	fcs1.push(4);
	assert(fcs1.full());
	cout << fcs1.pop() << endl;
	cout << fcs1.pop() << endl;
	assert(!fcs1.full());
	assert(fcs1.length() == 4);
}