#pragma once
#include <iostream>
using namespace std;

template <typename T>
class tnode{
	private:
		T data;
		tnode<T>* link;
	public:
		tnode(int); //data

	template <typename U> friend class tstack;
};


template <typename T>
tnode<T>::tnode(int d) : data(d), link(nullptr)
{
}