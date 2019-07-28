#include "list.h"
#include "listiterator.h"
#include <iostream>
#include <cassert>
using namespace std;

void print(list &);

main()
{
	list m;

	m.push_back(1);
	assert(m.front() == 1);
	assert(m.back() == 1);

	m.push_back(2);
	assert(m.front() == 1);
	assert(m.back() == 2);

	m.push_front(0);
	assert(m.front() == 0);
	assert(m.back() == 2);

	m.pop_front();
	assert(m.front() == 1);
	assert(m.back() == 2);

	m.pop_back();
	assert(m.front() == 1);
	assert(m.back() == 1);
	m.push_front(2);
	m.push_front(3);
	m.push_front(4);

	listiterator it = m.begin();
	int n = it.get();
	it.next();
	n = it.get();
	it.next();
	n = it.get();
	it.next();
	n = it.get();
	it.next();
	it.prev();
	n = it.get(); //tail
	it.prev();
	n = it.get();

	list test;
	for (int i = 0; i < 5; i++)
	{
		test.push_back(i);
	}

	print(test);

	it = test.begin();
	it.next();
	it.next();
	it.next();
	it.next();
	it.next();
	test.insert(it, 100);
	print(test);

	cout << "testing for erase()" << endl;

	list mm;
	for (int i = 0; i < 5; i++)
	{
		mm.push_back(i * 10);
	}

	print(mm);
	it = mm.begin();
	mm.erase(it);
	print(mm);
	it.next();
	mm.erase(it);
	print(mm);
	it.next();
	mm.erase(it);
	print(mm);
	it.prev();
	mm.erase(it);
	print(mm);
	it.prev();
	mm.erase(it);
	cout << "the only one is erased" << endl;
	print(mm);

	//comprehensive test
	cout << "start comprehensive test" << endl;

	const int N = 1000;
	list comp;

	//generate 1000 data
	for (int i = 0; i < N; i++)
	{
		comp.push_back(i);
	}
	it = comp.begin();

	// insert 88 in place of every even number
	for (int i = 0; i < N; i++)
	{
		it.next();
		if (i % 2 == 0)
			comp.insert(it, 88);
	}

	// erase left-half the data
	for (int i = 0; i < N; i++)
	{
		it.prev();
		comp.erase(it);
	}

	print(comp);
}
void print(list &mm)
{
	listiterator iter = mm.begin();
	while (!iter.equals(mm.end()))
	{
		cout << iter.get() << " ";
		iter.next();
	}
	cout << endl;
}