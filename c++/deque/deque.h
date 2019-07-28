#pragma once
#include "node.h"
class deque
{
private:
	node *pfront;
	node *pback;
	int count;

public:
	deque();
	~deque();
	int length() const;
	void push_front(int);
	void push_back(int);
	int front() const;
	int back() const;
	void pop_front();
	void pop_back();

};