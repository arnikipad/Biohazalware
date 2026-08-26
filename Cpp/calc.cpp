#include <iostream>
using namespace std;


double square(double x) {
    // do the maths
    return x*x;
}
void print_square(double x) {
    // reply template
    cout << "The square of" << " " << x << " " << "is" << " " << square(x) << "\n";
}

int main() {
    // questionning the user for the number
    cout << "Write your number\n";
    int answer = 0;
    // keep the number in memory
    cin >> answer;
    // print the reply
    print_square(answer);
}