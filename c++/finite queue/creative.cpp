#include <iostream>
#include <cassert>
using namespace std;
#include "fqueue.h"

int main()
{
	const int N = 10;
	fqueue test(N);
	assert(test.empty());
	assert(!test.full());
	assert(test.length() == 0);

	for (int i = 0; i < N; i++)
	{
		test.push(i);
		assert(test.front() == 0);
		assert(test.back() == i);
		assert(!test.empty());
	}
	assert(test.full());

	for (int i = 0; i < N; i++)
	{
		assert(test.front() == i);
		assert(test.back() == N - 1);
		cout << test.pop() << endl;
	}
	assert(test.empty());

	// tests for a push and pop, should be an empty queue at the end of each iteration
	for (int i = 0; i < N; i++)
	{
		test.push(i);
		test.pop();
		assert(test.empty());
	}
}