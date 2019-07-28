#include <iostream>
using namespace std;

void f1(int *, int);
int main()
{
    int a[5] = {20, 3, 4, 5, 6};
    f1(a, 5);
}

void f1(int *p, int size)
{
    for (int i = 0; i < size; i++)
    {
        cout << *(p + i) << endl;
    }
}
