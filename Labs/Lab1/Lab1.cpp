

#include <iostream>
using namespace std;

void task1();
void task2();
void task3();
void task5();

int main()
{
    int const size = 5;
    int myArray[size] = { 1, 2, 3, 4, 5 };

    int* p1 = myArray;
    int* p2 = p1 + size - 1;

    for (int i = 0; i < size/2; i++) {
        swap(*p1, *p2);
        p1++;
        p2--;
    }
    for (int a : myArray)cout << a << "  ";
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
    *pb = 0.4f;
    *pc = 0.01;
    *pd = 'x';

    cout << *pa << " " << *pb << " " << *pc << " " << *pd << endl;
    cout << a << " " << b << " " << c << " " << d << endl;

    cout << pa << " " << pb << " " << pc << " " << pd << endl;
}
void task2() {
    int myArray[] = { 6, 9, 10, 1, 21 };

    int* pointer = myArray;

    for (int i = 0; i < 5; i++)
    {
        cout << *(pointer++) << endl;
    }
}
void task3() {
    int myArray[5];
    int* pointer = myArray;

    for (int i = 0; i < 5; i++)
    {
        cin >> *pointer++;
    }
}

void task5() {
    int* x = new int;

    //cout << *x << endl;
    *x = 6;
    cout << *x << endl;

    delete x;
    //cout << *x << endl;

    x = NULL;
    //cout << *x << endl;
}