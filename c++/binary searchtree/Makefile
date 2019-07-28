a.exe: main.o bstree.o node.o
	g++ -g main.o bstree.o node.o

main.o: main.cpp bstree.h
	g++ -g -c main.cpp

bstree.o: bstree.cpp bstree.h node.h
	g++ -g -c bstree.cpp

node.o: node.cpp node.h
	g++ -g -c node.cpp