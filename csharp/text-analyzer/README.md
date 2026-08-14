# Text Analyzer 📝

A powerful Windows Forms application for analyzing text content with character and word counting capabilities, built with C# and .NET.

## 📝 Description

Text Analyzer is a Windows Forms application that provides detailed text analysis functionality. Users can input text and perform various analyses including character frequency counting, specific character search, word counting, and word pattern matching. The application offers both general analysis and targeted search capabilities.

## ✨ Features

### Character Analysis
- **Full Alphabet Frequency**: Count occurrences of each letter (a-z) in the input text
- **Specific Character Search**: Count occurrences of a specific character
- **Case-Insensitive**: Automatically handles uppercase and lowercase letters
- **Detailed Results**: Displays comprehensive character frequency reports

### Word Analysis
- **Word Counting**: Count total number of words in the text
- **Word List Display**: Show all words found in the text (when no filter is applied)
- **Specific Word Search**: Find and count occurrences of a specific word
- **Case-Insensitive Word Search**: Handles different capitalizations

### User Interface
- **Clean, Intuitive Design**: Easy-to-use interface with clear sections
- **Multi-line Text Input**: Rich text box for entering or pasting text
- **Real-time Processing**: Instant results on button click
- **Formatted Output**: Well-structured results display with clear formatting

## 🎮 How to Use

1. **Enter Text**: Type or paste your text into the "Enter Text" area
2. **Choose Analysis Type**:
   - **Character Analysis**: Count characters (with or without specific character filter)
   - **Word Analysis**: Count words (with or without specific word filter)
3. **Use Filters (Optional)**:
   - Enter a specific character in the "Char Filter" box to count its occurrences
   - Enter a specific word in the "Word Filter" box to count its occurrences
4. **Click Analysis Button**:
   - **Count Chars**: Performs character analysis
   - **Count Words**: Performs word analysis
5. **View Results**: Analysis results appear in the "Result" text box

## 🖥️ Interface Layout

```
+------------------------------------------+
|           Text Analyzer                    |
+------------------------------------------+
| Enter Text:                                |
| [Multi-line text input]                   |
|                                            |
| Filter:                                    |
| Char Filter: [input]   Word Filter: [input]|
|                                            |
| [Count Chars]     [Count Words]          |
|                                            |
| Result:                                    |
| [Multi-line output area]                  |
+------------------------------------------+
```

## 🔧 Technical Details

- **Framework**: .NET Framework with Windows Forms
- **Language**: C#
- **Core Functionality**:
  - String manipulation and analysis
  - Character iteration and counting
  - Word splitting with multiple delimiters
  - Case-insensitive comparisons
  - Formatted string output

## 🛠️ Installation

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

## 💡 Usage Examples

### Character Frequency Analysis
**Input**: "Hello World"
**Output**:
```
Letter | Count
--------------
d      | 1
e      | 1
h      | 1
l      | 3
o      | 2
r      | 1
w      | 1
```

### Specific Character Search
**Char Filter**: "l"
**Result**:
```
Search Results for 'l'
----------------------
Found: 3 times
```

### Word List Analysis
**Input**: "Hello World Hello"
**Output**:
```
Word Analysis
------------------------
Total Words: 3
Hello
World
Hello
```

### Specific Word Search
**Word Filter**: "hello"
**Result**:
```
Search Results for "hello"
------------------------
Total words: 3
Found: 2 times
```

## 📊 Analysis Methods

### Character Analysis Algorithm
1. Converts text to lowercase for case-insensitive analysis
2. If character filter is provided:
   - Counts occurrences of the specific character
   - Displays only that character's count
3. If no character filter:
   - Iterates through alphabet (a-z)
   - Counts occurrences of each letter
   - Displays only letters with count > 0

### Word Analysis Algorithm
1. Splits text using delimiters: space, newline, carriage return, tab
2. Removes empty entries
3. If word filter is provided:
   - Counts occurrences of the specific word (case-insensitive)
   - Shows total words and found count
4. If no word filter:
   - Displays total word count
   - Lists all words in the text

## 🔍 Code Structure

```
TextAnalyzer
├── TextAnalyzer.cs          # Main form logic
│   ├── ChCount_Click()      # Character analysis handler
│   ├── WCount_Click()       # Word analysis handler
│   ├── Character counting logic
│   ├── Word counting logic
│   └── Output formatting
└── Program.cs               # Application entry point
```

## 🎯 Key Features Implementation

- **Efficient String Processing**: Uses optimized string methods and loops
- **Flexible Analysis**: Supports both broad analysis and specific searches
- **Clean Output**: Formatted results with headers and separators
- **Error Handling**: Gracefully handles empty or whitespace input
- **User Experience**: Focus management for better usability

## 🤝 Contributing

Contributions are welcome! Feel free to:

- Report bugs
- Suggest new features (like punctuation counting, readability scores, etc.)
- Submit pull requests
- Improve performance or add new analysis methods

Please ensure your code follows the existing style and includes appropriate comments.

## 📜 License

This project is open source and available under the MIT License.

## 🎨 Future Enhancements

Potential features for future releases:
- Character count (including spaces)
- Punctuation analysis
- Readability scores (Flesch-Kincaid, etc.)
- Sentence counting
- Export results to file
- Copy results to clipboard
- Word frequency analysis with sorting options

---

**Happy Analyzing! 📊**