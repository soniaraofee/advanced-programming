import pandas as pd
import matplotlib.pyplot as plt


try:
    df = pd.read_excel("students.xlsx")
except FileNotFoundError:
    print("Error: Excel file not found. Please check the file path.")
    exit()


print("--- Data successfully loaded ---")

target_gender = input(
    "Please enter the gender (e.g., 'male' or 'female'): "
).strip()

filtered_df = df[df["Gender"] == target_gender]


if filtered_df.empty:
    print(f"No data found for gender: '{target_gender}'")
else:
    min_age = filtered_df["Age"].min()
    max_age = filtered_df["Age"].max()
    avg_age = filtered_df["Age"].mean()

    min_gpa = filtered_df["GPA"].min()
    max_gpa = filtered_df["GPA"].max()
    avg_gpa = filtered_df["GPA"].mean()

    print(f"\nStatistics for gender: {target_gender}")
    print(
        f"Min Age: {min_age} | "
        f"Max Age: {max_age} | "
        f"Average Age: {avg_age:.2f}"
    )

    print(
        f"Min GPA: {min_gpa} | "
        f"Max GPA: {max_gpa} | "
        f"Average GPA: {avg_gpa:.2f}"
    )


plt.figure(figsize=(12, 5))


# Average GPA by gender
plt.subplot(1, 2, 1)

gender_gpa_avg = df.groupby("Gender")["GPA"].mean()

gender_gpa_avg.plot(
    kind="bar",
    color=["pink", "lightblue"]
)

plt.title("Average GPA by Gender")
plt.xlabel("Gender")
plt.ylabel("Average GPA")
plt.xticks(rotation=0)


# Average GPA by age
plt.subplot(1, 2, 2)

age_gpa_avg = df.groupby("Age")["GPA"].mean().reset_index()

plt.plot(
    age_gpa_avg["Age"],
    age_gpa_avg["GPA"],
    marker="o",
    color="purple",
    linestyle="-"
)

plt.title("Average GPA by Age")
plt.xlabel("Age")
plt.ylabel("Average GPA")
plt.grid(True, linestyle="--", alpha=0.6)


plt.tight_layout()
plt.show()