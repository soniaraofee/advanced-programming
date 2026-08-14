#include <cstdlib>
#include <ctime>
#include <iostream>

using namespace std;

void welcome();
int finish();
void answer(int com, int user);
int win(int com, int user);
int analyzePerformance(int attempts);
void comparison(int performance, int count);

int main(int argc, char** argv)
{
    welcome();

    int c = 0;
    int sum = 0;

    do
    {
        srand(time(0));

        int cguess = 1 + rand() % 1000;
        int uguess;
        int count = 0;

        do
        {
            cout << "What's your guess?" << endl;
            cin >> uguess;

            count++;

            answer(cguess, uguess);
        }
        while (!win(cguess, uguess));

        cout << "That's Correct! "
             << "You guessed it in " << count << " times." << endl;

        sum += analyzePerformance(count);
        c++;
    }
    while (finish());

    comparison(sum, c);

    return 0;
}

void welcome()
{
    cout << "Welcome To This Game!!!" << endl;
    cout << "========================" << endl;

    cout << "I Will Guess a Number Between 1 to 1000" << endl;
    cout << "And You Can Try to Guess It..." << endl;

    cout << "=========================" << endl;
}

int finish()
{
    cout << "GOOD GAME!" << endl;
    cout << "Do You Wanna Play Again? (y/n)" << endl;

    char ans;
    cin >> ans;

    if (ans == 'y')
        return 1;
    else
        return 0;
}

void answer(int com, int user)
{
    if (com == user)
        cout << "Oh, you did it!!" << endl;

    if (com > user)
        cout << "My number is larger than your answer." << endl;

    if (com < user)
        cout << "My number is smaller than your answer." << endl;
}

int win(int com, int user)
{
    return com == user;
}

int analyzePerformance(int attempts)
{
    switch (attempts)
    {
        case 1:
            cout << "Your Performance: Level 5 (Perfect)" << endl;
            return 5;

        case 2:
            cout << "Your Performance: Level 4 (Very Good)" << endl;
            return 4;

        case 3:
            cout << "Your Performance: Level 3 (Good)" << endl;
            return 3;

        case 4:
            cout << "Your Performance: Level 2 (Not Bad)" << endl;
            return 2;

        default:
            cout << "Your Performance: Level 1 (Poor)" << endl;
            return 1;
    }
}

void comparison(int performance, int count)
{
    srand(time(0));

    int globalScore = 1 + rand() % 5;
    int avg = performance / count;

    cout << "Your Average Score: " << avg << endl;
    cout << "Global Performance Comparison: Level "
         << globalScore << endl;

    if (avg >= globalScore)
    {
        cout << "Good For You!! "
             << "You were better than the global score!!!"
             << endl;
    }
    else
    {
        cout << "You were worse than the global score." << endl;
    }
}