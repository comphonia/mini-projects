#pragma once
#include "person.h"

class bankaccount
{
private:
	int id;
	double balance;
	person owner;
	person* pjoint_owner;
public:
	static int id_gen;
	bankaccount();			  // default constructor
	bankaccount(double);	  // balance
	bankaccount(string, int); // owner info
	~bankaccount(); //destructor
	int get_id() const;
	void deposit(double);
	void withdraw(double);
	double get_balance() const;
	void set_jointowner(string,int);
};