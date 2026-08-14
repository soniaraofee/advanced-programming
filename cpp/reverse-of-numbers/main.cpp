#include <iostream>

using namespace std;

// Function to reverse an integer
int reverseInt(int n)
{
    int rev = 0;

    while (n > 0)
    {
        rev = rev * 10 + (n % 10);
        n /= 10;
    }

    return rev;
}

int main()
{
    double num;

    cout << "Enter a number: ";
    cin >> num;

    // Separate the integer and fractional parts
    int integerPart = (int)num;
    double fracPart = num - integerPart;

    // Convert the fractional part to an integer by scaling
    int fracInt = 0;

    while (fracPart > 0.0000001)
    {
        fracPart *= 10;

        int digit = (int)fracPart;
        fracInt = fracInt * 10 + digit;

        fracPart -= digit;
    }

    // Reverse the integer and fractional parts
    int revInt = reverseInt(integerPart);
    int revFrac = reverseInt(fracInt);

    // Print the final reversed number
    cout << "Reversed number: " << revInt << "." << revFrac << endl;

    return 0;
}