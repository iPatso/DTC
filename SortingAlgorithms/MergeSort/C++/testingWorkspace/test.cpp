#include <iostream>

using namespace std;

void doSomething(int arr[]);

int main(int argc, const char* argv[]) {
    for (int i=0; i<argc; i++) {
        cout << argv[i] << endl;
    }

    int arr[3] = {0,0,0};
    doSomething(arr);

    for (int i=0; i< 3 ;i++) {
        cout << arr[i] << " ";
    }
    cout << endl;
    return 0;
}

void doSomething(int arr[]) {
    arr[0] = 1;
}