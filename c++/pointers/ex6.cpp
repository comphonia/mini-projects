#include <iostream>
using namespace std;

int main()
{
   double *p = new double;

   *p = 1.3;

   cout << *p << endl;

   delete p;
}

