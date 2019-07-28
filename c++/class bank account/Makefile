a.exe: person.o bankaccount.o main.o
	g++ -g person.o bankaccount.o main.o

person.o: person.cpp person.h
	g++ -g -c person.cpp

bankaccount:o bankaccount.cpp bankaccount.h person.h
	g++ -g -c bankaccount.cpp

main.o: main.cpp bankaccount.h
	g++ -g -c main.cpp