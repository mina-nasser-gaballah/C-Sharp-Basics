using System;

class Program
{
    // Part 1: Enums
    enum DayOfWeekEnum
    {
        Saturday = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6
    }

    // Part 4 (Integration): Grade Enum
    enum Grade
    {
        A,
        B,
        C,
        D,
        F
    }

    static void Main()
    {
        Console.WriteLine("============================");
        Console.WriteLine("       PART 1: ENUMS        ");
        Console.WriteLine("============================\n");
        Part1_Enums();

        Console.WriteLine("\n\n============================");
        Console.WriteLine("       PART 2: ARRAYS       ");
        Console.WriteLine("============================\n");
        Part2_Arrays_Q1();
        Console.WriteLine("\n----------------------------\n");
        Part2_Arrays_Q2();

        Console.WriteLine("\n\n============================");
        Console.WriteLine("     PART 3: FUNCTIONS      ");
        Console.WriteLine("============================\n");
        Part3_Functions_Q1();
        Console.WriteLine("\n----------------------------\n");
        Part3_Functions_Q2();

        Console.WriteLine("\n\n===============================");
        Console.WriteLine(" PART 4: STUDENT GRADE MANAGER ");
        Console.WriteLine("===============================\n");
        Part4_StudentGradeManager();
        
        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }

    #region Part 1: Enums
    static void Part1_Enums()
    {
        Console.Write("Enter a day number (0-6): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 0 && dayNumber <= 6)
        {
            DayOfWeekEnum day = (DayOfWeekEnum)dayNumber;
            Console.WriteLine($"Day: {day}");

            switch (day)
            {
                case DayOfWeekEnum.Saturday:
                case DayOfWeekEnum.Friday:
                    Console.WriteLine("It's the weekend");
                    break;
                default:
                    Console.WriteLine("It's a workday");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid day number.");
        }
    }
    #endregion

    #region Part 2: Arrays
    static void Part2_Arrays_Q1()
    {
        Console.WriteLine("--- Q1: Array Statistics ---\n");
        Console.Write("Enter array size: ");
        if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
        {
            int[] arr = new int[size];
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element [{i}]: ");
                arr[i] = int.Parse(Console.ReadLine() ?? "0");
                
                sum += arr[i];
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            double average = (double)sum / size;

            Console.WriteLine($"\nSum      : {sum}");
            Console.WriteLine($"Average  : {average:F1}");
            Console.WriteLine($"Max      : {max}");
            Console.WriteLine($"Min      : {min}");

            Console.Write("Reverse  : ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + (i > 0 ? ", " : ""));
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid array size.");
        }
    }

    static void Part2_Arrays_Q2()
    {
        Console.WriteLine("--- Q2: Student Grades Matrix ---\n");
        int numStudents = 3;
        int numSubjects = 4;
        
        int[,] grades = new int[numStudents, numSubjects];
        int overallSum = 0;

        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}:");
            int studentSum = 0;
            for (int j = 0; j < numSubjects; j++)
            {
                Console.Write($"  Subject {j + 1} grade: ");
                int grade = int.Parse(Console.ReadLine() ?? "0");
                grades[i, j] = grade;
                studentSum += grade;
                overallSum += grade;
            }
            double studentAvg = (double)studentSum / numSubjects;
            Console.WriteLine($"  -> Average Grade: {studentAvg:F1}\n");
        }

        double overallAvg = (double)overallSum / (numStudents * numSubjects);
        Console.WriteLine($"Overall Class Average: {overallAvg:F1}");
    }
    #endregion

    #region Part 3: Functions
    static void Part3_Functions_Q1()
    {
        Console.WriteLine("--- Q1: Basic Calculator Functions ---\n");
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine() ?? "0");
        
        Console.Write("Enter operation (+, -, *, /): ");
        string op = Console.ReadLine() ?? "";
        
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine() ?? "0");

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {Add(num1, num2)}");
                break;
            case "-":
                Console.WriteLine($"Result: {Subtract(num1, num2)}");
                break;
            case "*":
                Console.WriteLine($"Result: {Multiply(num1, num2)}");
                break;
            case "/":
                double result = Divide(num1, num2);
                if (!double.IsNaN(result))
                {
                    Console.WriteLine($"Result: {result}");
                }
                break;
            default:
                Console.WriteLine("Invalid operation.");
                break;
        }
    }

    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;
        }
        return a / b;
    }

    static void Part3_Functions_Q2()
    {
        Console.WriteLine("--- Q2: Circle Calculator with out ---\n");
        Console.Write("Enter radius: ");
        if (double.TryParse(Console.ReadLine(), out double radius) && radius > 0)
        {
            CalculateCircle(radius, out double area, out double circumference);
            Console.WriteLine($"Area          : {area:F2}");
            Console.WriteLine($"Circumference : {circumference:F2}");
        }
        else
        {
            Console.WriteLine("Invalid radius.");
        }
    }

    static void CalculateCircle(double radius, out double area, out double circumference)
    {
        area = Math.PI * radius * radius;
        circumference = 2 * Math.PI * radius;
    }
    #endregion

    #region Part 4: Mini Student Grade Manager
    static void Part4_StudentGradeManager()
    {
        int studentsCount = 5;
        int[] scores = new int[studentsCount];

        // 1. Read 5 student scores from the user
        for (int i = 0; i < studentsCount; i++)
        {
            Console.Write($"Enter score for Student {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        Console.WriteLine("\n--- Report ---");
        
        // 2. Print each student's score and corresponding letter grade
        for (int i = 0; i < studentsCount; i++)
        {
            Grade grade = GetGrade(scores[i]);
            Console.WriteLine($"Student {i + 1}: {scores[i]} -> Grade: {grade}");
        }

        // 3. Print class average, minimum, and maximum scores
        double avg = CalculateAverage(scores);
        GetMinMax(scores, out int minScore, out int maxScore);

        Console.WriteLine($"\nAverage: {avg:F1}");
        Console.WriteLine($"Highest Score: {maxScore}");
        Console.WriteLine($"Lowest Score: {minScore}");
    }

    // a) Method To GetGrade returns the grade enum based on score
    static Grade GetGrade(int score)
    {
        if (score >= 90) return Grade.A;
        if (score >= 80) return Grade.B;
        if (score >= 70) return Grade.C;
        if (score >= 60) return Grade.D;
        return Grade.F;
    }

    // b) Method To CalculateAverage returns the average of all scores
    static double CalculateAverage(int[] scores)
    {
        if (scores.Length == 0) return 0;
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        return (double)sum / scores.Length;
    }

    // c) Method To GetMinMax finds the min and max scores using out
    static void GetMinMax(int[] scores, out int min, out int max)
    {
        if (scores.Length == 0)
        {
            min = 0;
            max = 0;
            return;
        }

        min = scores[0];
        max = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < min) min = scores[i];
            if (scores[i] > max) max = scores[i];
        }
    }
    #endregion
}
