#include "myutil.h"
#include <cassert>
#include <iostream>
using namespace std;

int myutil::sum(int n)
{
	assert(n >= 0);
	if (n == 0)
		return 0; // base case
	else
		return sum(n - 1) + n;
}

// 0! = 1
// 1! = 1
// 2! = 1x2
int myutil::fact(int n)
{
	assert(n >= 0);
	if (n == 0)
		return 1;
	else
		return fact(n - 1) * n;
}

int myutil::pow(int n, int exp)
{
	if (exp == 0)
		return 1; //base case
	else
		return pow(n, exp - 1) * n;
}

int myutil::fib(int n)
{
	if (n == 0)
		return 0;
	else if (n == 1)
		return 1;
	return fib(n - 1) + fib(n - 2);
}

int myutil::sum(int values[], int size)
{
	assert(size > 0);
	if (size == 1)
		return values[0];
	else
		return sum(values, size - 1) + values[size - 1];
}

int myutil::largest(int data[], int size)
{
	assert(size > 0);
	if (size == 1)
		return data[0];
	else
	{
		int m = largest(data, size - 1);
		return max(m, data[size - 1]);
	}
}

int myutil::smallest(int data[], int size)
{
	assert(size > 0);
	if (size == 1)
		return data[0];
	else
	{
		int m = smallest(data, size - 1);
		return min(m, data[size - 1]);
	}
}

void myutil::hanoi(int ndisks)
{
	return rhanoi(ndisks, 1, 3, 2);
}

void myutil::rhanoi(int ndisks, int s, int d, int t)
{
	assert(ndisks > 0);
	if (ndisks == 1)
	{
		cout << "move from " << s << " to " << d << endl;
	}
	else
	{
		rhanoi(ndisks - 1, s, t, d);
		cout << "move from " << s << " to " << d << endl;
		rhanoi(ndisks - 1, t, d, s);
	}
}

//creative
int myutil::max(int a, int b)
{
	if (a > b)
		return a;
	else
		return b;
}

int myutil::min(int a, int b)
{
	if (a < b)
		return a;
	else
		return b;
}