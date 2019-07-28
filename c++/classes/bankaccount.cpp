#include "bankaccount.h"

bankaccount::bankaccount(int _id, string _name)
{
    id = _id;
    name = _name;
}

void bankaccount::set_id(int n)
{
    id = n;
}
int bankaccount::get_id()
{
    return id;
}
string bankaccount::get_name()
{
    return name;
}
double bankaccount::get_balance()
{
    return balance;
}
double bankaccount::deposit(double b)
{
    return balance += b;
}
double bankaccount::withdrawal(double b)
{
    return balance -= b;
}