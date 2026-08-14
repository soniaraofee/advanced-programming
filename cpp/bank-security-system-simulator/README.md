# Bank Security System Simulation

A C++ console program that simulates a simplified **bank security system** using a four-digit PIN and a `6×6` binary access map.

The program validates the user's PIN, processes the access matrix according to the specified rules, assigns a security code to each row, and identifies the column with the highest number of active access points.

## Problem Description

The program uses a `6×6` matrix called the **Access Map**.

Each element of the matrix can contain either:

* `0` → Access closed
* `1` → Access open

The program performs several security checks and transformations on this matrix.

---

## Program Requirements

### 1. Security and Password Validation

First, the program asks the user to enter a **four-digit PIN**.

The PIN must be between `1000` and `9999`.

The program calculates the sum of the PIN's digits.

If the sum of the digits is **not a prime number**, the system considers the access invalid, prints an error message, and terminates.

For example:

```text
PIN: 1234

1 + 2 + 3 + 4 = 10
```

Since `10` is not prime, the program terminates with an error.

---

## 2. Access Matrix

If the PIN is valid, the program asks the user to enter a `6×6` binary matrix.

Only `0` and `1` are accepted as valid values.

Example:

```text
1 0 1 0 1 1
0 1 0 1 0 1
1 1 0 0 1 0
0 0 1 1 1 0
1 0 0 1 0 1
1 1 1 0 0 0
```

If the user enters a value other than `0` or `1`, the program displays an error message and asks for another value.

---

## 3. Row Processing

After receiving the matrix, the program examines each row.

For each row, the number of `1`s is counted.

If the number of `1`s is **odd**, all values in that row are inverted:

```text
0 → 1
1 → 0
```

For example:

```text
Before:
1 0 1 0 1 0
```

There are three `1`s, which is odd.

Therefore:

```text
After:
0 1 0 1 0 1
```

If the number of `1`s is even, the row remains unchanged.

---

## 4. Security Status Codes

After the row transformation, the program counts the number of `1`s in each row again and assigns a security code.

| Number of `1`s | Code | Security Level  |
| -------------- | ---- | --------------- |
| More than 4    | A    | High Security   |
| 2 to 4         | B    | Medium Security |
| Otherwise      | C    | Low Security    |

The program uses a `switch` statement to display the corresponding security message.

Example:

```text
Row 1 -> Code A : High Security
Row 2 -> Code B : Medium Security
Row 3 -> Code C : Low Security
```

---

## 5. Final Analysis

The program calculates the sum of the values in each column.

Since the matrix contains only `0` and `1`, the column sum represents the number of active access points in that column.

The program then identifies the column with the **maximum sum**.

Example:

```text
Column 1 → 3
Column 2 → 4
Column 3 → 2
Column 4 → 5
Column 5 → 3
Column 6 → 2
```

The result would be:

```text
Column with maximum sum: 4
```

Finally, the program displays the transformed matrix.

---

## Functions

### `isPrime()`

Checks whether the sum of the PIN's digits is a prime number.

```cpp
int isPrime(int n)
```

Returns:

* `1` if the number is prime
* `0` if the number is not prime

---

## Main Program Flow

The program follows this sequence:

```text
Start
  │
  ▼
Enter Four-Digit PIN
  │
  ▼
Calculate Sum of Digits
  │
  ▼
Is the Sum Prime?
 ┌┴─────────────┐
No              Yes
 │               │
 ▼               ▼
ERROR       Enter 6×6 Matrix
 │               │
 ▼               ▼
End        Validate Matrix Input
                 │
                 ▼
          Process Each Row
                 │
                 ▼
          Assign Security Code
                 │
                 ▼
          Find Maximum Column
                 │
                 ▼
          Display Final Matrix
                 │
                 ▼
                End
```

## Example

```text
Please Enter Your Four-Digit PIN:
1133

Enter 0 or 1 for 6x6 matrix:

1 0 1 0 1 0
1 1 0 0 1 1
0 1 1 0 0 1
1 0 0 1 1 0
1 1 1 0 0 0
0 0 1 1 0 1

Row 1 -> Code B : Medium Security

Row 2 -> Code B : Medium Security

Row 3 -> Code B : Medium Security

...

Column with maximum sum: 2

Final Matrix:
0 1 0 1 0 1
1 1 0 0 1 1
...
```


## Learning Objectives

This project demonstrates:

* Two-dimensional arrays
* Nested `for` loops
* `while` loops
* `switch` statements
* Functions
* Prime number checking
* Digit extraction using `%` and `/`
* Input validation
* Matrix manipulation
* Row and column analysis
* Conditional statements
* Basic security-system simulation

## Notes

The program expects a **four-digit numeric PIN** and a `6×6` matrix containing only `0` and `1`.

If multiple columns have the same maximum sum, the program selects the **first column** with that maximum value.

The matrix is modified in-place when a row contains an odd number of `1`s.
