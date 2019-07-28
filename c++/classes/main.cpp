#include <iostream>
#include <string>
using namespace std;
#include "bankaccount.h"
int main()
{
    int n;
    bankaccount b1 =  bankaccount(1,"John");
    cout << "Account for " << b1.get_name() << " with id: " << b1.get_id() << " has been created. " << endl;
    b1.deposit(200); 
    b1.withdrawal(50);
    cout << "Balance for account with id " << b1.get_id() << " is:  " << b1.get_balance() << endl << endl;

    bankaccount b2 =  bankaccount(2,"Alice");
      cout << "Account for " << b2.get_name() << " with id: " << b2.get_id() << " has been created. " << endl;
    b1.set_id(2);
    b2.deposit(50); 
    b2.withdrawal(10);
    cout << "Balance for account with id " << b2.get_id() << " is:  " << b2.get_balance() << endl << endl;


}