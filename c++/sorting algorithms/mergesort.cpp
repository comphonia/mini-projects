#include "list.h"
#include "listiterator.h"
#include <iostream>
using namespace std;

void mergesort(list *list)
{
    node *secondHalf = divide(list->front());
    node *firstHalf = list->front();
    mergesort(firstHalf);  // recursive call
    mergesort(secondHalf); // recursive call
    list->front() = combine(firstHalf, secondHalf);
}
