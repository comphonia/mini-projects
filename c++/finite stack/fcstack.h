class fcstack
{
private:
	int *parray;
	int size; // size of the array
	int tos;  //index of the top of the stack
public:
	fcstack(int);
	~fcstack();
	bool empty() const;
	bool full() const;
	void push(int); // dynamic push
	int top() const;
	int pop();	 // pop returns popped value
	int length() const; // returns the size of the array
};