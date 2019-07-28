m.exe: main.o student.o
	g++ -g -o m.exe main.o student.o

main.o: main.cpp student.h
	g++ -g -c main.cpp

student.o: student.cpp student.h
	g++ -g -c student.cpp

creative.exe: creative.o quiz.o
	g++ -g -o creative.exe creative.o quiz.o

quiz.o: quiz.cpp quiz.h
	g++ -g -c quiz.cpp

creative.o: creative.cpp quiz.h
	g++ -g -c creative.cpp



