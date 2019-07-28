#include "deque.h"
#include <iostream>
#include <cassert>
#include <random>
#include <ctime>
using namespace std;

void populate(deque &);
void swap(deque &, int);

int main()
{
	deque m;
	populate(m);
	swap(m, m.length());
}

void populate(deque &m)
{
	// 1 2 3 4 5 to queue
	for (int i = 1; i <= 5; i++)
	{
		m.push_back(i);
	}
	assert(m.front() == 1);
	assert(m.back() == 5);
	assert(m.length() == 5);
}

void swap(deque &m, int length)
{
	// swaps first and last elements to 5 2 3 4 1
	int front = m.front();
	int back = m.back();

	m.pop_front();
	m.pop_back();
	m.push_front(back);
	m.push_back(front);

	assert(m.front() == 5);
	assert(m.back() == 1);
	assert(m.length() == 5);
}
