a.exe: main.o fqueue.o
	g++ -g main.cpp fqueue.cpp

main.o: main.cpp fqueue.h
	g++ -g -c main.cpp

fqueue.o: fqueue.cpp fqueue.h
	g++ -g -c fqueue.cpp

creative.exe: creative.o fqueue.o
	g++ -g -o creative.exe creative.o fqueue.o

creative.o: creative.cpp fqueue.h
	g++ -g -c creative.cpp