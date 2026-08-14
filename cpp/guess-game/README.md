# Number Guessing Game

A simple C++ console game in which the computer randomly selects a number between **1 and 1000**, and the player tries to guess it.

The program provides hints after each guess and evaluates the player's performance based on the number of attempts.

## Description

The computer generates a random number between 1 and 1000.

The player repeatedly enters a guess until the correct number is found. After each incorrect guess, the program provides a hint:

* The computer's number is larger than the guess.
* The computer's number is smaller than the guess.

After the correct guess, the program displays the number of attempts and assigns a performance level.

The player can then choose whether to play again.

## Features

* Random number generation
* Interactive console input
* Guess validation
* Helpful hints
* Attempt counter
* Performance evaluation
* Replay option
* Global performance comparison

## Performance Levels

The player's performance is evaluated based on the number of attempts:

| Attempts | Level   | Description |
| -------- | ------- | ----------- |
| 1        | Level 5 | Perfect     |
| 2        | Level 4 | Very Good   |
| 3        | Level 3 | Good        |
| 4        | Level 2 | Not Bad     |
| 5+       | Level 1 | Poor        |

## Example

```text
Welcome To This Game!!!
========================
I Will Guess a Number Between 1 to 1000
And You Can Try to Guess It...
=========================

What's your guess?
500
My number is smaller than your answer.

What's your guess?
250
My number is larger than your answer.

What's your guess?
375
Oh, you did it!!

That's Correct! You guessed it in 3 times.
Your Performance: Level 3 (Good)

GOOD GAME!
Do You Wanna Play Again? (y/n)
n

Your Average Score: 3
Global Performance Comparison: Level 2
Good For You!! You were better than the global score!!!
```

## How It Works

### 1. Generate a Random Number

The computer generates a number between 1 and 1000:

```cpp
int cguess = 1 + rand() % 1000;
```

### 2. Get the User's Guess

The program repeatedly asks the user to enter a number:

```cpp
cin >> uguess;
```

### 3. Check the Guess

The `answer()` function compares the user's guess with the computer's number and provides an appropriate hint.

### 4. Count Attempts

Every time the user makes a guess, the attempt counter is increased:

```cpp
count++;
```

### 5. Evaluate Performance

After the correct answer is found, `analyzePerformance()` assigns a score from 1 to 5 based on the number of attempts.

### 6. Compare Performance

At the end of the game, the player's average performance is compared with a randomly generated global score.

## Functions

| Function               | Purpose                                           |
| ---------------------- | ------------------------------------------------- |
| `welcome()`            | Displays the game introduction                    |
| `finish()`             | Asks whether the player wants to play again       |
| `answer()`             | Gives a hint based on the user's guess            |
| `win()`                | Checks whether the guess is correct               |
| `analyzePerformance()` | Calculates the player's performance level         |
| `comparison()`         | Compares the player's score with the global score |



## Learning Objectives

This project demonstrates the use of:

* Functions
* Function declarations and definitions
* `do-while` loops
* Conditional statements
* `switch` statements
* Random number generation
* Variables and initialization
* User input/output
* Basic program control flow
* Modular programming in C++

## Notes

The program uses `rand()` and `srand()` to generate random numbers. The random seed is initialized using the current system time.

The guessing loop uses a `do-while` structure so that the player is asked for at least one guess before the winning condition is checked.
