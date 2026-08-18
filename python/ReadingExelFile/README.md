# Student Data Analysis

A Python data analysis project that reads student information from an Excel file, calculates statistics based on gender, and visualizes GPA data using charts.

## Features

* Load student data from an Excel file.
* Filter students by gender.
* Calculate:

  * Minimum age
  * Maximum age
  * Average age
  * Minimum GPA
  * Maximum GPA
  * Average GPA
* Display the calculated statistics in the terminal.
* Visualize average GPA by gender using a bar chart.
* Visualize average GPA by age using a line chart.
* Handle the case where the Excel file cannot be found.

## Technologies

* **Python**
* **Pandas**
* **Matplotlib**
* **Excel**

## Requirements

Install the required Python libraries:

```bash
pip install pandas matplotlib openpyxl
```

`openpyxl` is required by Pandas to read `.xlsx` files.

## Input File

The program expects an Excel file named:

```text
students.xlsx
```

The Excel file should contain at least these columns:

| Column   | Description                   |
| -------- | ----------------------------- |
| `Gender` | Student's gender              |
| `Age`    | Student's age                 |
| `GPA`    | Student's grade point average |

Example:

| Gender | Age |  GPA |
| ------ | --: | ---: |
| male   |  20 | 17.5 |
| female |  19 | 18.2 |
| male   |  21 | 16.8 |
| female |  20 | 19.0 |

## Usage

1. Place `students.xlsx` in the same directory as the Python script.

2. Run the program:

```bash
python main.py
```

3. Enter a gender when prompted:

```text
Please enter the gender (e.g., 'male' or 'female'):
```

4. The program displays the statistics for the selected gender.

5. Two charts are then displayed:

   * **Average GPA by Gender**
   * **Average GPA by Age**

## Example Output

```text
--- Data successfully loaded ---

Please enter the gender (e.g., 'male' or 'female'): female

Statistics for gender: female
Min Age: 18 | Max Age: 22 | Average Age: 20.00
Min GPA: 15.20 | Max GPA: 19.50 | Average GPA: 17.85
```

## Visualizations

### Average GPA by Gender

The program groups students by gender and calculates the average GPA for each group.

### Average GPA by Age

The program groups students by age and calculates the average GPA for each age group.

## Error Handling

If `students.xlsx` cannot be found, the program displays an error message:

```text
Error: Excel file not found. Please check the file path.
```

## Learning Goals

This project demonstrates basic data analysis concepts in Python, including:

* Reading Excel files with Pandas
* DataFrame filtering
* Calculating statistical values
* Grouping data with `groupby()`
* Data visualization with Matplotlib
* Handling file-related errors
* Working with user input