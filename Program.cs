using System.Xml.Linq;

namespace SmarterCSharpCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = null;
            #region C# 6 new features

            //feature 1 Expression-bodied Members
            //int Add(int a, int b) => a + b;
            //Console.WriteLine(Add(2, 5));

            //feature 2
            //String Interpolation
            //string name = "John";
            //string greeting = $"Hello, {name}!";
            //Console.WriteLine(greeting);

            //feature 3
            //nameof Operator
            //string variable = nameof(variable);
            //Console.WriteLine(variable);


            //feature 4
            //Exception Filters
            //try
            //{
            //    // Code that may throw an exception
            //}
            //catch (Exception ex) when (ex.InnerException != null)
            //{
            //    // Handle the exception if InnerException is not null
            //}
            //catch (Exception ex) when (ex.Message.Contains("null reference"))
            //{
            //    // Handle the exception if ex.Message contains null reference text
            //}
            //catch (Exception ex)
            //{
            //    // Handle the exception any of previous not matched
            //}
            #endregion

            #region C # 7 new features
            //feature 1
            //Pattern Matching with is
            //object obj = "jhgjh";
            //if (obj is int intValue)
            //{
            //    Use intValue within this block
            //    Console.WriteLine(intValue);
            //}
            //else
            //{
            //    Console.WriteLine("Not string");
            //}

            // feature 2
            //Tuple Types
            //(string, int) person = ("Alice", 30);
            //Console.WriteLine($"{person.Item1} is {person.Item2} years old.");

            //feature 3
            //Local Functions
            //int Multiply(int x, int y)
            //{
            //    int MultiplyByTwo(int z) => z * 2;
            //    return MultiplyByTwo(x) + MultiplyByTwo(y);
            //}

            #endregion

            #region C # 8 new features

            //feature 1
            //Nullable reference type
            //string? nullableString = null; // Nullable reference type
            //string nonNullableString = "Hello"; // Non-nullable reference type

            //feature 2 
            //Nullable value type
            //int? nullableInt = 42;    // Assign a value
            //double? nullableDouble = null; // Assign null 
            #endregion

            #region C# 9 new features
            //Records
            //Init & With key words
            //Top level statment 
            //picture on desktop
            #endregion

            #region C# 10 new features
            //Struct Records
            //global using
            //etc
            //etc
            #endregion

            #region C# 11 new features
            // 
            //
            //etc
            //etc

            #endregion
        }
    }

    interface Interface_with_Default_Implementaion
    {
        void Welcome ()
        {
            Console.WriteLine("Welcome");
        }
        int GetId();
    }
    class TestClass : Interface_with_Default_Implementaion
    {
        public int GetId()
        {
            throw new NotImplementedException();
        }
    }
}