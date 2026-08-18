# Unit Converters

A desktop unit conversion application built with **C#** and **Windows Forms**. The application provides a simple interface for converting values between different units of measurement, with support for multiple measurement categories, unit searching, light/dark themes, and quick result copying.

## Features

* Convert between multiple measurement categories:

  * **Length**
  * **Temperature**
  * **Area**
  * **Volume**
  * **Weight**
  * **Time**
* Search for source and target units.
* Display conversion results instantly while typing.
* Swap the source and target units.
* Copy the converted value to the clipboard.
* Toggle between **Light Mode** and **Dark Mode**.
* Preserve the selected target unit when conversion results are recalculated.
* Handle temperature conversions separately using Celsius, Kelvin, and Fahrenheit formulas.
* Use a base-unit conversion system for other measurement categories.

## Supported Units

### Length

* Meter
* Kilometer
* Centimeter
* Millimeter
* Micrometer
* Nanometer
* Mile
* Yard
* Foot
* Inch
* Light Year

### Temperature

* Celsius
* Kelvin
* Fahrenheit

### Area

* Square Meter
* Square Kilometer
* Square Centimeter
* Square Millimeter
* Square Micrometer
* Hectare
* Square Mile
* Square Yard
* Square Foot
* Square Inch
* Acre

### Volume

* Cubic Meter
* Cubic Kilometer
* Cubic Centimeter
* Cubic Millimeter
* Liter
* Milliliter
* US Gallon
* US Quart
* US Pint
* US Cup
* US Fluid Ounce
* US Tablespoon
* US Teaspoon
* Imperial Gallon
* Imperial Quart
* Imperial Pint
* Imperial Fluid Ounce
* Imperial Tablespoon
* Imperial Teaspoon
* Cubic Mile
* Cubic Yard
* Cubic Foot
* Cubic Inch

### Weight

* Kilogram
* Gram
* Milligram
* Metric Ton
* Long Ton
* Short Ton
* Pound
* Ounce
* Carat
* Atomic Mass Unit

### Time

* Second
* Millisecond
* Microsecond
* Nanosecond
* Picosecond
* Minute
* Hour
* Day
* Week
* Month
* Year

## How It Works

For most measurement categories, conversion factors are defined relative to a common base unit. The application first converts the input value to the base unit and then converts that value to the selected target unit.

Temperature is handled separately because Celsius, Kelvin, and Fahrenheit cannot be converted using simple multiplication factors. Dedicated formulas are used for these conversions.

The application recalculates conversions automatically whenever the input value or source unit changes.

## User Interface

The application includes:

* Source value input
* Source unit selection
* Target unit selection
* Search fields for both unit lists
* Conversion result display
* Swap button
* Copy button
* Theme toggle
* Tab-based measurement categories

The interface supports both light and dark themes with customized colors and tab rendering.

## Technologies

* **C#**
* **.NET**
* **Windows Forms**
* `System.Drawing`
* `System.Windows.Forms`
* `System.Threading.Tasks`

## Getting Started

### Prerequisites

Make sure you have:

* Windows
* Visual Studio
* A compatible .NET SDK/runtime
* Windows Forms support

### Installation

1. Clone the repository:

```bash
git clone <repository-url>
```

2. Open the project in **Visual Studio**.

3. Build the solution.

4. Run the application.

## Usage

1. Select a measurement category from the tabs.
2. Enter the value you want to convert.
3. Select the source unit.
4. Select the target unit.
5. The converted value will be displayed automatically.
6. Use the **Swap** button to reverse the conversion.
7. Use the **Copy** button to copy the result.
8. Use the search fields to quickly find units.
9. Use the theme button to switch between light and dark modes.


## Notes

The application currently uses predefined conversion factors for supported units. The conversion logic and supported unit lists are implemented directly in the application code.

## Future Improvements

Possible improvements include:

* Add more measurement categories.
* Add currency conversion.
* Add customizable units.
* Improve validation for invalid input.
* Add conversion history.
* Add localization and multiple languages.
* Improve accessibility.
* Add automated unit tests.
* Move conversion factors and unit definitions into separate classes or configuration files.
* Improve numerical precision for scientific conversions.