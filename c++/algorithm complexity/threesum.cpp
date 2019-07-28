#include <iostream>
#include <fstream>
#include <vector>
#include <ctime>
using namespace std;
int main(int argc, char **argv)
{
	if (argc != 2)
	{
		cout << "Usage: " << argv[0] << "datafile" << endl;
		return 1;
	}
	ifstream infile(argv[1]);
	if (infile.fail())
	{
		cout << "Cannot open " << argv[1] << endl;
		return 1;
	}

	vector<int> vdata;
	int n;
	while (infile >> n)
	{
		vdata.push_back(n);
	}

	//convert vector to int array for faster computing
	int *data = vdata.data();
	int N = vdata.size();

	//3 sum
	int count = 0;

	clock_t start = clock();

	for (int i = 0; i < N; i++)
	{
		for (int k = i + 1; k < N; k++)
		{
			for (int m = k + 1; m < N; m++)
			{
				if (data[i] + data[k] + data[m] == 0)
					++count;
			}
		}
	}

	clock_t diff = clock() - start;

	cout << "count is " << count << endl;
	cout << "It took " << diff << " clock ticks";
	cout << "       " << (float)diff / CLOCKS_PER_SEC << " secs" << endl;
}