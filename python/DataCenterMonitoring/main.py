import numpy as np
import pandas as pd
import matplotlib.pyplot as plt
import random
def get_sensor_data():
    sensors = []

    print("Enter the sensor information.")
    print("\nPress Enter on an empty line to finish.")

    while True:
        line = input()

        if line.strip() == "":
            break

        try:
            sensor_id, name, temp, power = line.split(",")

            sensor = {
                "SensorID": int(sensor_id),
                "SensorName": name.strip(),
                "Temperature": float(temp),
                "Power": float(power)
            }

            sensors.append(sensor)

        except ValueError:
            print("Invalid input format. Please try again.")

    return sensors

def average_temperature(sensors):
    total = 0
    for sensor in sensors:
        total += sensor["Temperature"]
    return total / len(sensors)

def average_power(sensors):
    total = 0
    for sensor in sensors:
        total += sensor["Power"]
    return total / len(sensors)

def max_min_temperature(sensors):
    max_temp = sensors[0]["Temperature"]
    min_temp = sensors[0]["Temperature"]

    for sensor in sensors:
        if sensor["Temperature"] > max_temp:
            max_temp = sensor["Temperature"]

        if sensor["Temperature"] < min_temp:
            min_temp = sensor["Temperature"]

    return max_temp, min_temp

def search_sensor(sensors, sensor_id):
    for sensor in sensors:
        if sensor["SensorID"] == sensor_id:
            return sensor
    return None

def show_sensors(sensors):
    for sensor in sensors:
        print(sensor)

def count_status(sensors):
    normal = 0
    warning = 0
    critical = 0

    for sensor in sensors:
        temp = sensor["Temperature"]

        if temp < 50:
            normal += 1
        elif temp <= 70:
            warning += 1
        else:
            critical += 1

    print("Normal :", normal)
    print("Warning:", warning)
    print("Critical:", critical)

def sensor_status(temperature):
    if temperature < 50:
        return "Normal"
    elif temperature <= 70:
        return "Warning"
    else:
        return "Critical"

def analyze_sensors(sensors):
    for sensor in sensors:
        status = sensor_status(sensor["Temperature"])
        print(sensor["SensorName"], "---->", status)

def show_status(status):
    print("Status =", bin(status))

    if status & (1 << 0):
        print("Bit0 = 1 -> Sensor Active")
    else:
        print("Bit0 = 0")

    if status & (1 << 1):
        print("Bit1 = 1 -> Alarm")
    else:
        print("Bit1 = 0")

    if status & (1 << 2):
        print("Bit2 = 1 -> Need Service")
    else:
        print("Bit2 = 0")

    if status & (1 << 3):
        print("Bit3 = 1 -> Emergency")
    else:
        print("Bit3 = 0")

def set_bit(status, bit):
    return status | (1 << bit)

def clear_bit(status, bit):
    return status & ~(1 << bit)

def toggle_bit(status, bit):
    return status ^ (1 << bit)

def name_length(name):
    return len(name)

def to_upper(name):
    return name.upper()

def find_character(name, ch):
    return name.count(ch)

def slice_name(name):
    return name[:2]

def process_name(name):
    print(name)
    print("Length :", name_length(name))
    print("Upper :", to_upper(name))
    print("Find 'P' :", find_character(name, "P"))
    print("Slice :", slice_name(name))

def print_all_names(sensors):
    names = []

    for sensor in sensors:
        names.append(sensor["SensorName"])

    print(" | ".join(names))

def analyze_numpy(sensors):

    temperatures = np.array([sensor["Temperature"] for sensor in sensors])
    powers = np.array([sensor["Power"] for sensor in sensors])

    print("Temperatures")
    print(temperatures)

    print("\nSorted")
    print(np.sort(temperatures))

    print("\nSum =", np.sum(temperatures))

    print("Average =", np.mean(temperatures))

    print("Maximum =", np.max(temperatures))

    print("Minimum =", np.min(temperatures))

    print("\nReshape")
    print(temperatures.reshape(len(temperatures), 1))

    print("\nStandard Array")
    print(np.zeros(5))
    print(np.ones(5))

    print("\nRandom Temperatures")
    print(np.random.randint(30, 90, 5))

def create_dataframe(sensors):

    df = pd.DataFrame(sensors)

    return df

def dataframe_info(df):

    print("DataFrame")
    print(df)

    print("\nColumns")
    print(df.columns)

    print("\nData Types")
    print(df.dtypes)

    print("\nNumber of Records")
    print(len(df))

    print("\nAverage Temperature")
    print(df["Temperature"].mean())

    print("\nStatistical Summary")
    print(df.describe())

    print("\nFirst Three Rows")
    print(df.head(3))

    print("\nSensor Name and Temperature")
    print(df[["SensorName", "Temperature"]])

def draw_charts(sensors):

    sensor_ids = [sensor["SensorID"] for sensor in sensors]
    sensor_names = [sensor["SensorName"] for sensor in sensors]
    temperatures = [sensor["Temperature"] for sensor in sensors]
    powers = [sensor["Power"] for sensor in sensors]

    plt.figure(figsize=(8,5))
    plt.plot(sensor_ids, temperatures,
             marker='o',
             color='blue',
             label='Temperature')

    plt.title("Temperature of Sensors")
    plt.xlabel("Sensor ID")
    plt.ylabel("Temperature")
    plt.grid(True)
    plt.legend()
    plt.show()

    plt.figure(figsize=(8,5))
    plt.bar(sensor_names,
            powers,
            color='green',
            label='Power')

    plt.title("Power Consumption")
    plt.xlabel("Sensor Name")
    plt.ylabel("Power")
    plt.grid(axis='y')
    plt.legend()
    plt.show()

def final_report(sensors):

    total_sensors = len(sensors)

    avg_temp = average_temperature(sensors)
    avg_power = average_power(sensors)

    max_temp, min_temp = max_min_temperature(sensors)

    highest_sensor = ""
    for sensor in sensors:
        if sensor["Temperature"] == max_temp:
            highest_sensor = sensor["SensorName"]
            break

    critical_count = 0
    for sensor in sensors:
        if sensor_status(sensor["Temperature"]) == "Critical":
            critical_count += 1

    random_sensor = random.choice(sensors)["SensorName"]

    print("=" * 45)
    print("           DATA CENTER REPORT")
    print("=" * 45)

    print(f"Total Sensors        : {total_sensors}")
    print(f"Average Temperature  : {avg_temp:.2f}")
    print(f"Average Power        : {avg_power:.2f}")
    print(f"Maximum Temperature  : {max_temp}")
    print(f"Minimum Temperature  : {min_temp}")
    print(f"Critical Sensors     : {critical_count}")
    print(f"Highest Temperature  : {highest_sensor}")
    print(f"Random Selected Sensor : {random_sensor}")

    print("=" * 45)


sensor_list = get_sensor_data()

print("\nRecorded Data:")
for sensor in sensor_list:
    print(sensor)

print("Average Temperature:", average_temperature(sensor_list))
print("Average Power:", average_power(sensor_list))

mx, mn = max_min_temperature(sensor_list)
print("Maximum Temperature:", mx)
print("Minimum Temperature:", mn)

analyze_sensors(sensor_list)

count_status(sensor_list)

sensor = search_sensor(sensor_list, 103)
print(sensor)

status = 0b0101

show_status(status)

status = set_bit(status, 1)
status = clear_bit(status, 2)
status = toggle_bit(status, 3)

print("Final Status =", bin(status))
process_name("CPU")
print()

print_all_names(sensor_list)
analyze_numpy(sensor_list)
df = create_dataframe(sensor_list)

dataframe_info(df)
draw_charts(sensor_list)