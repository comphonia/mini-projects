#include <iostream>
using namespace std;

int main()
{
    int n = 10;
    double d = 1.2;

    int *p; // pointer
    p = &n;

    *p = 55; // n = 55

    int b;
    b = *p; //indirect operator
}
