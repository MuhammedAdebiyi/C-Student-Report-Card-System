enum Grade
{
    A, B, C, D, F
}

class Program
{
    static void Main(string[] args)
    {
        string[] students = { "Tunde", "Fola", "Tola", "Aisha", "Tola" };
        int[,] scores = {
            {85, 90, 82},
            {98, 87, 92},
            {78, 86, 82},
            {76, 98, 72},
            {98, 87, 92}
        };

        int[] gradeCount = new int[5];

        Console.WriteLine("STUDENT REPORT CARD");

        for (int i = 0; i < students.Length; i++)
        {
            string student = students[i];
            int math = scores[i, 0];
            int english = scores[i, 1];
            int science = scores[i, 2];

            int total = math + english + science;
            double average = total / 3.0;

            Grade grade;

            if (average >= 90)
            {
                grade = Grade.A;
            }
            else if (average >= 80)
            {
                grade = Grade.B;
            }
            else if (average >= 70)
            {
                grade = Grade.C;
            }
            else if (average >= 60)
            {
                grade = Grade.D;
            }
            else
                grade = Grade.F;
            gradeCount[(int)grade]++;

            string remark = grade switch
            {
                Grade.A => "Genius!",
                Grade.B => "Great job.",
                Grade.C => "Good effort.",
                Grade.D => "Needs improvement.",
                Grade.F => "Try harder."
            };

            Console.WriteLine($"Students: {student}");
            Console.WriteLine($"Subjects -> Maths: {math}, English: {english}, Science: {science}");
            Console.WriteLine($"Average: {average:F2}");
            Console.WriteLine($"Grade: {grade} ({(int)grade}) -> {remark}");

            if (average >= 85)
                Console.WriteLine("Top Performer");

            Console.WriteLine(new string('-', 40));
        }

        Console.WriteLine("GRADE SUMMARY");
        Console.WriteLine($"A: {gradeCount[0]} student(s)");
        Console.WriteLine($"B: {gradeCount[1]} student(s)");
        Console.WriteLine($"C: {gradeCount[2]} student(s)");
        Console.WriteLine($"D: {gradeCount[3]} student(s)");
        Console.WriteLine($"F: {gradeCount[4]} student(s)");


    }
}