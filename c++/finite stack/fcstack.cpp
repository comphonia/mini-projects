#include "fcstack.h"
#include <cassert>
#include <stdlib.h>

fcstack::fcstack(int s) : size(s), tos(-1)
{
	parray = new int[s];
}

fcstack::~fcstack()
{
	delete[] parray;
}

bool fcstack::empty() const
{
	return tos == -1;
}

bool fcstack::full() const
{
	return tos == size - 1;
}

void fcstack::push(int i)
{
	if (full())
	{
		++size;
		parray = (int *)realloc(parray, size);
	}
	assert(!full());
	++tos;
	parray[tos] = i;
}

int fcstack::top() const
{
	assert(!empty());
	return parray[tos];
}

int fcstack::pop()
{
	assert(!empty());
	--tos;
	return parray[tos + 1];
}

int fcstack::length() const{
	return size;
}

