a.exe: main.o fraction.o
	g++ -g main.o fraction.o

fraction.o: fraction.cpp fraction.h
	g++ -g -c fraction.cpp

main.o: main.cpp fraction.h
	g++ -g -c main.cpp

creative.exe: creative.o fraction.o
	g++ -g -o creative.exe creative.o fraction.o

creative.o: creative.cpp fraction.h
	g++ -g -c creative.cpp