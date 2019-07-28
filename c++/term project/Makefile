a.exe: tp.o game.o baseball.o wordguess.o tictactoe.o
	g++ -g tp.o game.o baseball.o wordguess.o tictactoe.o

baseball.o: baseball.cpp baseball.h
	g++ -g -c baseball.cpp

wordguess.o: wordguess.cpp wordguess.h
	g++ -g -c wordguess.cpp
	
tictactoe.o: tictactoe.cpp tictactoe.h
	g++ -g -c tictactoe.cpp

game.o: game.cpp game.h baseball.h wordguess.h tictactoe.h
	g++ -g -c game.cpp

tp.o: tp.cpp game.h
	g++ -g -c tp.cpp
