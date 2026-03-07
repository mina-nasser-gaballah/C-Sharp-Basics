using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        #region Q1
        // (a) Explanation:
        // String concatenation using '+=' is inefficient because strings are immutable in C#.
        // Every time a string is modified, a new string object is created, leaving the old one for garbage collection.
        // This causes many memory allocations and poor performance in loops.
        
        // (b) Rewrite using StringBuilder
        // StringBuilder is more efficient because it maintains a buffer and modifies the string in place.
        
        // (c) Timing both versions
        Console.WriteLine("=== Q1: Timing string vs StringBuilder ===");
        
        // Inefficient way (String concatenation)
        Stopwatch sw1 = Stopwatch.StartNew();
        string productList = "";
        for (int i = 1; i <= 5000; i++)
        {
            productList += "PROD-" + i + ",";
        }
        sw1.Stop();
        Console.WriteLine($"String concatenation took: {sw1.ElapsedMilliseconds} ms");

        // Efficient way using StringBuilder
        Stopwatch sw2 = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= 5000; i++)
        {
            sb.Append("PROD-").Append(i).Append(",");
        }
        string efficientProductList = sb.ToString();
        sw2.Stop();
        Console.WriteLine($"StringBuilder took: {sw2.ElapsedMilliseconds} ms");
        #endregion
        
        Console.WriteLine("\n------------------------------------------------\n");

        #region Q2
        Console.WriteLine("=== Q2: Cinema Ticket Pricing ===");
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine() ?? "0");
        
        Console.Write("Enter day of week (1-7, where 6=Fri, 7=Sat): ");
        int day = int.Parse(Console.ReadLine() ?? "0");
        
        Console.Write("Do you have a student ID? (yes/no): ");
        bool isStudent = Console.ReadLine()?.Trim().ToLower() == "yes";

        double basePrice = 0;
        if (age < 5) 
            basePrice = 0;
        else if (age >= 5 && age <= 12) 
            basePrice = 30;
        else if (age >= 13 && age <= 59) 
            basePrice = 50;
        else if (age >= 60) 
            basePrice = 25;

        double finalPrice = basePrice;
        
        bool isWeekend = (day == 6 || day == 7);
        if (isWeekend && basePrice > 0)
        {
            finalPrice += 10; // Weekend surcharge
        }

        if (isStudent && basePrice > 0)
        {
            finalPrice -= (finalPrice * 0.20); // 20% discount applied after weekend surcharge
        }

        Console.WriteLine($"\nFinal Price: {finalPrice} LE");
        Console.WriteLine($"Breakdown -> Base Ticket: {basePrice} LE, Weekend Surcharge: {(isWeekend && basePrice > 0 ? "+10 LE" : "0 LE")}, Student Discount: {(isStudent && basePrice > 0 ? "-20%" : "0%")}");
        #endregion

        Console.WriteLine("\n------------------------------------------------\n");

        #region Q3
        Console.WriteLine("=== Q3: Switch Statement vs Switch Expression ===");
        string fileExtension = ".pdf";
        string fileType1, fileType2;

        // (a) Traditional switch statement
        switch (fileExtension)
        {
            case ".pdf":
                fileType1 = "PDF Document";
                break;
            case ".doc":
            case ".docx":
                fileType1 = "Word Document";
                break;
            case ".xls":
            case ".xlsx":
                fileType1 = "Excel Spreadsheet";
                break;
            case ".jpg":
            case ".png":
            case ".gif":
                fileType1 = "Image file";
                break;
            default:
                fileType1 = "Unknown File Type";
                break;
        }
        Console.WriteLine($"(a) Traditional Switch Result: {fileType1}");

        // (b) Switch expression
        fileType2 = fileExtension switch
        {
            ".pdf" => "PDF Document",
            ".doc" or ".docx" => "Word Document",
            ".xls" or ".xlsx" => "Excel Spreadsheet",
            ".jpg" or ".png" or ".gif" => "Image file",
            _ => "Unknown File Type"
        };
        Console.WriteLine($"(b) Switch Expression Result: {fileType2}");
        #endregion

        Console.WriteLine("\n------------------------------------------------\n");

        #region Q4
        Console.WriteLine("=== Q4: Ternary Operator ===");
        int temperature = 31;
        
        // Rewrite using only ternary operators
        string weatherAdvice = 
            (temperature < 0) ? "Freezing! Stay indoors." :
            (temperature < 15) ? "Cold. Wear a jacket." :
            (temperature < 25) ? "Pleasant weather." :
            (temperature < 35) ? "Warm. Stay hydrated." : 
            "Hot! Avoid sun exposure.";
            
        Console.WriteLine($"Temperature: {temperature}");
        Console.WriteLine($"Advice: {weatherAdvice}");
        
        Console.WriteLine("\nIs the ternary version more readable?");
        Console.WriteLine("Answer: While it uses less lines of code, chaining nested ternary operators like this can become harder to read compared to standard if-else blocks. You generally should only choose ternary operators for simple, single-condition assignments. For multiple conditions like this, if-else or switch expressions are much more readable.");
        #endregion

        Console.WriteLine("\n------------------------------------------------\n");

        #region Q5
        Console.WriteLine("=== Q5: Password Validation ===");
        int attempts = 0;
        bool isValid = false;

        do
        {
            if (attempts >= 5)
            {
                Console.WriteLine("Account locked");
                break;
            }

            Console.Write($"Enter password (Attempt {attempts + 1}/5): ");
            string password = Console.ReadLine() ?? "";

            bool hasUpper = false;
            bool hasDigit = false;
            bool hasSpace = false;

            // Iterate through characters to check conditions (as per hint)
            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsDigit(c)) hasDigit = true;
                if (char.IsWhiteSpace(c)) hasSpace = true;
            }

            // Provide specific rule violations
            if (password.Length < 8)
                Console.WriteLine("Error: Minimum 8 characters required.");
            else if (!hasUpper)
                Console.WriteLine("Error: At least one uppercase letter required.");
            else if (!hasDigit)
                Console.WriteLine("Error: At least one digit required.");
            else if (hasSpace)
                Console.WriteLine("Error: No spaces allowed.");
            else
            {
                isValid = true;
                Console.WriteLine("Password accepted!");
            }

            attempts++;

        } while (!isValid);
        #endregion

        Console.WriteLine("\n------------------------------------------------\n");

        #region Q6
        Console.WriteLine("=== Q6: Array Processing ===");
        int[] scores = { 85, 41, 91, 67, 55, 78, 39, 88, 72, 95, 60, 48 };
        
        // (a) Find and display all failing scores (below 50)
        Console.WriteLine("(a) Failing scores (below 50):");
        foreach (int score in scores)
        {
            if (score < 50) Console.WriteLine(score);
        }

        // (b) Find the first score above 90 and stop searching immediately
        Console.WriteLine("\n(b) First score above 90:");
        foreach (int score in scores)
        {
            if (score > 90)
            {
                Console.WriteLine(score);
                break; // Stop immediately
            }
        }

        // (c) Calculate the class average, excluding any scores below 40 (considered absent)
        int sum = 0, validCount = 0;
        foreach (int score in scores)
        {
            if (score >= 40)
            {
                sum += score;
                validCount++;
            }
        }
        Console.Write("\n(c) Class average (excluding absent): ");
        if (validCount > 0)
            Console.WriteLine((double)sum / validCount);
        else 
            Console.WriteLine("0");

        // (d) Count how many students scored in each grade range
        int countA = 0, countB = 0, countC = 0, countD = 0, countF = 0;
        foreach (int score in scores)
        {
            if (score >= 90) countA++;
            else if (score >= 80) countB++;
            else if (score >= 70) countC++;
            else if (score >= 60) countD++;
            else countF++; // Below 60
        }
        
        Console.WriteLine("\n(d) Grade range counts:");
        Console.WriteLine($"A: 90-100: {countA}");
        Console.WriteLine($"B: 80-89: {countB}");
        Console.WriteLine($"C: 70-79: {countC}");
        Console.WriteLine($"D: 60-69: {countD}");
        Console.WriteLine($"F: Below 60: {countF}");
        #endregion
        
        Console.WriteLine("\nFinished executing.");
    }
}
