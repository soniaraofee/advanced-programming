#include <cstdlib>
#include <iostream>

using namespace std;

int isPrime(int n)
{
    if (n < 2)
        return 0;

    for (int i = 2; i <= n / 2; i++)
    {
        if (n % i == 0)
            return 0;
    }

    return 1;
}

int main()
{
    int accessMap[6][6];

    int password;
    int sum = 0;

    int sum1;
    int sum1_;

    int sumCol = 0;
    int maxSum = -1;

    char statusCode;

    // Get the four-digit PIN
    cout << "Please Enter Your Four-Digit PIN: " << endl;
    cin >> password;

    // Check whether the PIN has exactly four digits
    if (password > 9999 || password < 1000)
    {
        cout << "Just four-digit PIN!" << endl;
        return 0;
    }

    // Calculate the sum of the PIN's digits
    while (password > 0)
    {
        int digit = password % 10;

        sum += digit;
        password /= 10;
    }

    // The sum of the digits must be prime
    if (!isPrime(sum))
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                accessMap[i][j] = 0;
            }
        }

        cout << "ERROR!" << endl;
        return 0;
    }

    // Get the 6x6 binary matrix
    cout << "Enter 0 or 1 for 6x6 matrix: " << endl;

    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            while (true)
            {
                cin >> accessMap[i][j];

                if (accessMap[i][j] == 0 || accessMap[i][j] == 1)
                {
                    break;
                }

                cout << "Invalid input! Please enter ONLY 0 or 1"
                     << endl;
            }
        }
    }

    // Check each row's number of 1s
    // If it is odd, invert all elements in that row
    for (int i = 0; i < 6; i++)
    {
        sum1 = 0;

        for (int j = 0; j < 6; j++)
        {
            if (accessMap[i][j] == 1)
                sum1++;
        }

        if (sum1 % 2 == 1)
        {
            for (int j = 0; j < 6; j++)
            {
                accessMap[i][j] = 1 - accessMap[i][j];
            }
        }
    }

    // Determine the security status of each row
    for (int i = 0; i < 6; i++)
    {
        sum1_ = 0;

        for (int j = 0; j < 6; j++)
        {
            if (accessMap[i][j] == 1)
                sum1_++;
        }

        if (sum1_ > 4)
            statusCode = 'A';
        else if (sum1_ >= 2 && sum1_ <= 4)
            statusCode = 'B';
        else
            statusCode = 'C';

        cout << "Row " << i + 1
             << " -> Code " << statusCode << " : ";

        switch (statusCode)
        {
            case 'A':
                cout << "High Security" << endl;
                break;

            case 'B':
                cout << "Medium Security" << endl;
                break;

            case 'C':
                cout << "Low Security" << endl;
                break;
        }

        cout << endl;
    }

    // Find the column with the maximum sum
    int bestCol = 0;

    for (int j = 0; j < 6; j++)
    {
        sumCol = 0;

        for (int i = 0; i < 6; i++)
        {
            sumCol += accessMap[i][j];
        }

        if (sumCol > maxSum)
        {
            maxSum = sumCol;
            bestCol = j;
        }
    }

    cout << "Column with maximum sum: "
         << bestCol + 1 << endl;

    // Display the final matrix
    cout << "Final Matrix: " << endl;

    for (int i = 0; i < 6; i++)
    {
        for (int j = 0; j < 6; j++)
        {
            cout << accessMap[i][j] << " ";
        }

        cout << endl;
    }

    return 0;
}