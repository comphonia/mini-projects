#include <string>
using namespace std;
class bankaccount
{
private:
    int id;
    string name;
    double balance;
    int n;

public:
    bankaccount(int id, string name);
    void set_id(int n);
    int get_id();
    string get_name();
    double get_balance();
    double deposit(double b);
    double withdrawal(double b);
};