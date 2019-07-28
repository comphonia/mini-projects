#include "bstree.h"
#include <cassert>
#include <iostream>
using namespace std;

void f1(int n)
{
	cout << "[" << n << "]"
		 << " ";
}

int total = 0;
void sum(int n)
{
	total += n;
}

int main()
{
	bstree t1;
	// t1.insert(5);
	// t1.insert(4);
	// t1.insert(7);
	// t1.insert(3);

	const int N = 14;
	int data[] = {15, 20, 6, 7, 5, 19, 22, 1, 3, 10, 30, 2, 14, 29};
	int s = 0;
	for (int i = 0; i < N; i++)
	{
		t1.insert(data[i]);
		s += data[i];
	}

	t1.inorder(f1);
	t1.inorder(sum);
	cout << "total is " << total << endl;
	assert(s == total);
	cout << endl;
	t1.preorder();
	cout << endl;
	t1.postorder();
	cout << endl;

	t1.breadth_first();
	cout << endl;

	//comprehensive testing
	const int R = 2000;
	bstree t2;
	for (int i = 0; i < R; i++)
	{
		t2.insert(i);
	}
	//t2.postorder();
	assert(t2.node_count() == 2000);
	assert(t2.layer_count() == 2000);
	assert(t2.leaf_count() == 1);
	assert(t2.height() == 1999);
	assert(t2.find_min() == 0);
	t2.erase(0); // erase the min
	assert(t2.find_min() == 1);
	

	// assert(t1.layer_count() == 6);
	// assert(t1.height() ==5);
	// t1.erase(15);
	// assert(t1.layer_count() == 6);
	// t1.erase(2);
	// assert(t1.layer_count() == 5);
	// assert(t1.height() == 4);

	// int n = t1.node_count();
	// assert(n == 14);
	// assert(t1.leaf_count() == 4);
	// t1.erase(19);
	// assert(t1.leaf_count() == 3);

	// int min = t1.find_min();
	// t1.erase(5);
	// assert(t1.node_count() == 12);
	//t1.print();
}