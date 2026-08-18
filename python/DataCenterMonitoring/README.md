# Sensor Data Analysis

A Python-based sensor data analysis project that collects data from multiple sensors, performs statistical analysis, demonstrates bitwise operations and string manipulation, and visualizes the results using **NumPy, Pandas, and Matplotlib**.

## Features

* Interactive sensor data input
* Calculate average temperature and power consumption
* Find maximum and minimum temperatures
* Search for a sensor by ID
* Classify sensors as:

  * **Normal** — temperature below 50
  * **Warning** — temperature from 50 to 70
  * **Critical** — temperature above 70
* Display sensor status using bitwise operations
* Set, clear, and toggle individual bits
* Perform basic string operations
* Analyze sensor data with NumPy
* Create and analyze a Pandas DataFrame
* Generate temperature and power-consumption charts
* Generate a final data-center report
* Select a random sensor

## Technologies

* Python 3
* NumPy
* Pandas
* Matplotlib
* Random module

## Installation

Install the required libraries with:

```bash
pip install numpy pandas matplotlib
```

## Input Format

The program accepts sensor information in the following format:

```text
SensorID, SensorName, Temperature, Power
```

For example:

```text
101, CPU, 45.5, 120
102, GPU, 68.2, 250
103, RAM, 52.0, 80
104, Disk, 75.5, 60
```

Press **Enter on an empty line** to finish entering sensor data.

## Example

```text
Enter the sensor information.

Press Enter on an empty line to finish.
101, CPU, 45.5, 120
102, GPU, 68.2, 250
103, RAM, 52.0, 80

Recorded Data:
{'SensorID': 101, 'SensorName': 'CPU', 'Temperature': 45.5, 'Power': 120.0}
{'SensorID': 102, 'SensorName': 'GPU', 'Temperature': 68.2, 'Power': 250.0}
{'SensorID': 103, 'SensorName': 'RAM', 'Temperature': 52.0, 'Power': 80.0}
```

## Main Functions

| Function                | Description                                   |
| ----------------------- | --------------------------------------------- |
| `get_sensor_data()`     | Collects sensor information from the user     |
| `average_temperature()` | Calculates average temperature                |
| `average_power()`       | Calculates average power consumption          |
| `max_min_temperature()` | Finds maximum and minimum temperatures        |
| `search_sensor()`       | Searches for a sensor using its ID            |
| `count_status()`        | Counts Normal, Warning, and Critical sensors  |
| `sensor_status()`       | Determines a sensor's temperature status      |
| `analyze_sensors()`     | Displays the status of each sensor            |
| `show_status()`         | Displays individual status bits               |
| `set_bit()`             | Sets a specific bit                           |
| `clear_bit()`           | Clears a specific bit                         |
| `toggle_bit()`          | Toggles a specific bit                        |
| `process_name()`        | Demonstrates string operations                |
| `analyze_numpy()`       | Performs NumPy-based analysis                 |
| `create_dataframe()`    | Creates a Pandas DataFrame                    |
| `dataframe_info()`      | Displays DataFrame information and statistics |
| `draw_charts()`         | Creates temperature and power charts          |
| `final_report()`        | Generates a summary data-center report        |

## Bitwise Status

The project also demonstrates how individual bits can represent sensor states:

| Bit   | Meaning       |
| ----- | ------------- |
| Bit 0 | Sensor Active |
| Bit 1 | Alarm         |
| Bit 2 | Need Service  |
| Bit 3 | Emergency     |

Example:

```python
status = 0b0101
```

The following operations are demonstrated:

```python
set_bit(status, 1)
clear_bit(status, 2)
toggle_bit(status, 3)
```

## NumPy Analysis

The project converts temperature and power values into NumPy arrays and demonstrates:

* Sorting
* Sum
* Mean
* Maximum
* Minimum
* Reshaping
* Creating arrays with zeros and ones
* Generating random values

## Pandas Analysis

Sensor data is converted into a Pandas DataFrame to demonstrate:

* Columns
* Data types
* Number of records
* Mean temperature
* Statistical summary with `describe()`
* Selecting the first three rows
* Selecting specific columns

## Visualization

Matplotlib is used to generate two charts:

1. **Temperature of Sensors** — line chart showing sensor temperatures.
2. **Power Consumption** — bar chart showing power consumption of each sensor.

## Concepts Practiced

This project combines several Python programming concepts:

* Functions
* Lists
* Dictionaries
* Loops
* Conditional statements
* Exception handling
* String manipulation
* List comprehensions
* NumPy arrays
* Pandas DataFrames
* Data visualization
* Random number generation
* Bitwise operators
* User input and validation

## Note

The program expects at least one valid sensor record. Functions such as `average_temperature()` and `max_min_temperature()` require the sensor list to contain data.

## Purpose

This project is designed as a **Python practice project** for working with data structures, functions, NumPy, Pandas, Matplotlib, strings, and bitwise operations in a single application.
