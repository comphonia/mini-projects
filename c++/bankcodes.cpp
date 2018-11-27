#include <iostream>
using namespace std;

int main()
{
    int sum, checkDigit;
    int bankNumber[8];
    int product[8]; int subtotal[8];
    int weight[] = {7,3,9,7,3,9,7,3};

    for (int i = 0; i <= 8; i++) {
        cout << "Enter bank number " << i+1 << endl;
        cin >> bankNumber[i];
    }
    checkDigit = sizeof(bankNumber)/sizeof(bankNumber[0]);

    //Print output
    for (int k = 0; k <= 8; k++) {
        cout << bankNumber[k] << " ";
    }

    cout << "" << endl;

    for (int j = 0; j < 8; j++) {
        cout << weight[j] << " ";
    }
    cout << "" << endl;

    for (int j = 0; j < 8; j++) {
        product[j] = bankNumber[j] * weight[j];
        cout << product[j] << " ";
    }
    cout << "" << endl;

    for (int j = 0; j < 8; j++) {
        subtotal[0] = product[0];
        if(j != 0)
        subtotal[j] = subtotal[j-1] + product[j];
        cout << subtotal[j] << " ";
    }

    cout << "" << endl;

    sum = subtotal[7];

    cout << sum << endl;
    cout << checkDigit << endl;

    if(sum % 10 == checkDigit)
    {
        cout << "The check code is valid" << endl;
    } else cout << "The check code is invalid" << endl;

}
