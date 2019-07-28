a.exe: main.o fstack.o
	g++ -g main.o fstack.o

main.o: main.cpp fstack.h
	g++ -c main.cpp

fstack.o: fstack.cpp fstack.h
	g++ -c fstack.cpp

creative.exe: creative.o fcstack.o
	g++ -g -o creative.exe creative.o fcstack.o

creative.o: creative.cpp fcstack.h
	g++ -c creative.cpp

fcstack.o: fcstack.cpp fcstack.h
	g++ -c fcstack.cpp