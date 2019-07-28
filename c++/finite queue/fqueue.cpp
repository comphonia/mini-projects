#include "fqueue.h"
#include <cassert>
#include <stdlib.h>
using namespace std;

fqueue::fqueue(int s) : size(s), ifront(0), iback(-1), count(0)
{
	parray = new int[size];
}

fqueue::~fqueue()
{
	delete[] parray;
}

bool fqueue::empty() const
{
	return count == 0;
}

bool fqueue::full() const
{
	return count == size;
}

int fqueue::length() const
{
	return count;
}

void fqueue::push(int data)
{
	assert(!full());
	++iback;
	if (iback == size)
	{
		iback = 0; 
	}
	parray[iback] = data;
	++count;
}

int fqueue::pop(){
	assert(!empty());
	++ifront;
	int tempIfront = ifront;
	if(ifront == size){
		ifront = 0;
	}
	--count;
	return parray[tempIfront - 1];
}

int fqueue::front() const
{
	assert(!empty());
	return parray[ifront];
}

int fqueue::back() const
{
	assert(!empty());
	return parray[iback];
}