a.exe: node.o list.o main.o listiterator.o
	g++ -g node.o list.o main.o listiterator.o

node.o: node.cpp node.h
	g++ -g -c node.cpp

listiterator.o: listiterator.cpp listiterator.h node.h list.h
	g++ -g -c listiterator.cpp

list.o: list.cpp list.h node.h
	g++ -g -c list.cpp

main.o: main.cpp list.h
	g++ -g -c main.cpp