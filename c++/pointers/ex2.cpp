#include <iostream>
using namespace std;

int main()
{
    int a[5] = {1, 2, 3, 4, 5};

    if (a == &a[0])
    {
        cout << "true" << endl;
    }

    int *p = a;
    int* xx =a;
    for (int i = 0; i < 5; i++)
    {
        cout << a[i] << " " <<  *p << " " << *(xx+i) << endl;
        ++p;
    }

    double d[5] = {1.1, 2.2, 3.3, 4.4, 5.5};

    double *y = &d[0];

    for (int i = 0; i < 5; i++)
    {
        cout << *y<< endl;
        ++y;
    }
}
