a.exe: main.o bankaccount.o checkingaccount.o savingsaccount.o
	g++ main.o bankaccount.o checkingaccount.o savingsaccount.o

savingsaccount.o: savingsaccount.cpp savingsaccount.h bankaccount.h
	g++ -c -g savingsaccount.cpp

checkingaccount.o: checkingaccount.cpp checkingaccount.h bankaccount.h
	g++ -c -g checkingaccount.cpp

main.o: main.cpp bankaccount.h savingsaccount.h
	g++ -g -c main.cpp

bankaccount.o: bankaccount.cpp bankaccount.h
	g++ -g -c bankaccount.cpp