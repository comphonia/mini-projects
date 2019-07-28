#include <iostream>
#include <fstream>
#include <vector>
#include <ctime>
using namespace std;

void swap(int arr[], int i, int j)
{
	if (i == j)
		return;
	int temp = arr[i];
	arr[i] = arr[j];
	arr[j] = temp;
}

void bubbleSort(int arr[], int size)
{
	for (int lastUnsortedIndex = size - 1; lastUnsortedIndex > 0; lastUnsortedIndex--)
	{
		for (int i = 0; i < lastUnsortedIndex; i++)
		{
			if (arr[i] > arr[i + 1])
				swap(arr, i, i + 1);
		}
	}
}

void print(int arr[], int size)
{
	for (int i = 0; i < size; i++)
	{
		cout << arr[i] << " | ";
	}
}

//Driver
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

	clock_t start = clock();
	bubbleSort(data, N);

	clock_t diff = clock() - start;

	cout << "It took " << diff << " clock ticks";
	cout << "       " << (float)diff / CLOCKS_PER_SEC << " secs" << endl;

	//	print(arr, size);
}