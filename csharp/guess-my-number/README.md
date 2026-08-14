# Guess My Number 🎯

A classic number guessing game built with Windows Forms in C#. Test your intuition and try to guess the computer's secret number between 1 and 100!

## 📝 Description

"Guess My Number" is an interactive Windows Forms application where players attempt to guess a randomly generated number between 1 and 100. The game provides feedback on each guess, tracks attempts, and evaluates performance based on the number of attempts taken to find the correct number.

## ✨ Features

- **Random Number Generation**: Each game starts with a new random number between 1-100
- **Real-time Feedback**: 
  - "My number is LARGER" (in red) when your guess is too low
  - "My number is LOWER" (in orange) when your guess is too high
  - "Correct! You guessed the number!" (in green) when you win
- **Performance Tracking**:
  - Level 4 (Perfect): 1-3 attempts
  - Level 3 (Very Good): 4-5 attempts
  - Level 2 (Good): 6-7 attempts
  - Level 1 (Poor): 8+ attempts
- **Score System**: Earn points based on performance levels (4, 3, 2, or 1)
- **Multiple Games**: Play multiple rounds with cumulative scoring
- **Global Comparison**: Compare your average score against a simulated global performance level

## 🎮 How to Play

1. **Launch the Application**: Run the executable or build from source
2. **Enter Your Guess**: Type a number between 1 and 100 in the text box
3. **Click "Guess"**: Receive feedback on whether your guess is too high or too low
4. **Keep Guessing**: Continue until you find the correct number
5. **Play Again**: Choose to start a new game or exit after each round
6. **View Summary**: See your performance comparison when exiting

## 🖥️ Interface

The application features a clean, user-friendly interface with:

- A message area displaying game status and feedback
- Input field for entering guesses
- Attempts counter
- Performance level display
- "Guess" button for submitting answers
- "New Game" button to restart
- "Exit" button to quit and view summary

## 🛠️ Technical Details

- **Framework**: .NET Framework with Windows Forms
- **Language**: C#
- **UI Components**: 
  - Labels for messages and status
  - TextBox for user input
  - Buttons for game controls
  - MessageBox for dialogs and notifications

## 📦 Installation

### Prerequisites
- Windows Operating System
- .NET Framework 4.5 or higher
- Visual Studio (for development)

### Build from Source

1. Clone the repository:
```bash
git clone [repository-url]
```

2. Open the solution file (`.sln`) in Visual Studio

3. Build the solution (Ctrl+Shift+B)

4. Run the application (F5)

## 🎯 Game Logic

The game uses the following logic:

- **Random Number Generation**: `random.Next(1, 101)` creates a number between 1 and 100
- **Validation**: Ensures input is a valid integer between 1 and 100
- **Attempt Tracking**: Increments with each valid guess
- **Performance Analysis**: Evaluates after winning to determine performance level
- **Score Calculation**: Performance level becomes the score for that round
- **Global Comparison**: Simulated global score (random 1-4) for comparison

## 📊 Scoring System

| Attempts | Performance Level | Score |
|----------|------------------|-------|
| 1-3      | Level 4 (Perfect) | 4     |
| 4-5      | Level 3 (Very Good)| 3     |
| 6-7      | Level 2 (Good)    | 2     |
| 8+       | Level 1 (Poor)    | 1     |

## 🔧 Code Structure

```
GuessMyNumber
├── GuessMyNumber.cs         # Main form logic
│   ├── StartNewGame()       # Initialize new game
│   ├── btnGuess_Click()     # Handle guess submission
│   ├── AnalyzePerformance() # Evaluate performance
│   ├── ShowComparison()     # Display game summary
│   ├── btnNewGame_Click()   # Start new game
│   └── btnExit_Click()      # Exit application
└── Program.cs               # Application entry point
```

## 🤝 Contributing

Contributions are welcome! Feel free to:

- Report bugs
- Suggest new features
- Submit pull requests

Please ensure your code follows the existing style and includes appropriate comments.

## 📜 License

This project is open source and available under the MIT License.

## 🎉 Acknowledgments

- Built as a learning project for Windows Forms development
- Classic number guessing game concept
- Features enhanced with performance tracking and scoring system

---

**Happy Guessing! 🎯**