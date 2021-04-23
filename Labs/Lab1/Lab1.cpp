/*
Declare variables of type int, float, double and char. Assign some example values to them.
Display the values
Declare pointers for int, float, double and char. Set the pointers to the created variables.
Display the values using pointers
Change the values using pointers. Display the values using pointers. Then display the same
values using the variables
Then display the values of raw pointers
*/

#include <iostream>
using namespace std;

int main()
{
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

    *pa = 200;
    *pb = 0.4;
    *pc = 0.01;
    *pd = 'x';

    cout << *pa << " " << *pb << " " << *pc << " " << *pd << endl;
    cout << a << " " << b << " " << c << " " << d << endl;

    cout << pa << " " << pb << " " << pc << " " << pd << endl;
}
