#include "bankaccount.h"
#include "checkingaccount.h"
#include "savingsaccount.h"
#include <cassert>
using namespace std;

int main()
{
	//bankaccount b1;
	//bankaccount b2(100);

	//b1.deposit(50.5);
	//b2.withdraw(1.5);

	double n;
	//n = b1.get_balance();
	//n = b2.get_balance();

	checkingaccount c1(100);
	c1.withdraw(10);
	c1.withdraw(10);
	c1.withdraw(10);
	c1.withdraw(10);
	c1.withdraw(10);
	c1.withdraw(10);
	c1.withdraw(10);
	n = c1.get_balance();
	int c = c1.get_ntrans();

	c1.end_of_month();
	n = c1.get_balance();

	savingsaccount s1(100, 0.1); // 10%
	s1.end_of_month();

	bankaccount *accounts[6];
	accounts[0] = new checkingaccount(100);
	accounts[1] = new savingsaccount(100, 0.1);
	accounts[2] = new checkingaccount(100);
	accounts[3] = new savingsaccount(100, 0.1);
	accounts[4] = new checkingaccount(100);
	accounts[5] = new savingsaccount(100, 0.1);

	accounts[0]->deposit(50);
	accounts[1]->withdraw(50);

	// many transactions during the month

	//now is the end of the month
	for (int i = 0; i < 6; i++)
	{
		accounts[i]->end_of_month();
	}

	//Comprehensive testing
	const int N = 2000;

	//checking
	bankaccount *acc1[N];
	for (int i = 0; i < N; i++)
	{
		acc1[i] = new checkingaccount(100 + i);
		assert(acc1[i]->get_balance() == 100 + i);
		acc1[i]->deposit(50);
		assert(acc1[i]->get_balance() == 100 + i + 50);
		acc1[i]->withdraw(50);
		assert(acc1[i]->get_balance() == 100 + i);
	}

	//savings
	bankaccount *acc2[N];
	for (int i = 0; i < N; i++)
	{
		acc2[i] = new savingsaccount(100 + i,0.1);
		assert(acc2[i]->get_balance() == 100 + i);
		acc2[i]->deposit(50);
		assert(acc2[i]->get_balance() == 100 + i + 50);
		acc2[i]->withdraw(50);
		assert(acc2[i]->get_balance() == 100 + i);
	}
}