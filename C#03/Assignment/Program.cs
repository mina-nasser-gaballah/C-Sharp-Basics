using System;

class Program
{
    static void Main()
    {
        #region Q1
        // Q1: What will this print and explain what happens?
        // Casting double → int removes decimal part (no rounding)
        double d = 9.99;
        int x = (int)d;
        Console.WriteLine(x);
        #endregion

        #region Q2
        // Q2: This code doesn’t compile. Fix it with the smallest change?
        // Using 2.0 makes division double division
        int n = 5;
        double d2 = n / 2.0;
        Console.WriteLine(d2);
        #endregion

        #region Q3
        // Q3: You read a number from user input .. Write the correct line to get age as int.
        int age = Convert.ToInt32(Console.ReadLine());
        #endregion

        #region Q4
        // Q4: What happens here and why?
        // int.Parse("12a") would throw FormatException because string contains letters
        string s = "12a";
        Console.WriteLine("Q4: FormatException (\"12a\" is not a number).");
        #endregion

        #region Q5
        // Q5: Print Invalid if conversion fails, otherwise print the number
        // Using nullable int + ?? operator
        string s5 = "12a";
        int? num5 = int.TryParse(s5, out int temp5) ? temp5 : null;
        Console.WriteLine(num5?.ToString() ?? "Invalid");
        #endregion

        #region Q6
        // Q6: What will this print and explain why?
        // Object contains boxed int 10 → unboxed then +1
        object o6 = 10;
        int a6 = (int)o6;
        Console.WriteLine(a6 + 1);
        #endregion

        #region Q7
        // Q7: Casting object containing int directly to long causes exception
        // Convert handles conversion safely
        object o7 = 10;
        long x7 = Convert.ToInt64(o7);
        Console.WriteLine(x7);
        #endregion

        #region Q8
        // Q8: Avoid exception and print -1 if conversion isn’t possible
        object o8 = 10;
        long.TryParse(o8?.ToString(), out long x8);
        Console.WriteLine(x8 == 0 ? -1 : x8);
        #endregion

        #region Q9
        // Q9: ?. prevents NullReferenceException and returns null
        string? name = null;
        Console.WriteLine(name?.Length);
        #endregion

        #region Q10
        // Q10: ?. returns null then ?? replaces with 0
        string? name2 = null;
        int length = name2?.Length ?? 0;
        Console.WriteLine(length);
        #endregion

        #region Q11
        // Q11: int.Parse(s ?? "0") only protects null not invalid text
        // TryParse avoids exception
        string? s11 = null;
        int.TryParse(s11, out int x11);
        Console.WriteLine(x11);
        #endregion

        #region Q12
        // Q12: ! removes compiler warning only
        // ?. safely prevents runtime crash
        string? s12 = null;
        Console.WriteLine(s12?.Length ?? 0);
        #endregion

        #region Q13
        // Q13: Convert.ToInt32(null) returns 0
        string? s13 = null;
        int x13 = Convert.ToInt32(s13);
        Console.WriteLine(x13);
        #endregion

        #region Q14
        // Q14:
        // int.Parse(null) → throws exception
        // Convert.ToInt32(null) → returns 0
        Console.WriteLine("Q14: Parse(null) throws, Convert.ToInt32(null) returns 0.");
        #endregion

        #region Q15
        // Q15: Print Guest when user is null otherwise uppercase name
        string? user = null;
        Console.WriteLine((user ?? "Guest").ToUpper());
        #endregion
    }
}
