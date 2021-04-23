

#include <iostream>
using namespace std;

void task1();
/*
Declare an array of 5 int elements. Using pointers iterate over the array to display the
elements
*/
int main()
{
    int myArray[] = { 6, 9, 10, 1, 21 };

    int* pointer = myArray;

    for (int i = 0; i < 5; i++)
    {
        cout << *(pointer++) << endl;
    }
}

void task1() {
    int a = 100;
    float b = 90.5;
    double c = 100.2;
    char d = 'a';

    cout << a << " " << b << " " << c << " " << d << endl;

    int* pa = &a;
    float* pb = &b;
    double* pc = &c;
    char* pd = &d;

    cout << *pa << " " << *pb << " " << *pc << " " << *pd << endl;
    cout << pa << " " << pb << " " << pc << " " << pd << endl;

    *pa = 200;
    *pb = 0.4;
    *pc = 0.01;
    *pd = 'x';

    cout << *pa << " " << *pb << " " << *pc << " " << *pd << endl;
    cout << a << " " << b << " " << c << " " << d << endl;

    cout << pa << " " << pb << " " << pc << " " << pd << endl;
}