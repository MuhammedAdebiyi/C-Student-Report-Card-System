# C-Student-Report-Card-System Student Report Card System
This is a console-based C# application that simulates a student report card system. It calculates average scores, assigns grades using an enum, and provides remarks and performance insights for each student.

🛠️ Features
Accepts multiple student names and scores

Uses a 2D array to store subject scores

Calculates:

Total and average per student

Letter grade using enum Grade { A, B, C, D, F }

Dynamic remarks using switch expression

Highlights top performers (average ≥ 85)

Summary count of each grade

🧪 Sample Output:

STUDENT REPORT CARD
Student: Tunde
Scores -> Math: 85, English: 90, Science: 82
Average: 85.67
Grade: B (1) -> Great job!
Top Performer
----------------------------------------

📊 GRADE SUMMARY:
A: 0 student(s)
B: 3 student(s)
C: 2 student(s)
D: 1 student(s)
F: 0 student(s)
🧠 Concepts Used
enum

2D arrays

switch expressions

if-else logic

Loops (for)

Array indexing and counters

📁 How to Run
Clone the repository:

bash
Copy
Edit
git clone https://github.com/MuhammedAdebiyi/C-Student-Report-Card-System
Navigate to the project directory:

cd "Student Report Card System"  # or your correct folder
Run the program:

dotnet run
📚 What I Learned
How to use enums for grading systems

Looping through 2D arrays

Logical comparison and performance evaluation

Output formatting and dynamic string interpolation
