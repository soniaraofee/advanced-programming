# Windows Forms Calculator

A simple, user-friendly calculator application built with C# and Windows Forms. This application supports basic arithmetic operations, power calculations, percentages, and square roots.


## 🚀 Features

*   **Basic Operations**: Addition (`+`), Subtraction (`-`), Multiplication (`*`), and Division (`/`).
*   **Advanced Math**:
    *   Exponentiation (`x^y`): Raises the first number to the power of the second.
    *   Square Root (`x^1/2`): Calculates the square root of the current number.
    *   Percentage (`%`): Computes a percentage of the first number based on the second (e.g., `100 % 10 = 10`).
*   **User Interface**:
    *   Clear entry (`CE`) button to reset the current input.
    *   Decimal point (`.`) support.
    *   Error handling for division by zero and square roots of negative numbers.

## 🛠️ Technologies Used

*   **Language**: C#
*   **Framework**: .NET Framework (Windows Forms)
*   **IDE**: Visual Studio

## 📂 Project Structure

*   `Calculator.cs`: The main form class containing the UI logic and event handlers.
*   `Calculator.Designer.cs`: Auto-generated code for the UI layout.
*   `Program.cs`: The entry point of the application.

## 🧠 How It Works (Code Highlights)

The application logic is managed within the `Calculator` class:

1.  **Number Parsing**: The `ParseNumber()` method handles input conversion, replacing commas with dots to ensure proper decimal separation across different cultures.
2.  **Operation Handling**: When an operator button (e.g., `+`, `-`, `*`) is clicked, the current number is stored in `firstNum` and the operation is recorded in the `operation` variable.
3.  **Calculation**: Upon pressing the `=` button, the `btnEqual_Click` event calculates the final result based on the saved `operation` and the current input.
4.  **Error Handling**: The code includes checks to prevent crashes, such as:
    *   Displaying a message box when dividing by zero.
    *   Showing an error when attempting to take the square root of a negative number.

## 🎮 How to Use

1.  **Enter Numbers**: Click the number buttons (0-9) to input digits.
2.  **Select Operation**: Click an operator (`+`, `-`, `*`, `/`, `%`, `x^y`) to choose the math operation.
3.  **Calculate**: Press the `=` button to see the result.
4.  **Clear**: Press the `CE` button to reset the current calculation.
5.  **Square Root**: Enter a positive number and press the `x^1/2` button to get its root.

## 📝 Future Improvements (Optional)

*   Add support for keyboard input (NumPad).
*   Implement a history log of previous calculations.
*   Add a "Backspace" button to delete the last digit.
*   Support for parentheses `()`.
