#pragma once

class myutil
{
private:
	static void rhanoi(int, int, int, int);
	static int max(int, int);
	static int min(int, int);
public:
	static int sum(int);		// 0 + 1 + ... + n
	static int sum(int[], int); // array sum
	static int fact(int);		// n!
	static int pow(int, int);   // n^pow
	static int fib(int);
	static int largest(int[], int);
	static int smallest(int[], int);
	static void hanoi(int);
};