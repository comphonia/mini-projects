#include <iostream>
using namespace std;

int main()
{
 const int GB = 1024 * 1024 * 1024;
 for (int i = 1; i < 1000000; i++)
 {
    int* p = new int[GB]; //4GB
    cout << "Allocating " << i * 4 << " GB" << endl; 

    //delete [] p;
 }
 
}

