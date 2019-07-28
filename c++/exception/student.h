#pragma once

class student
{
private:
	float gpa;
	int id;
	static int count;
	const int STUDENT_LIMIT = 950;

public:
	student();
	student(float);
	student(int);
	student(float, int);
	~student();
	void set_gpa(float);
	void set_id(int);
	float get_gpa() const;
	int get_id() const;
	static int get_count();

	class out_of_range_gpa
	{
	}; //empty
	class invalid_id
	{
	};
};