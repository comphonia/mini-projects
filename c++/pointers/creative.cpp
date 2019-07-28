#include <iostream>
using namespace std;

//function prototypes
void map(int *, char, int, int);
void print(int *, int);

//driver
int main()
{
    int a[5] = {1, 4, 9, 16};
    map(a, '/', 2, 4);
    print(a, 4);
}

//map every element
void map(int *arr, char op, int value, int size)
{
    if (op == '+')
        for (int i = 0; i < size; i++, arr++)
        {
            *arr = *arr + value;
        }
    else if (op == '-')
        for (int i = 0; i < size; i++, arr++)
        {
            *arr = *arr - value;
        }
    else if (op == '*')
        for (int i = 0; i < size; i++, arr++)
        {
            *arr = *arr * value;
        }
    else if (op == '/')
        for (int i = 0; i < size; i++, arr++)
        {
            *arr = *arr / value;
        }
}

//printer
void print(int *arr, int size)
{
    for (int i = 0; i < size; i++, arr++)
    {
        cout << *arr << endl;
    }
}
