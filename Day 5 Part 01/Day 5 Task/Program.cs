using System;
using System.Linq;


namespace Day_5_Task
{
    internal class Program
    {
        public static void TestDefensiveCode()
        {
            int X, Y;
            //bool flag;
            do
                Console.WriteLine("Enter first number :");
            while (!int.TryParse(Console.ReadLine(), out X) || X<=0);
            do
                Console.WriteLine("Enter second number :");
            while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);

            Console.WriteLine($"X: {X}, Y: {Y}");
        }

        public static void SumAndMultiply(int a, int b, out int sum, out int product)
        {
            sum = a + b;
            product = a * b;
        }

        public static void PrintStringMultipleTimes(string text, int times = 5)
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }

        public static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }


        static void Main(string[] args)
        {
            #region Problem 1
            //try
            //{
            //    Console.Write("Enter the first integer: ");
            //    int int1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter the second integer: ");
            //    int int2 = int.Parse(Console.ReadLine());

            //    int result = int1 / int2;
            //    Console.WriteLine($"Result: {result}");
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Division by zero is not allowed.");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            ///* Question: What is the purpose of the finally block? 
            //   The finally block ensures that a piece of code will always execute,
            //   regardless of whether an exception occurred or not. It is commonly used for cleanup tasks,
            //   such as closing file streams or releasing resources.
            //*/ 
            #endregion

            #region Problem 2
            //TestDefensiveCode();

            ///* Question: How does int.TryParse() improve program robustness compared to int.Parse()?
            //   int.TryParse() improves robustness by returning a boolean indicating whether the conversion succeeded,
            //   without throwing an exception if it fails. This allows the program to handle invalid input gracefully.
            //*/ 
            #endregion

            #region Problem 3
            //int? NullableInt = null; 
            //int value = NullableInt ?? 0; 

            //Console.WriteLine($"Value after using null-coalescing operator: {value}"); 

            //if (NullableInt.HasValue) 
            //{ 
            //    Console.WriteLine($"Nullable integer has a value: {NullableInt.Value}");
            //} 
            //else
            //{ 
            //    Console.WriteLine("Nullable integer does not have a value."); 
            //}

            //NullableInt = 10; 

            //if (NullableInt.HasValue) 
            //{ 
            //    Console.WriteLine($"After assignment, Nullable integer has a value: {NullableInt.Value}"); 
            //}
            //else
            //{ 
            //    Console.WriteLine("Nullable integer does not have a value."); 
            //}

            ///* Question: What exception occurs when trying to access Value on a null Nullable<T>?
            //   System.InvalidOperationException: Nullable object must have a value.
            // */
            #endregion

            #region Problem 4
            //int[] array = new int[5];

            //try
            //{
            //    array[5] = 10;
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ///* Question: Why is it necessary to check array bounds before accessing elements? 
            //   Checking array bounds prevents runtime errors and ensures that you do not access memory
            //   outside the bounds of the array, which can lead to IndexOutOfRangeException and potential security risks.
            //*/ 
            #endregion

            #region Problem 5
            //int[,] array = new int[3, 3];

            //Console.WriteLine("Please enter 9 numbers for the 3x3 array:");

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"Enter value for array [{i},{j}]: ");
            //        array[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.Clear();

            //Console.WriteLine("Sum of elements in each row:");
            //for (int i = 0; i < 3; i++)
            //{
            //    int rowSum = 0;
            //    for (int j = 0; j < 3; j++)
            //    {
            //        rowSum += array[i, j];
            //    }
            //    Console.WriteLine($"Sum of row {i + 1}: {rowSum}");
            //}

            //Console.WriteLine("\nSum of elements in each column:");
            //for (int j = 0; j < 3; j++)
            //{
            //    int colSum = 0;
            //    for (int i = 0; i < 3; i++)
            //    {
            //        colSum += array[i, j];
            //    }
            //    Console.WriteLine($"Sum of column {j + 1}: {colSum}");
            //}

            ///* Question: How is the GetLength(dimension) method used in multi-dimensional arrays? 
            //   The GetLength(dimension) method returns the number of elements in the specified dimension of the array. 
            //   For example, array.GetLength(0) returns the number of rows, and array.GetLength(1) returns the number of columns. 
            //*/ 
            #endregion

            #region Problem 6
            //int[][] JA = new int[3][];
            //JA[0] = new int[2];
            //JA[1] = new int[3];
            //JA[2] = new int[4];
            //for (int i = 0; i < JA.Length; i++)
            //{
            //    for (int j = 0; j < JA[i].Length; j++)
            //    {
            //        Console.Write($"Enter value for row {i}, column {j}: ");
            //        JA[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < JA.Length; i++)
            //{
            //    for (int j = 0; j < JA[i].Length; j++)
            //    {
            //        Console.Write($"{JA[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            ///* Question: How does the memory allocation differ between jagged arrays and rectangular arrays?
            //   Jagged arrays are arrays of arrays, meaning each "row" can be of different lengths and stored separately in memory.
            //   Rectangular arrays have a fixed structure where each row is of the same length, and memory is allocated in a contiguous block.
            //*/ 
            #endregion

            #region Problem 7
            //string N = null!;  

            //Console.Write("Enter a value (or press Enter to leave it null): ");
            //string input = Console.ReadLine();
            //N = string.IsNullOrEmpty(input) ? null : input;

            //Console.WriteLine($"You entered: {N!}");

            ///* Question: What is the purpose of nullable reference types in C#? 
            //   Nullable reference types allow you to explicitly declare when a reference type (like a string) can be null.
            //   This helps prevent NullReferenceException by enforcing null checks and providing better compile-time warnings.
            //*/ 
            #endregion

            #region Problem 8 
            //object value1;
            //value1 = 10;
            //Console.WriteLine($"Boxed value: {value1}");

            //try
            //{
            //    int value2 = (int)value1;
            //    Console.WriteLine($"Unboxed value: {value2}");
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"Invalid cast exception: {ex.Message}");
            //}

            //try
            //{
            //    object Value3 = "string";
            //    int invalidValue = (int)Value3; 
            //}
            //catch (InvalidCastException ex)
            //{
            //    Console.WriteLine($"Invalid cast exception: {ex.Message}");
            //}

            ///* Question: What is the performance impact of boxing and unboxing in C#? 
            //   Boxing and unboxing have a performance cost because boxing involves copying
            //   the value type to the heap and creating a new object, while unboxing involves casting 
            //   the object back to the value type. This can lead to increased memory usage and slower performance. 
            //*/
            #endregion

            #region Problem 9
            //Console.Write("Enter the first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("Enter the second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int sum, product;

            //SumAndMultiply(num1, num2, out sum, out product);

            //Console.WriteLine($"Sum: {sum}");
            //Console.WriteLine($"Product: {product}");

            ///* Question: Why must out parameters be initialized inside the method?
            //   Out parameters must be initialized inside the method to ensure that 
            //   they have a valid value before the method returns. This guarantees that
            //   the caller receives a properly initialized value.
            //*/ 
            #endregion

            #region Problem 10
            //Console.Write("Enter the string to print: ");
            //string text = Console.ReadLine();

            //Console.Write("Enter the number of times to print the string (or press Enter to use the default value): ");
            //string input = Console.ReadLine();
            //int times = string.IsNullOrEmpty(input) ? 5 : Convert.ToInt32(input);

            //PrintStringMultipleTimes(text, times);

            ///* Question: Why must optional parameters always appear at the end of a method's parameter list?
            //   Optional parameters must appear at the end of the parameter list to avoid ambiguity and ensure that 
            //   all required parameters are provided before any optional ones.
            //*/ 
            #endregion

            #region Problem 11
            //int?[] nullArray = null;

            //Console.WriteLine($"Array length: {nullArray?.Length ?? 0}");

            //// Assigning values to the array to ensure it is nullable
            //nullArray = new int?[] { 1, null, 3, 4 };

            //Console.WriteLine($"Array length after assignment: {nullArray?.Length ?? 0}");

            //for (int i = 0; i < nullArray?.Length; i++)
            //{
            //    Console.WriteLine($"Element {i + 1}: {nullArray[i]?.ToString() ?? "null"}");
            //}

            ///* Question: How does the null propagation operator prevent NullReferenceException?
            //   The null propagation operator (?.) allows you to safely access members of an object that 
            //   might be null. If the object is null, it returns null instead of throwing a NullReferenceException.
            //*/
            #endregion

            #region Problem 12
            //Console.Write("Enter a day of the week: "); 
            //string day = Console.ReadLine();
            //int DayNum = day switch 
            //{
            //    "Monday" => 1, 
            //    "Tuesday" => 2,
            //    "Wednesday" => 3, 
            //    "Thursday" => 4, 
            //    "Friday" => 5, 
            //    "Saturday" => 6,
            //    "Sunday" => 7, 
            //    _ => 0 
            //};
            //Console.WriteLine($"The number for {day} is {DayNum}");

            ///*  Question: When is a switch expression preferred over a traditional if statement?
            //    A switch expression is preferred over a traditional if statement when you have multiple conditions
            //    to check against a single variable. It provides a more concise and readable way to handle multiple cases.
            //*/ 
            #endregion

            #region Problem 13 
            //Console.Write("Enter integers separated by spaces: ");
            //string input = Console.ReadLine();
            //int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            //int sum = SumArray(numbers);
            //Console.WriteLine($"The sum of the provided integers.: {sum}");

            ///* Question: What are the limitations of the params keyword in method definitions?
            //   Only one params parameter is allowed per method. The params parameter must be the last
            //   parameter in the method signature. Overuse can lead to ambiguity or unintended behavior
            //   when combined with overloaded methods.
            //*/ 
            #endregion

        }
    }
}
