#include <iostream>
using namespace std;

bool Asalmi(int x) {
    bool flag = true;
    
    if (x == 2) {
        return flag;
    } 
    else if (x % 2 == 0) {
        flag = false;
    }

    if (flag) {
        for (int i = 3; i < x / 2; ++i) {
            if (x % i == 0) {
                std::cout << x << " sayısının " << i << " sayısına bölümü: " << static_cast<double>(x) / i
                          << ", kalan ise 0'dır." << std::endl;
                flag = false;
                break;
            }
        }
    }

    return flag;
}

int main() {
    int x;
    std::cout << "Sayı girin: ";
    std::cin >> x;

    std::cout << std::boolalpha << Asalmi(x) << std::endl;

    return 0;
}
