using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpAssignment
{
    class Program
    {
        // Class-level field for scope demonstrations
        static int classField = 100;

        // Static field for lifetime demo (Q6)
        static int staticCounter = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║           C# FUNDAMENTALS - ASSIGNMENT WITH ANSWERS                ║");
            Console.WriteLine("║                      20 Questions                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════╝\n");


            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 2: REGIONS");
            Console.WriteLine("Answer: They help organize code in the editor by letting you collapse/expand parts of code.");
            Console.WriteLine("They do not change how the program runs.");

            //Nested Region Example
            #region Outer Region
            #region Inner Region
            Console.WriteLine("Nested region example line.");
            #endregion
            #endregion

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 3: EXPLICIT VS IMPLICIT VARIABLES");
            Console.WriteLine("Answer: Explicit = you write the type. Implicit = use var and C# guesses the type.");

            // EXPLICIT DECLARATION 
            int age = 16;
            string name = "Ahmed";
            Console.WriteLine($"Explicit example -> age: {age}, name: {name}");

            // IMPLICIT DECLARATION 
            var score = 95;      // int
            var city = "Cairo";  // string
            Console.WriteLine($"Implicit example -> score: {score}, city: {city}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 4: CONSTANTS");
            Console.WriteLine("Answer: Syntax is: const type NAME = value; Use it when the value must not change.");

            // Constant examples
            const double PI = 3.14;
            const int MaxStudents = 30;
            Console.WriteLine($"PI = {PI}, MaxStudents = {MaxStudents}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 4: CLASS SCOPE VS METHOD SCOPE");
            Console.WriteLine("Answer: Class-level variables (fields) can be used in all methods. Method-level variables work only inside the method.");

            Console.WriteLine($"Class-level field classField = {classField}");
            int methodVar = 50;
            Console.WriteLine($"Method-level variable methodVar = {methodVar}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 5: BLOCK-LEVEL SCOPE");
            Console.WriteLine("Answer: A variable inside { } can be used only inside that block.");

            if (true)
            {
                int blockVar = 10;
                Console.WriteLine($"Inside block -> blockVar = {blockVar}");
            }
            // Console.WriteLine(blockVar); // not allowed

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 6: LIFETIME (LOCAL VS STATIC)");
            Console.WriteLine("Answer: Local variables exist while the method runs. Static variables exist during the whole program.");

            staticCounter++;
            Console.WriteLine($"Static counter = {staticCounter}");

            int localTemp = 5;
            Console.WriteLine($"Local variable localTemp = {localTemp}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 7: GARBAGE COLLECTOR");
            Console.WriteLine("Answer: GC automatically frees memory for objects that are no longer used (no references).");

            object tempObj = new object();
            Console.WriteLine("Created an object.");
            tempObj = null; // now it can be collected later
            Console.WriteLine("Set object to null -> it can be collected later by GC.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 8: VARIABLE SHADOWING");
            Console.WriteLine("Answer: Shadowing is using the same name in an inner scope to hide an outer one.");
            Console.WriteLine("C# does NOT allow local variable shadowing of another local variable in a nested block in the same method.");

            // Example: local variable has different name (safe example)
            int shadowExample = 999;
            Console.WriteLine($"Example value = {shadowExample}");

            // Not allowed (compile error) - keep commented:
            // int x = 5;
            // if (true) { int x = 10; }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 9: NAMING RULES");
            Console.WriteLine("1) Start with a letter or _");
            Console.WriteLine("2) Cannot start with a number");
            Console.WriteLine("3) Can use letters, numbers, _");
            Console.WriteLine("4) Cannot be a keyword (unless using @)");
            Console.WriteLine("5) Case-sensitive (age != Age)");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 10: NAMING CONVENTIONS");
            Console.WriteLine("(a) Local variables: camelCase");
            Console.WriteLine("(b) Class names: PascalCase");
            Console.WriteLine("(c) Constants: PascalCase");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 11: ERROR TYPES");
            Console.WriteLine("Syntax error: code doesn't compile (example: missing ;).");
            Console.WriteLine("Runtime error: happens while running (example: divide by zero).");
            Console.WriteLine("Logical error: code runs but gives wrong result.");

            // Syntax error example (commented):
            // Console.WriteLine(\"Hello\"   // missing );

            try
            {
                int a = 10, b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Runtime example caught: DivideByZeroException");
            }

            int p = 5, q = 10;
            Console.WriteLine($"Logical example (should add but subtract): {p - q}");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 12: WHY EXCEPTION HANDLING?");
            Console.WriteLine("Answer: It stops the program from crashing and lets you show a message and continue safely.");
            Console.WriteLine("Without handling, the program may close suddenly.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 13: TRY-CATCH-FINALLY");
            Console.WriteLine("Answer: finally runs whether there is an exception or not.");

            try
            {
                int a = 10, b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Caught: cannot divide by zero.");
            }
            finally
            {
                Console.WriteLine("Finally block runs every time.");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 14: COMMON EXCEPTIONS");
            Console.WriteLine("1) NullReferenceException: using a null object");
            Console.WriteLine("2) DivideByZeroException: dividing by zero");
            Console.WriteLine("3) FormatException: wrong number/text format");
            Console.WriteLine("4) OverflowException: number too big/small for type");
            Console.WriteLine("5) InvalidCastException: converting to wrong type");

            // Simple examples (no arrays/lists)
            try
            {
                string s = null;
                Console.WriteLine(s.Length); // NullReferenceException
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Example caught: NullReferenceException");
            }

            try
            {
                int a = 10, b = 0;
                Console.WriteLine(a / b); // DivideByZeroException
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Example caught: DivideByZeroException");
            }

            try
            {
                int num = int.Parse("abc"); // FormatException
            }
            catch (FormatException)
            {
                Console.WriteLine("Example caught: FormatException");
            }

            try
            {
                checked
                {
                    int big = int.MaxValue;
                    big = big + 1; // OverflowException (in checked)
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Example caught: OverflowException");
            }

            try
            {
                object o = "Hello";
                int n = (int)o; // InvalidCastException
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Example caught: InvalidCastException");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 15: MULTIPLE CATCH ORDER");
            Console.WriteLine("Answer: Put specific exceptions first, then general Exception last.");

            try
            {
                int a = 10, b = 0;
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Specific catch: DivideByZeroException");
            }
            catch (Exception)
            {
                Console.WriteLine("General catch: Exception");
            }

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 16: throw vs throw ex");
            Console.WriteLine("Answer: throw keeps the original stack trace. throw ex resets it.");
            Console.WriteLine("So: throw; preserves the stack trace.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 17: STACK VS HEAP");
            Console.WriteLine("Answer: Stack stores local variables and method calls. Heap stores objects made with new.");

            int stackNumber = 5;        // simple local variable (stack)
            object heapObject = new object(); // object (heap)
            Console.WriteLine($"Stack example number: {stackNumber}");
            Console.WriteLine("Heap example: created an object with new.");

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 18: VALUE VS REFERENCE TYPES");
            Console.WriteLine("Answer: Value types copy the value. Reference types copy the reference (point to same object).");

            // Value type example (int)
            int v1 = 5;
            int v2 = v1; // copy value
            v2 = 10;
            Console.WriteLine($"Value type -> v1={v1}, v2={v2}");

            // Reference type example (simple object)
            object r1 = new object();
            object r2 = r1; // copy reference (same object)
            Console.WriteLine("Reference type -> r2 points to the same object as r1: " + ReferenceEquals(r1, r2));

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion


            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // ══════════════════════════════════════════════════════════════════════

            Console.WriteLine("QUESTION 19: OBJECT BASE TYPE");
            Console.WriteLine("Answer: object (System.Object) is the base type for all types in C#.");
            Console.WriteLine("Common methods: ToString(), Equals(), GetHashCode(), GetType().");

            object obj = 5;
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj.GetType());

            Console.WriteLine("\n" + new string('-', 70) + "\n");
            #endregion
        }
    }
}
