#include <vector>
#include <iostream>
using namespace std;

class Problem1 {
    public:
        int get_sum(vector<int> factors, int limit);
    private:
        bool is_multiple(vector<int> factors, int number);
};

int Problem1::get_sum(vector<int> factors, int limit) {
    int sum = 0;
        for (int i = 0; i < limit; ++i) {
            if (is_multiple(factors, i)) {
                sum += i;
            }
        }
        return sum;
    }

     bool Problem1::is_multiple(vector<int> factors, int number) {
         for (vector<int>::iterator it = factors.begin(); it != factors.end(); ++it) {
             if (number % *it == 0) {
                 return true;
             }

         }
         return false;
     }
/*
int main()
{
    Problem1 p1 = Problem1();
    vector<int> factors;
    factors.push_back(3);
    factors.push_back(5);
    int sum = p1.get_sum(factors, 1000);
    cout << "Sum: " << sum << endl;
    int in = 0;
    cin >> in;
    return 0;
}*/