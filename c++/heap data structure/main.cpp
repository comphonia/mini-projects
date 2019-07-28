#include "heap.h"
#include <cassert>
#include <algorithm>
#include <iostream>
using namespace std;

int main()
{
	heap h1;
	h1.push(10);
	int n;
	n = h1.top();
	assert(n == 10);

	h1.push(20);
	n = h1.top();
	assert(n == 20);

	h1.push(5);
	n = h1.top();
	assert(n == 20);

	h1.push(25);
	n = h1.top();
	assert(n == 25);

	h1.push(6);

	h1.pop();
	h1.pop();

	//comprehensive testing
	const int N = 5000;
	int data[N];
	for (int i = 0; i < N; i++)
	{
		data[i] = i;
	}

	random_shuffle(&data[0], &data[N]);

	heap test;
	assert(test.size() == 0);
	for (int i = 0; i < N; i++)
	{
		test.push(data[i]);
	}

	for (int i = N - 1; i >= 0; i--)
	{
		assert(test.size() == i + 1);
		assert(test.top() == i);
		test.pop();
	}

	assert(test.size() == 0);

	// creative comprehensive test

	const int F = 5000;
	int data2[F];
	int j = 0;
	for (int i = 0; i < F; i++)
	{
		++j;
		data2[i] = -j;
	}

	random_shuffle(&data2[0], &data2[N]);

	heap test2;
	assert(test2.size() == 0);
	for (int i = 0; i < F; i++)
	{
		test2.push(data2[i]);
	}

	for (int i = -1; i >= -F; i--)
	{
		assert(test2.top() == i);
		test2.pop();
	}
	assert(test2.size() == 0);
}