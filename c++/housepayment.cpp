#include <iostream>
#include <cmath>
using namespace std;


double computePayment (double p,double mir , double yir);


double interestRate, payment, principal, years;

int main() {

    cout << "Enter the principal" << endl;
    cin >> principal;
    cout << "Enter the yearly interest rate" << endl;
    cin >> interestRate;
    interestRate;
    cout << "Enter the number of years" << endl;
    cin >> years;

    cout << "Principal " << principal << "  Interest Rate " << interestRate << "  Years " << years << "  Payment " << computePayment(principal,interestRate,years) << endl;

    return 0;
}

double computePayment (double p,double yir , double y)
{
    double a,b,c,d,e,f,mir;

    mir = yir/1200;

    a = 1+mir;

    b = 1/a;

    c= 12*y;

    d = pow(b,c);

    e = 1-d;

    f = ceil((p*mir)*100)/100;

    payment = ceil((f/e)*100)/100;


    return payment;
}
