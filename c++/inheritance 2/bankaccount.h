#pragma once

//abstract class (has at least one pure virtual fn) cannot create an object
class bankaccount
{
private:
	double balance;

public:
	bankaccount();
	bankaccount(double); //balance
	double get_balance() const;
	void deposit(double);
	void withdraw(double);
	// pure (=0) virtual function - satisfies static binding at compile time
	virtual void end_of_month() = 0;
};