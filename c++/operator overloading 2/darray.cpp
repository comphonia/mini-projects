#include "darray.h"
#include <cassert>
using namespace std;

darray::darray(int c) : capacity(c)
{
	parray = new double[capacity];
}

darray::~darray()
{
	delete[] parray;
}

//copy constructor
darray::darray(const darray &right)
{
	if (this == &right)
	{
		return;
	}
	capacity = right.capacity;
	parray = new double[capacity];
	for (int i = 0; i < capacity; i++)
	{
		parray[i] = right.parray[i];
	}
}

void darray::set(int pos, double value)
{
	assert(0 <= pos && pos < capacity);
	parray[pos] = value;
}

double darray::get(int pos) const
{
	assert(0 <= pos && pos < capacity);
	return parray[pos];
}

darray &darray::operator=(const darray &right)
{
	//of the same size only
	assert(capacity == right.capacity);
	if (this == &right)
	{
		return *this;
	}
	for (int i = 0; i < capacity; i++)
	{
		parray[i] = right.parray[i];
	}

	return *this;
}

double darray::operator[](int pos) const
{
	assert(0 <= pos && pos < capacity);
	return parray[pos];
}

double &darray::operator[](int pos)
{
	assert(0 <= pos && pos < capacity);
	return parray[pos];
}

darray darray::operator+(const darray &right) const
{
	assert(capacity == right.capacity);
	darray result(capacity);
	for (int i = 0; i < capacity; i++)
	{
		result[i] = parray[i] + right[i];
	}
	return result;
}

darray darray::operator+(double value) const
{
	darray result(capacity);
	for (int i = 0; i < capacity; i++)
	{
		result[i] = parray[i] + value;
	}
	return result;
}

//non-member function
darray operator+(double value, const darray &right)
{
	darray result(right.capacity);
	for (int i = 0; i < right.capacity; i++)
	{
		result[i] = value + right.parray[i];
	}
	return result;
}