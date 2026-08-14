# Reversed Number

A simple C++ program that reverses the digits of both the integer and fractional parts of a decimal number.

## Description

This program receives a decimal number from the user, separates its integer and fractional parts, reverses each part independently, and displays the resulting number.

For example:

```text
Input:
123.45

Output:
Reversed number: 321.54
```

## Features

* Reads a decimal number from the user.
* Separates the integer and fractional parts.
* Reverses the digits of each part.
* Displays the reversed number.
* Uses a separate function for reversing integers.

## How It Works

The program follows these steps:

1. Gets a decimal number from the user.
2. Extracts the integer part.
3. Extracts the fractional part.
4. Converts the fractional part into an integer.
5. Reverses both parts using the `reverseInt()` function.
6. Prints the reversed result.

### `reverseInt()` Function

The `reverseInt()` function reverses the digits of an integer using a `while` loop:

```cpp
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
```

## Example

```text
Enter a number: 123.45
Reversed number: 321.54
```

Another example:

```text
Enter a number: 987.12
Reversed number: 789.21
```

## Notes

This implementation uses `double` for the input number. Because floating-point numbers cannot always be represented exactly in binary, some decimal inputs may produce unexpected results when processing the fractional part.


## Learning Objectives

This project demonstrates:

* Functions in C++
* `while` loops
* Integer arithmetic
* Modulo operator `%`
* Type casting
* Working with `double`
* Separating integer and fractional parts
* Basic input/output with `iostream`
