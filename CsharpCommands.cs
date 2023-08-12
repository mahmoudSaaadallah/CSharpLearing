﻿// This importing of the System nameSpace to use all classes in it.
using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;

/* In C sharp we could use a static using to import any class as a static so we could use all the methods
    in this class without writing all the pass of the mehtod like when we use a System.Console class
    as  a static class so we could call the method wirteLine and write without calling the System.Console 
    by just write down the name of the method.
*/
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Object = System.Object;
using String = System.String;

namespace CSharpCommands
{
    internal class CsharpCommands
    {
        [Obsolete]
        public static void Main(string[] args)

        {
            // Consle.WriteLine is responsable for print and get output in the console Screen.
            // WriteLine: mean print, and add new line.
            Console.WriteLine("My name is Mahmoud.");

            // Console.Write print and get output in the console screen, but without adding new line.
            Console.Write("This is an output without adding new line.");
            Console.WriteLine();

            //using of writeLine method without writting the full path of method.
            WriteLine("This is the using of writeLine method without wirtting the name of class " +
                 "Console, by using this class as a static using.");

            Object firstObject;
            //Zero bytes have been allocated in heap.
            firstObject = new Object();
            // new (IL newObj)
            // I. Allocate Required # of Bytes in Heap
            // (Object Size + CLR Overhead Variables).
            // 2. Initialize(cross out ) allocted Bytes.
            // 3.Ca11 userdefined Ctor if exists.
            // 4.Assign Refrence to newely allocated Object.


            // This is an example of creation a reference type in C# by using new key word.
            Object secandObject = new Object();
            // GetHashCode: is a method in Object class whic get a unique key for each (Reference type).
            Console.WriteLine(secandObject.GetHashCode());

            // we could also create a new reference without using new + name of classReference.
            Object thirdObject = new();// creatting new reference using just new keyword. It's called Syntax suger.
            Console.WriteLine(thirdObject.GetHashCode());

            // when using equal sign with two references the both of them will refer to the same object in memory
            // so any change in one of them will change the other.
            // to make sure about this point we could print the hasCode for both of them which will be equal.
            secandObject = thirdObject;
            Console.WriteLine("After using = sign with two references: ");
            Console.WriteLine(secandObject.GetHashCode());
            Console.WriteLine(thirdObject.GetHashCode());
            Console.WriteLine("Both of hash code is the same.");

            // initialisation for some primative data type.
            int firstIntNUmber = 1123448321;
            // C# allow us to use uder score in the number to make it more readable.
            // _: Discards.
            int secandIntNUmber = 1_123_448_321;
            Console.WriteLine(secandIntNUmber);

            // To use assign any decimal number to float we need to use letrial castting using f letter.
            float firstFolatNUmber = 1532.33f;

            // There is also another data type in c sharp using for decimal numbers called decimal
            // it also need letrial casting, but here we using m letter.
            // we have to know that the decimal data type is bigger than duble data type in number after decimal point.
            decimal fristDecimalNumber = 35455.6232m;


            //----------------------------------------------------------------------------//
            // Reading data from user
            /* 
             * to read data from user we could use method ReadLine in class Console.
             * we have to know that this method accept data from user as string data not a numeric or character
                data.
             * To accept data as numeric data we need do cast it.
            */
            String firstString = Console.ReadLine();
            Console.WriteLine(firstString);

            // to accept data as an integer data we use the function int.Parse which accept String and cast it 
            // to integer.
            int firstAcceptedIntNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("firstAcceptedIntNumber: " + firstAcceptedIntNumber);
            // we have to know that int.Parse convert String to integer data type, so it's not used with to 
            // convert to ather data type.

            // there is another way to convert any data type to any other data type using Convet class.
            // Convert.ToInt32
            //Convert.ToInt16
            //Convert.ToByte
            //Convert.ToDouble
            //Convert.ToInt64
            //Convert.ToBoolean
            //... 

            int secandAcceptedIntNumber = Convert.ToInt32(Console.ReadLine());
            double firstAcceptedDoubleNumber = Convert.ToDouble(Console.ReadLine());
            Byte fristAcceptedByteNumber = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("secandAcceptedIntNumbet: " + secandAcceptedIntNumber);

            //-----------------------------------------------------------------------------//

            // String Formate
            // In c# ther are lot of string formate:

            // 1. String Concatenation:
            // String concatenation is a basic method of combining strings. You can use the + operator to concatenate two or more strings.
            String concatString1 = "Mahmoud";
            String concatSrting2 = "Saadallah";
            String fullConcate = concatString1 + " " + concatSrting2;


            // 2. String.Format with Format Specifiers:
            /*
             * String.Format allows you to apply format specifiers to control the appearance of numeric 
             * and date values in the formatted string. Format specifiers follow a specific pattern, and 
             * they are inside the curly braces along with the index of the argument to format.
            */
            decimal price = 19.99m;
            string formattedPrice = string.Format("Price: {0:C}", price);// $19.99
            //In this example, {0:C} applies a currency format to the price variable, resulting in the output "Price: $19.99".


            // 3. Composite Formatting:
            /*
             * Composite formatting uses placeholders {0}, {1}, etc., within a string and then replaces them with 
             * corresponding values using the string.Format() method. This method is useful when you want to create
             * a string dynamically from multiple variables.
             */
            string name = "Alice";
            int score = 85;
            string message = string.Format("Player: {0}, Score: {1}", name, score);
            //In this example, {0} is replaced with the value of the name variable, and {1} is replaced with the value of the score variable


            // 4. String Interpolation:
            /*
             * String interpolation is a feature introduced in C# 6.0 that allows you to directly embed expressions or variables within a string.
             * It simplifies string formatting and makes the code more readable
             */
            string name2 = "John";
            int age = 30;
            string message2 = $"Hello, my name is {name} and I'm {age} years old.";
            //Here, the variables name and age are embedded directly into the string using {} curly braces with a $ prefix.
            //During runtime, the expressions inside the curly braces are evaluated and replaced with their respective values.


            // 5. Verbatim String Literal:
            /*
             * A verbatim string literal is prefixed with @, which allows you to include line breaks and escape characters
             * directly without using additional escape characters.
             */
            string path = @"C:\Users\John\Documents";
            //In this example, the verbatim string @"C:\Users\John\Documents" will preserve the backslashes as they are
            //    and not treat them as escape characters.



            // if we want to save a string in a spacific formate or to print string in a spacific formate
            //      we could use formate method in String class.
            // to use this method to print 9 + 5 = 14 we put the varable between two {} brackets
            // Between brackets we have to specifiy number of variable in the formate starts with 0
            // as in out example firstNUmber variable is the first varable in between barckets so we 
            // put zero between first two brackets and so on with SecandNUmber variable and sum.
            int firstNumber = 9, secandNumber = 5;
            String firstFormatedString = String.Format("firstFormatedString: {0} + {1} = {2}",
                                                        firstNumber, secandNumber, firstNumber + secandNumber);
            Console.WriteLine(firstFormatedString);

            // Also WriteLine method accept the same formate directly.
            Console.WriteLine("firstFormatedString: {0} + {1} = {2}",
                                firstNumber, secandNumber, firstNumber + secandNumber);

            // Also we could use doller sign before formate to use the name of variable instead of using 
            // number of variable 
            String secandFormatedString = $"secandFromatedString: " +
                                          $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber}";
            Console.WriteLine(secandFormatedString);

            // This way also used in writeLine directly
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber}");

            // We could use multiple formate for number like using letters after number to print it specific formate.
            // X: to get the number in hexadecimal.
            // C: to get the number in the formate of currence.
            // N: to get the number with embedded commas.
            // G: to get the number either fixed point or integer, depending on which format is the most compact
            // F: to get the number as fixed point value.
            // E: to get the number by using exponential noation.
            // D: to get the number as decimal integer.
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber:X}"); // E
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber:C}"); // $14.00
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber:N}"); // 14.00
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber:G}"); // 14
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber:F}"); // 14.00
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber:E}"); // 1.400000E+001
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber} + {secandNumber} = {firstNumber + secandNumber:D}"); // 14

            // we could also specify number of digits to print variable in.
            // in the next example we will diplay the firstNumber variable in three digits aline right
            // , and also display the secandNumber vartiable in four digits aline left.
            // as we use posstive number it's aline right, but if we use negive number it will aline left.
            Console.WriteLine($"secandFromatedString: " +
                              $" {firstNumber,3} + {secandNumber,-4} = {firstNumber + secandNumber}");

            //-------------------------------------------------------------------------------------//
            //Switch in C#
            // The most important thing we have to know in C# is the break in switch cases in mandatory
            // so we have to put break after each case.
            // we also have to know that big o for switch is 1 when we deal with numeric values.
            int firstnumberToTestInSwitch = 3;
            switch (firstnumberToTestInSwitch)
            {
                case 1:
                    Console.WriteLine("Jan");
                    break; // break is mandatory not an optianal.
                case 2:
                    Console.WriteLine("Feb");
                    break;
                case 3:
                    Console.WriteLine("Mar");
                    break;
                default:
                    Console.WriteLine("Others");
                    break;// break is nandatory even with default.
            }

            // When we dealing with String values and we have few number of cases then the engin  
            //    deal with it as if and if else.
            // And also we could use mulitple choose in case with the same body.
            String stringToTestSwitch = Console.ReadLine();
            switch (stringToTestSwitch)
            {
                case "A":
                case "a":
                    Console.WriteLine("First letter");
                    break;
                case "B":
                case "b":
                    Console.WriteLine("Secand letter");
                    break;
                case "C":
                case "c":
                    Console.WriteLine("Third letter");
                    break;
            }

            // If the number of cases is bigger than 7 with String values then the engin work with 
            //   hash as it create hash to each value to make it more faster to jump to the correct value
            // This way take time (big O) almost equal to 1.


            // As the break is mandatory, so we can't use full into or full throw.
            // example 
            int secandNumberToTestSwitch = 3000;
            switch (secandNumberToTestSwitch)
            {
                case 3000:
                    Console.WriteLine("Option 3");
                    Console.WriteLine("Option 2");
                    Console.WriteLine("Option 1");
                    break;
                case 200:
                    Console.WriteLine("Option 2");
                    Console.WriteLine("Option 1");
                    break;
                case 1000:
                    Console.WriteLine("Option 1");
                    break;
            }
            // in this example as the break is mandatory we have to repeat parts of code in each case
            //    but we could avoid this using "goto" method which used to go from case to anther case
            //     to avoid repeating.
            switch (secandNumberToTestSwitch)
            {
                case 3000:
                    Console.WriteLine("Option 3");
                    goto case 200;
                case 200:
                    Console.WriteLine("Option 2");
                    goto case 1000;
                case 1000:
                    Console.WriteLine("Option 1");
                    break;
            }
            // using goto method we didn't repeat any part of code and we have to delete break with goto
            //   so we did't lose full into or full throw.

            //-------------------------------------------------------------------------------------------//
            // Scopes
            // Block Statement: is a two brackes with no name or with name in any place inside method or class.
            // Any variable declared inside block statment we can't use it outside it.
            // Also we can't declare any variable with the same name that has been used outside the scope.
            // Any variable declared outside the block statement we can use it inside the block scope.
            {
                int numberInBlockStatement = 110;
                Console.WriteLine("numberInBlockStatement: " + numberInBlockStatement);
                Console.WriteLine(secandNumberToTestSwitch);

            }// End of block Statement.

            //-------------------------------------------------------------------------------------------//
            // Array 
            // Array in C# is reference type.
            // Array could be declared and inialization in the same command.
            int[] firstArray = new int[5] { 12, 55, 65, 42, 7 };
            // this way is used to declare and inialize array at the same time.
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{firstArray[i]}, ");
            }// 12, 55, 65, 42, 7,
            Console.WriteLine();

            // We could use Array.length to get the length of array, and use Array.Rank to get the dimension.
            Console.WriteLine("Length: " + firstArray.Length + "\t Dimension: " + firstArray.Rank);

            // We could declare and inialize array in differnt way 
            int[] secandArray = { 5, 44, 4 };

            // We could use some functions in Array class like:
            // Sort: used to sort array.
            Array.Sort(firstArray);
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{firstArray[i]}, ");
            }// 7, 12, 42, 55, 65,

            // If i want to has a new copy of an exist array, as we know we can't use equal sign = as Array 
            //    is a reference type so when we using = sign this mean both of them(the exist array, and th
            //    new one) will refere to the same array by two different name.
            // But if i want a new array with the values i could use "Clone" method.
            // using Clone method we have to use cast with it or it will return a compile error.
            secandArray = (int[])firstArray.Clone();
            // This method will make a new copy from firstArray and asigned it to secandArray.
            // this mean both of array don't affect each other.

            //--------------------------------------------------------------------------------------------//
            // Two dimension Array
            int[,] firstTwoDimensionArray = new int[3, 5];// Declareion of two dimention array.
            // To fill this array we use nested loop, but we have to know that when using this loop to get 
            //    the length of array, if we use Array.length this will return the number of cell in this array
            //    which will be 15 in our example, so to get the length of this array(number of columns) we use 
            //    Array.GetLength(0) which accept number of the first dimation which is number of columns here
            //    and also to get the number of Rows we use the same method, but we pass 1 to it which is the secand
            //    dimention which is the number of Rows.
            for (int i = 0; i < firstTwoDimensionArray.GetLength(0); i++)
                for (int j = 0; j < firstTwoDimensionArray.GetLength(1); j++)
                {
                    firstTwoDimensionArray[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            //----------------------------------------------------------------------------------------------// 
            // Casting
            // Implicit Casting: like casting from int to longe or casting for any intger data type to double
            // As long is 64 byte and int is 32 byte then we could fit any data in 32 to 64. This type of casting
            //    called Implicit casting or safe casting  which mean that the compiler know that there is
            //    no runtime errors.
            // The mean of Implicit is we could write it without adding cast in the statement and the compiler to id automaticlly.
            int firstNumberToTestCasting = 46611;
            long secandNumberToTestCasting = 3454544;
            secandNumberToTestCasting = firstNumberToTestCasting;//Safe casting, Implicit casting
            // we could also do it as explicit casting by write casting in the same statement 
            secandNumberToTestCasting = (long)firstNumberToTestCasting;// explicit casting, but it's not nessesary.


            // Explicit casting: like casting form long to int or form double to any integer data tye.
            // As long is 64 byte and int is 32 byte then we couldn't fit any data in 64 to 32. This type of casting
            //    called Explicit casting or Unsafe casting  which mean that the compiler know there might be an error.
            // The Explicit casting must be write in the statemenet to tell the complier that you are the responsable
            //   for casting and lossing data.
            firstNumberToTestCasting = (int)secandNumberToTestCasting;

            // If the data in the long is bigger than the what the int could accept, in this case there will be lossing 
            //    date this case is called overflow.
            // Due to overflow there is no exeption will be happen, but the result will not be the correct one.
            secandNumberToTestCasting = long.MaxValue;
            firstNumberToTestCasting = (int)secandNumberToTestCasting;
            Console.WriteLine(firstNumberToTestCasting); // -1

            // To make the CLR(common language runtime) return overFlowExeption, then we have to use check block.
            checked
            {
                firstNumberToTestCasting = (int)secandNumberToTestCasting;
            }
            // when using checked block this block will throw an execption as an overflow execption.

            // By the way there is another block called unchecked block which used inside checked block 
            //     to uncheck part of code inside checked block.
            // You hav e ti know that checked block is used to check for overflow exception only, and doesnot used with other exception
            //---------------------------------------------------------------------------------------//
            // Boxing & UnBoxing
            // specificly used with System.Object and any value type.
            // Casting reference 
            /* 
             * We know that class Object is parent for all classes in C#, and also parent for for any data type.
             * So if we need to refere to primative data by a reference type(Object) this will happen like:
             */
            firstNumberToTestCasting = 50;// priamtive data type.
            Object firstObjectoTestCasting = new object();// reference type.
            firstObjectoTestCasting = firstNumberToTestCasting;// valid
            // this is implicit casting, Safe casting 
            // This process called boxing.
            /*
             * This kind of casing happen by: 
             * as we know that the firstObjectToTestCasting is a reference type this mean it stores in heap 
             * and firstNumberToTestCasting is primative type so it's stores in stac
             * The question now is how something in heap refere to data in stack? Actually what happen is 
             * the engine take a copy of data in stack and put it in heap and make this object refere to it.
             */

            // the opesite process is not valid with implicit cast, but it's valid if we use explicit case
            //   if the object carry a primative data.
            // This process called unboxing.
            firstNumberToTestCasting = (int)firstObjectoTestCasting;// unsafe Casting.

            //--------------------------------------------------------------------------------------------//
            //Nullable
            /*
             * When we dealing with value type like int or duble... and we get out values form user or from
             *    column in data base, and this column allow null vlues.
             * This mean if we get our value from data base and its a null value this value cann't be stored 
             *    in value type in C sharp as null value is reference default.
             * like if we say that:
             *                      int x = null;
             * This will get an error.
             * To handel this statement we could use nullable to make value type accept null value
             */
            int? intTestNullable;
            // this is way of declaration of nullable values. now if we get null value to intTestNUllable variable
            // it will be accepted.
            intTestNullable = null;  // valid value.
            // this declaration work with all primative data type.
            bool? booleanTestNull = null;
            long? longTestNullable = null;
            double? doubleTestNullable = null;
            byte? byteTestNullable = null;
            char? charTestNullable = null;
            short? shortTestNullable = null;

            // There is unsafe casting with nullable when we cast ordinary data type to nullable value type.
            // so in this case we have to use explicit casting
            firstNumberToTestCasting = (int)intTestNullable; // unsafe cast.
            Console.WriteLine($"firstNumberToTestCasting =  {firstNumberToTestCasting}"); // throw exception.

            // As a good practies in programming we have to know how to handel this situation to not throw an 
            //    execption.
            // Protected programming
            if (intTestNullable != null)
            {
                firstNumberToTestCasting = (int)intTestNullable;
            }
            else
                firstNumberToTestCasting = 0;
            // this the way for handling.
            Console.WriteLine($"firstNumberToTestCasting =  {firstNumberToTestCasting}");// throw no exception.

            // Another way to make it Protected Programming using some nallable functions
            if (intTestNullable.HasValue)
            {
                firstNumberToTestCasting = intTestNullable.Value;
            }
            else
                firstNumberToTestCasting = 0;
            // this the way for handling.

            // Another way to make it Protected Programming using ternary Operator.
            firstNumberToTestCasting = intTestNullable.HasValue ? intTestNullable.Value : 0;
            // Or we could use an exeprission specificly with nullable
            firstNumberToTestCasting = intTestNullable ?? 0; // this do the same as ternary operator
                                                             // this style could be used with any data type allow null like references data type.

            //-----------------------------------------------------------------------------------------//
            // To get the default value for any data type(primative, or reference) we use default keyword
            int defaultIntValue = default;// primative data type.
            int[] defaultReferanceValue = default;// reference data type.
                                                  // now if we use a loop to get values from this array which has null as default this will make an 
                                                  //   execption called NullReferenceException
            for (int i = 0; i < defaultReferanceValue.Length; i++)
            {
                Console.WriteLine($"defaultReferenceValue[{i}] = {defaultReferanceValue[i]}");
            }// This will throw a NullReferenceException.

            // To handel this execption we use 
            for (int i = 0; defaultReferanceValue != null && i < defaultReferanceValue.Length; i++)
            {
                Console.WriteLine($"defaultReferenceValue[{i}] = {defaultReferanceValue[i]}");
            }// no execption will apeare.

            // Or we could use Null Propagation Operator, by using question mark in before usig .length method.
            for (int i = 0; i < defaultReferanceValue?.Length; i++)
            {
                Console.WriteLine($"defaultReferenceValue[{i}] = {defaultReferanceValue[i]}");
            }// no execption will apeare.

            ///////
            Test2 firstTest2 = default; // null
            Console.WriteLine(firstTest2.test.testString);
            // This command will trow an execptionas, as firsTest object is null;
            // to handel this we could use Propagation Operator.
            Console.WriteLine(firstTest2?.test?.testString ?? "not valid");// not valid.
            // this way will help us to decrease using if else.

            int length1 = defaultReferanceValue.Length;// Unsafe.
            int? length2 = defaultReferanceValue?.Length;// Safe.
            int length3 = defaultReferanceValue?.Length ?? 0;// Safe.


            //-----------------------------------------------------------------------------------//
            // Implicit Type Local Variable.
            /*
             * As we know when we declare a variable of primative type(value type), then we can't change its 
             *     type. Like when we create a double vaiable and we want to sign string value to it, it will 
             *     give an error as string value can't be casted to double value.
             */
            // IN this situation C# has an Implicit type that change depend on the vlaue asign to it.

            /*
             * Before discassing implicite type we have to know that this type is local vairable type, so 
             *      we can't use it as a pramater for a method or we can't use it as a fild for class(class attribute)
             *      also can't be a return type from a method.
             */
            // To use Implicit Type we use keyword "var"
            var doubleImplicit = 3.6;
            var intImplicit = 20;
            var stringImplicit = "Mahmoud";
            var charImplicit = 'M';
            var byteImplicit = 10;
            var booleanImplicit = true;
            // Complier will detect data type based on inital value. It mast be local variable.
            // Can't be declarted without initialized at the same time; 
            //var errorImplicit; // error 
            // Can't be initialized with null. 
            //var nullImplicit = null; // error

            // You have to know if we try to chang value of Implicit type with anothe data type it will give an error
            //doubleImplicit = "Mahmoud";// error as doubleImplicit was initialized with double value, so we can't chang its data type.

            // To get data type of Implicit type after initilize it we use method GetType().Name
            Console.WriteLine(doubleImplicit.GetType().Name);
            Console.WriteLine(intImplicit.GetType().Name);
            Console.WriteLine(stringImplicit.GetType().Name);
            Console.WriteLine(booleanImplicit.GetType().Name);

            //-----------------------------------------------------------------------------------------------//
            // Stack Tracer
            // In C sharp we could trace the calling of method in stack "StackTrace" class.
            // The benfit of using this class is to trace the excution and calling method to know the place that has an 
            //    exception when it happen.

            StackTrace trace = new StackTrace();
            // StactTrace consist of array of frame called "StackFrame" each frame is used by method in runtime.
            StackFrame[] frames = trace.GetFrames();
            for (int i = 0; i < frames.Length; i++)
            {
                Console.WriteLine(frames[i].GetMethod().Name);
            }// return name of each method called in this programe

            //----------------------------------------------------------------------------------------------//
            //Input Parameter To a Method.
            //Default Input Parameter.
            //Named Input Parameter.
            // As we see here there is a method called printLine which accept two parameter.
            /*
             * In this method printLine which accept two parameters we put a default values for paramters that be accepted 
             *    this mean we could call this method without passing any data to it at this time the complier will use default values
             *    but if we pass any data then the passed data will be used.
             * Also we could pass data in different order, but in this time we have to write the name of parameter then : then value.
             * Also we could pass just one of parameters not all parameters, at this time the passed data will be used and 
             *    compiler will use default value for unpassed parameter.
            */
            printLine(20, " Mahmod ");// passing two parameters.
            printLine();// passing no parameter so the compiler will use default values for parameter.
            printLine(20);// passing one parameter and compiler will use default for secand parameter.
            printLine(output: " Saadallah ");// our method accept int first so when we change order of passing parameter 
                                             //we have to wrirte the name of parameter.
            printLine(output: " & ", n: 40);
            // The Named Input Parameter is very useful when we have a method that accept lot of parameters and we don't know
            //    the order of these parameters so we could use named input parameter.

            //---------------------------------------------------------------------------------------------------------//
            // Pass By Reference:
            // C# is pass by reference or value language not like java which is pass by value only.
            // In swapByValue method we pass by value here so when we pass any data to this method, we just pass copy of 
           //    this data not the original data.

            /*
              * static void swapByValue(int x, int y)
                    {
                        int temp = x;
                        x = y;
                        y = temp;
                    }
             */

            int firstNumberToSwap = 10, secondNumberToSwap = 20;
            swapByValue(firstNumberToSwap, secondNumberToSwap);
            Console.WriteLine($"firstNumberToSwap: {firstNumberToSwap},  secondNumberToSwap: {secondNumberToSwap}");
            //firstNumberToSwap: 10,  secondNumberToSwap: 20
            // the original values for variable didn't change as the passign was by value. 

            // we could modify the function to make passing by reference like in swapByReference function.

            /*
             *  static void swapByReferenc(ref int x, ref int y)
                {
                    int temp = x;
                    x = y;
                    y = temp;

                }
             */

            // By using keyword "ref" before data type in parameter of method and use "ref" key word before passed variable
            //   this will make function pass by reference.
            swapByReferenc(ref firstNumberToSwap, ref secondNumberToSwap);
            Console.WriteLine($"firstNumberToSwap: {firstNumberToSwap},  secondNumberToSwap: {secondNumberToSwap}");
            //firstNumberToSwap: 20,  secondNumberToSwap: 10
            // the original values of variable changed as the passing was by reference so we didn't pass a copy of data 
            //   we pass the original data.


            // This work with value type. what about reference type like String or array or any other reference type?

            //------------------------------------------------------------------------------------------------------//

            //passing reference by value:
            // As we know reference type stores in heap and when we pass a reference type this mean we don't creat 
            //     new object, but we just refere to the exisist object by a new name.
            // Conseder that we have a method that sum vlaues inside intger array which accept int array.
            int[] arrayToBeSum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Console.WriteLine(sumArray(arrayToBeSum));// 91
            /*
              * static int sumArray(int[] array)
               {

                    //array = new int[10];
                    Console.WriteLine(array.GetHashCode);
                    //array = new int[10];
                    int sum = 0;
                    for (int i = 0; i < array?.Length; i++)
                    {
                        sum += array[i];
                    }
                    array = new int[10];
                    return sum;
                }// End of sumArray method
             */
            // To check that if the engin create a new object(reference) from array that be passed let's 
            //     print hash for this array, and print hash for the accepted array in the method.
            Console.WriteLine(arrayToBeSum.GetHashCode);
            // We will get the same result form this statement and one in the method as they are the same object with different name.

            // passing value by reference is the same as passing reference by value.

            //------------------------------------------------------------------------------------------------------//

            // passing reference by reference:
            // There is a big differece between passing reference by value and passing reference by refererce.
            /*
             * When you pass a reference type by reference, you use the ref keyword in both the method signature 
             *      and the method call. This means that the method receives a reference to the original reference itself.
             * Any changes happen to the reference inside the method will modify the original reference outside the method.
             */
            ModifyPersonNameByReference(ref arrayToBeSum);
            /// summay
            /*
             * In summary, passing a reference type by value allows you to modify the properties or fields of 
             *     the original object, but passing by reference allows you to modify the reference itself, 
             *     which can lead to changes in the object the reference points to. Be cautious when using 
             *     ref parameters, as modifying the reference itself might lead to unexpected behavior and 
             *     make your code harder to understand and maintain. It is generally recommended to pass
             *     reference types by value whenever possible, unless you have specific requirements for 
             *     modifying the reference itself.
             */
            /*
                static void ModifyPersonNameByReference(ref int[] array)
                {
                    array = new int[10];
                 }//End of ModifyPersonNameByReference
             */

            // To see the differece between passing, let's run print arryToBeSum after we passing it to both of
            //   the methods to see the changs
            sumArray(arrayToBeSum);
            for (int i = 0; i < arrayToBeSum.Length; i++)
            {
                Console.Write($"{arrayToBeSum[i]}, ");
            }// 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,
            Console.WriteLine();
            ModifyPersonNameByReference(ref arrayToBeSum);
            for (int i = 0; i < arrayToBeSum.Length; i++)
            {
                Console.Write($"{arrayToBeSum[i]}, ");
            }// 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,

            /// why this happen?
            /// To summary what happen let's take a look inside both methods. we will find that we modify 
            ///    array in both of them "array = new int[10];", but the changes in both of the methods 
            ///    depend on the way of passing, as in the method that accept reference by value:
            ///    We say before that passing reference by value doesn't creat new object, but it creat a new 
            ///    reference(name) refere to the same object in the heap so when we modify this new reference
            ///    "array = new int[10];" this mean we make this reference refere to another new object not our 
            ///    object, so our original object doesn't change.
            ///    
            /// But in the method that accept reference by reference:
            ///     We say before that passing reference by reference make the new reference refere to the original
            ///     reference not to the object of original reference, and there is a big differnce between refereing 
            ///     to the object of the original reference and refereing to the original reference it self.
            ///     So when we modify the reference in the method "array = new int[10];" this change the original 
            ///     reference and make it refere to a new object not the original object which has no thing to refere
            ///     to it now so the garbege collector will delate it.


            // passing value by value : read only.
            // passing value or reference by reference : read and write.
            //-------------------------------------------------------------------------------------------------//
            ///Passing by out:
            ///passing value by value : read only, and passing value or reference by reference : read and write.
            /// let's consider the following Scenario if we want to return two values form method this will never
            ///        happen as any non void mehtod could return just one value, 
            ///        but what if i want to return two values?
            /// In this Scenario we could use passing by out:
            /// passing by out is the same as passing by ref, but the difernaces are:
            /// 
            /// When using ref, the variable passed to the method must be initialized before the method call. 
            /// With out, the variable does not need to be initialized beforehand.
            /// In ref, the method can read and modify the value of the parameter, while out is generally used when the
            ///    method needs to return multiple values.
            /// ref requires the variable to have an initial value, but out does not, as it will be assigned a value 
            ///     within the method.
            /// Choose ref when you want to pass a variable and read / modify its value within the method.
            /// Choose out when you want to return multiple values from a method.

            /*
             * 
               static void sumAndMultiply (int n1,  int n2, out int sum, out int mulitply)
               {
                    //Note: When using out, you must assign a value to all out parameters within the method before it returns.
                        sum = n1 + n2;
                        mulitply = n1 * n2;
                }
             *
             */// we have this function which accept four parameters two of them are passing by out           

            int firstNUmberOut = 20, seccondNumberOut = 4, sumWithOut, mulitplyWithOut;
            sumAndMultiply(firstNUmberOut, seccondNumberOut, out sumWithOut, out mulitplyWithOut);
            Console.WriteLine(sumWithOut);//24
            Console.WriteLine(mulitplyWithOut); //80
                                                // we pass two uninialized parameters and we get two return values to these parameters as passing by out is write only.
                                                // if we try to pass these uninialized parameters by ref it will give an error as it read and write.

            /// we could also not declare the varible before calling and declare them when we call mehtod like:
            int numberOUt = 20, numberOut2 = 4;
            sumAndMultiply(numberOUt, numberOut2, out int sumresult, out int mulitplyresult);
            Console.WriteLine(sumresult);//24
            Console.WriteLine(mulitplyresult);// 80

            /// Also we could pass only one out variable not both of them, In this case we need to use 
            ///    underscore instead of un passed variable.
            sumAndMultiply(firstNUmberOut, seccondNumberOut, out _, out mulitplyWithOut);
            Console.WriteLine(mulitplyWithOut);// 80
            /// in this case we didn't need to get the summtion, but we need the multiplcation so we didn't 
            ///   pass a variable to sum, but we pass "mulitplyWithOut" variable to get multiply.


            //--------------------------------------------------------------------------------------------------------------//
            /// String In Details

            /// You can instantiate a String object in the following ways
            /// 
            /// By assigning a string literal to a String variable.
            /// This is the most commonly used method for creating a string.The following example
            ///    uses assignment to create several strings.Note that in C# and F#, because the backslash (\)
            ///    is an escape character, literal backslashes in a string must be escaped or the entire
            ///    string must be @-quoted.
            ///    
            string string1 = "This is a string created by assignment.";
            Console.WriteLine(string1);// This is a string created by assignment.
            string string2a = "The path is C:\\PublicDocuments\\Report1.doc";
            Console.WriteLine(string2a);// The path is C:\PublicDocuments\Report1.doc
            // Here we use double backslash to diplay one backslash as backslash is a scape character.
            string string2b = @"The path is C:\PublicDocuments\Report1.doc";
            Console.WriteLine(string2b);// The path is C:\PublicDocuments\Report1.doc
                                        // Here we use @ to diplay string as it is without any changes and use scape character as any other character.

            ///By calling string constructor
            ///
            char[] chars = { 'w', 'o', 'r', 'd' };
            byte[] bytes = { 0x41, 0x42, 0x43, 0x44, 0x45, 0x00 };

            string stringFromChar = new string(chars);
            Console.WriteLine(stringFromChar);
            //string stringFromChar = chars;// this will return an error as we can't assign char array to string without constructor.
            //string stringFromByte = new string(bytes);// this will return an error as its byte not char

            /// using pointer we could sign byte array to string

            /// Creating Strings from Pointers:
            /// To create strings from pointers to the arrays, we need to use the unsafe keyword to indicate 
            ///    that the code contains unsafe operations. This allows us to use pointers.
            ///    
            /// Pinning the Arrays with fixed: 
            /// Inside the unsafe block, we use the fixed statement to pin the arrays chars and 
            ///    bytes in memory.This ensures that their memory locations remain fixed and will 
            ///    not be moved by the garbage collector during the execution of unsafe code.
            ///    
            /// Creating Strings from Pointers to Pinned Arrays:
            /// After pinning the arrays, we can now create strings from pointers to the pinned memory. 
            /// The new string(pointer) constructor is used for this purpose.
            /// 
            /// String Creation from Pointers Explanation:
            /// For stringFromBytes: The pointer pbytes points to the pinned memory of the bytes array.
            /// The new string(pbytes) constructor creates a string from the bytes starting at the memory 
            ///   address pbytes until it encounters a null terminator(byte value 0x00).
            /// In this case, the bytes at addresses 0x41, 0x42, 0x43, 0x44, and 0x45 correspond to the
            ///    ASCII codes for the characters 'A', 'B', 'C', 'D', and 'E', respectively.
            /// The resulting string will be "ABCDE".
            string stringFromBytes = null;
            unsafe
            {
                fixed (byte* pbytes = bytes)
                {
                    // Create a string from a pointer to a signed byte array.
                    stringFromBytes = new string((sbyte*)pbytes);
                }
            }
            Console.WriteLine(stringFromBytes);


            /// We could create string of repeated character by 
            String repeatedChar = new string('m', 20);
            Console.WriteLine(repeatedChar);//mmmmmmmmmmmmmmmmmmmm
                                            // this could be used with repeated single character.

            /// By using the string concatenation operator:
            /// to create a single string from any combination of String instances and string literals. 
            /// The following example illustrates the use of the string concatenation operator.
            /// 
            string concateString1 = "today is " + DateTime.Now.ToString() + ".";
            Console.WriteLine(concateString1);// today is 8/3/2023 3:53:06 PM.
            // we use '+' concatenation operator to create string.


            /// Methods
            /// 

            /// 1.Clone()
            /// Returns a reference to this instance of String.
            /// It's used To create a shallow copy of an object. This mean it just a reference to the exists object
            /// 
            /// In C#, when you use the Clone() method on a String object, it returns a reference to 
            /// the existing string instance. This means that no new object is created in the heap memory. 
            /// If you want to create a separate String object with the same value as the original instance, 
            /// you can use the Copy or CopyTo method. 
            /// 
            /// Here in the next example we create an object and create a clone from it this mean new reference
            ///    refer to the same object of the orignalString reference, but when we edeid cloneString
            ///    we create a new object with new data.
            String orignalString = "Original String.";
            Console.WriteLine(orignalString);//Original String.
            String cloneString = (string)orignalString.Clone(); 
            Console.WriteLine(cloneString.GetHashCode());//126706928
            Console.WriteLine(orignalString.GetHashCode());//126706928
            Console.WriteLine(cloneString);//Original String.
            cloneString = "original String edied.";
            Console.WriteLine(orignalString);//Original String.
            Console.WriteLine(cloneString);//original String edied.
          
            

            //----------------------------------/
            /// 2.Compare()
            /// 
            /// There are different ways to use compare() method 
            /// 

            /// 1. Ordinal Comparison:
            /// "Compare(string1, string2)" used to compare between two strings.
            /// if two strings are equal it returns "0".
            /// if the first string is greater than the second one it returns possitive integer number >= 1 .
            /// if the secon string is greater than the first one it returns negative ingeger number <= -1 .
            /// 
            /// 
            String string2 = "apple";
            string string3 = "banana";
            Console.WriteLine(String.Compare(string3, string2)); // -1
            Console.WriteLine(String.Compare(string2, string3)); // -1 
            string string4 = "apple";
            Console.WriteLine(String.Compare(string4, string2)); // 0 

            /// 2.Compare(String, String, Boolean):
            /// Compares two specified String objects, ignoring or honoring their case, and returns an 
            ///   integer that indicates their relative position in the sort order.
            ///   
            string string5 = "APPLE";
            Console.WriteLine(String.Compare(string2, string5, true));// 0
            Console.WriteLine(String.Compare(string2, string5, false));// -1

            /// 3.Ordinal Ignore Case Comparison:
            /// 
            /// This compares two strings while ignoring the case of the characters.
            /// 

            Console.WriteLine(String.Compare(string2, string5, StringComparison.OrdinalIgnoreCase));// 0
            /// here both of string have the same value with differnt in case of letter, while we using
            ///   "StringComparison.OrdinalIgnoreCase" to Ignore the case of letters.
            ///   


            /// 4.Compare(strA, indexA, strB, indexB, length):
            /// The Compare method with the signature Compare(String strA, Int32 indexA, String strB, Int32 indexB, Int32 length)
            ///     is a static member of the System.String class in C#. This overload of the Compare method allows
            ///     you to compare substrings within two strings based on their indices and length.
            /// 
            /// Parameters
            /// strA: The first input string.
            /// indexA: The starting index within strA from which to compare the substring.
            /// strB: The second input string.
            /// indexB: The starting index within strB from which to compare the substring.
            /// length: The number of characters to compare in both substrings.
            /// 
            /// Return Value:
            /// An integer value that indicates the lexical relationship between the specified substrings:
            /// A negative value: The substring in strA is less than the substring in strB.
            /// Zero: The specified substrings are equal.
            /// A positive value: The substring in strA is greater than the substring in strB.
            /// 
            string strA = "Mahmoud saadallah ibrahim";
            string strB = "Mohamed Awadallah ibrahim";
            Console.WriteLine(String.Compare(strA, 16, strB, 16, 7));// 0

            strA = "hello world i'am here";
            strB = "i'am here";
            Console.WriteLine(String.Compare(strA, 12, strB, 0, 9));// 0
            Console.WriteLine(String.Compare(strA, 7, strB, 3, 5));// 1


            /// 5.Compare(String, Int32, String, Int32, Int32, Boolean):
            /// Compares substrings of two specified String objects, ignoring or honoring their case, 
            /// and returns an integer that indicates their relative position in the sort order.
            /// 
            /// Parameters
            /// strA: The first input string.
            /// indexA: The starting index within strA from which to compare the substring.
            /// strB: The second input string.
            /// indexB: The starting index within strB from which to compare the substring.
            /// length: The number of characters to compare in both substrings.
            /// boolean: is boolean value (true, false). true to ignore case of letters. false not to ignore.
            strA = "Mahmoud saadallah ibrahim";
            strB = "Mohamed Awadallah IBRAHIM";
            Console.WriteLine(String.Compare(strA, 16, strB, 16, 7, true));// 0
            Console.WriteLine(String.Compare(strA, 16, strB, 16, 7, false));// -1

            //-------------------------------/
            /// 3.CompareTo(String):
            /// Compares this instance with a specified String object and indicates whether this instance
            /// precedes, follows, or appears in the same position in the sort order as the specified string.
            string2 = "apple";
            string3 = "apple";
            Console.WriteLine(string2.CompareTo(string3));// 0
            string3 = "Apple";
            Console.WriteLine(string2.CompareTo(string3));// -1
            Console.WriteLine(string3.CompareTo(string2));// 1

            //------------------------------/
            /// 4.Concat(StrA, StrB)
            /// 
            /// Concatenates the string representations of two specified objects.
            /// 
            string2 = "apple";
            string2 = String.Concat(string2, ", banana");
            Console.WriteLine(string2);// apple, banana
            string3 = "test";
            string3 = String.Concat(string3, string2);
            Console.WriteLine(string3);// testapple, banana

            //-----------------------------/
            /// 5.Concat(Object, Object, Object)
            /// Concatenates the string representations of three specified objects.
            /// we can concate more than three objects.
            string4 = "new "; string2 = "apple "; string3 = "test ";
            string4 = String.Concat(string4, string3, string2);
            Console.WriteLine(string4);// new test apple 

            //-----------------------------/
            /// 6.Concat(Object[])
            /// Concatenates the string representations of the elements in a specified Object array.
            String string6;
            char[] arr1 = { 'a', 'b', 'c', 'd' };
            string6 = String.Concat(arr1);
            Console.WriteLine(string6);// abcd

            //-----------------------------/
            /// 7.Contains(Char || substring)
            /// 
            /// Returns a value(true, false) indicating whether a specified character or string occurs within 
            /// this string.
            ///  
            string2 = "Mahmoud saadallah";
            Console.WriteLine(string2.Contains('s'));// True
            Console.WriteLine(string2.Contains("saad"));// True
            Console.WriteLine(string2.Contains("sad"));// false


            //----------------------------/
            /// 8.Contains(Char, StringComparison)
            /// Returns a value indicating whether a specified character occurs within this string, 
            /// using the specified comparison rules.
            /// 
            string2 = "Mahmoud Saadallah";
            Console.WriteLine(string2.Contains('A', StringComparison.OrdinalIgnoreCase));// True
            Console.WriteLine(string2.Contains('w', StringComparison.OrdinalIgnoreCase));// false

            //----------------------------/
            /// 9.Copy(String)
            /// 
            /// Obsolete.
            /// Creates a new instance of String with the same value as a specified String.
            /// This will create a new object has the same values that the origianl object has.
            /// It's not like clone which create new reference to the same object.
            /// 
            string2 = "Mahmoud Saadallah.";
            string6 = string.Copy(string2);
            Console.WriteLine(string6);// Mahmoud Saadallah.
            Console.WriteLine(string2.GetHashCode());// 2113809858
            Console.WriteLine(string6.GetHashCode());// 2113809858
            ///It's important to note that GetHashCode() provides a hash code based on the string's content. 
            ///For strings with the same content, regardless of whether they are the same instance or separate
            ///instances, their hash codes will be the same.
            ///so don't be confused when you find that they have the same hashcode and think they are two 
            ///  reference to the same object. because they have two objects.
            ///  

            //----------------------------/
            /// 10.CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)	
            /// 
            /// Copies a specified number of characters from a specified position in this instance to 
            ///    a specified position in an array of Unicode characters.
            ///    
            /// Parameters:
            /// sourceIndex: The starting index in the source string from which to begin copying characters.
            /// destination: The character array to which the characters will be copied.
            /// destinationIndex: The starting index in the destination array where the copying will start.
            /// count: The number of characters to copy from the source string to the destination array.
            /// 
            string strSource = "changed";
            char[] destination = { 'T', 'h', 'e', ' ', 'i', 'n', 'i', 't', 'i', 'a', 'l', ' ',
                                   'a', 'r', 'r', 'a', 'y' };
            Console.WriteLine(destination);// The initial array

            strSource.CopyTo(0, destination, 4, 7);
            Console.WriteLine(destination);// The changed array

            strSource = "A different string";

            // Embed only a section of the source string in the destination
            strSource.CopyTo(2, destination, 3, 9);

            // Print the resulting array
            Console.WriteLine(destination);// Thedifferentarray

            //----------------------------------/
            /// 11.EndsWith( subString)
            ///
            /// Determines whether the end of this string instance matches the specified string.
            /// 
            string2 = "Mahmoud saadallah";
            Console.WriteLine(string2.EndsWith("ah")); // true
            Console.WriteLine(string2.EndsWith("s")); // false
            Console.WriteLine(string2.EndsWith("ALLAH", StringComparison.OrdinalIgnoreCase)); // true


            //---------------------------------/
            /// 12.Equals(String)
            /// 
            /// Determines whether this instance and another specified String object have the same value.
            /// 
            string2 = "apple";
            string3 = "apple";
            Console.WriteLine(string2.Equals(string3));// true
            Console.WriteLine(String.Equals(string2, string3));// true

            string3 = "APPLE";
            Console.WriteLine(string2.Equals(string3));// false
            Console.WriteLine(string.Equals(string2, string3));// false

            Console.WriteLine(string.Equals(string2, string3, StringComparison.OrdinalIgnoreCase));// true
            Console.WriteLine(string2.Equals(string3, StringComparison.OrdinalIgnoreCase));// true

            //-----------------------------------/
            /// 13.Format(IFormatProvider, String, Object)
            /// 
            /// The string.Format method in C# is a powerful and flexible way to create formatted strings
            ///   by combining a format string and one or more objects. 
            /// It is typically used to create text-based representations of data.
            /// 
            String myName = "Mahmoud";
            int myAge = 22;
            double height = 1.78;
            String formatedString = String.Format("My name is: {0}\n I'm {1} years old\n" +
                "my hight is: {2}", myName, myAge, height);
            Console.WriteLine(formatedString);//My name is: Mahmoud
                                              //I'm 22 years old
                                              //my hight is: 1.78

            //-----------------------------------------/

            //--------------------------------------------------------------------------------------------//
            /// Struct
            /// 
            /// To call struct we use the new keyword like calling class, but even if we didn't use new keyword
            ///  the engin will allocate it in memory as it is a vlaue type not refernce type like class.
            Common c = new Common(0,0,0);
            Console.WriteLine(c.publicFild);
            Console.WriteLine(c);// it will call atomaticlly ToString method as we override it in struct.

            //------------------------------------------------------------------------------------------------------//
            /// Enums
            DaysOfTheWeek day = DaysOfTheWeek.Monday;
            Console.WriteLine(day);// Monday.
            switch (day)
            {
                case DaysOfTheWeek.Monday:
                    {
                        Console.WriteLine(2);
                        break;
                    }
                case DaysOfTheWeek.Saturday:
                    {
                        Console.WriteLine(7);
                        break;
                    }
                case DaysOfTheWeek.Tuesday:
                    {
                        Console.WriteLine(3);
                        break;
                    }
                case DaysOfTheWeek.Wednesday:
                    {
                        Console.WriteLine(4);
                        break;
                    }
                case DaysOfTheWeek.Thursday:
                    {
                        Console.WriteLine(5);
                        break;
                    }
                case DaysOfTheWeek.Friday:
                    {
                        Console.WriteLine(6);
                        break;
                    }
                case DaysOfTheWeek.Sunday:
                    {
                        Console.WriteLine(1);
                        break;
                    }
            }

            // enum is an intger values with lables.
            // like in our example here sunday is 0 with lable Sunday, monday is 1 with lable Monday and so on.
            // so we could say DaysOfTheWeek day4 = (DaysOfTheWeek) 4; and it will return Thursday.
            DaysOfTheWeek day4 = (DaysOfTheWeek) 4;
            Console.WriteLine(day4); // Thursday.
            // if we give it a value not in the enum like 10 and we know Days of the week is 7 then it will return the same passed value.
            day4 = (DaysOfTheWeek)10;
            Console.WriteLine(day4);    

        }// End of main



        // In this method printLine which accept two parameters we put a default values for paramters that be accepted 
        //     this mean we could call this method without passing any data to it at this time the complier will use default values
        //     but if we pass any data then the passed data will be used.
        // Also we could pass data in different order, but in this time we have to write the name of parameter then : then value.
        //Also we could pass just one of parameters not all parameters.
        public static void printLine(int n = 5, System.String output = " * ")
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(output);
            }
            Console.WriteLine();
        }// End of printLine method.


        // Swap by vlaue function
        static void swapByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }// End of swapByValue method


        // Swap by Reference function
        static void swapByReferenc(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }// End of swapByReferenc method

        // sumArray method which accept int array and sum its value 
        static int sumArray(int[] array)
        {

            array = new int[10];
            Console.WriteLine(array.GetHashCode);
            array = new int[10];
            int sum = 0;
            for (int i = 0; i < array?.Length; i++)
            {
                sum += array[i];
            }
            array = new int[10];
            return sum;
        }// End of sumArray method

        static void ModifyPersonNameByReference(ref int[] array)
        {
            array = new int[10];
        }//End of ModifyPersonNameByReference

        static void sumAndMultiply(int n1, int n2, out int sum, out int mulitply)
        {
            //Note: When using out, you must assign a value to all out parameters within the method before it returns.
            sum = n1 + n2;
            mulitply = n1 * n2;
        }

    }// end of class.

    ///Struct
    /// In C#, a struct (short for "structure") is a value type that represents a composite data type.
    /// Unlike classes, which are reference types, structs are value types, meaning they are stored directly
    ///   in memory where they are declared rather than being stored in the heap and referenced indirectly.
    /// Structs are generally used for lightweight data structures that have a small memory footprint and
    ///    are frequently copied.
    ///    
    /// Here are some key characteristics of structs in C#:
    /// 1. **Value Type**: Structs are value types, which means they are copied when assigned to another
    ///   variable or passed as a method parameter.This is in contrast to classes, which are reference types and are passed by reference.
    ///   
    /// 2. **Memory Allocation**: Structs are allocated on the stack or as part of another object's memory
    ///  allocation, making them more efficient in terms of memory usage and performance compared to classes.
    ///  
    /// 3. **Constructor**: Structs can have constructors, but unlike classes, they cannot have a default
    ///   (parameterless) constructor.All fields of a struct must be initialized in a constructor.
    ///   
    /// 4. **Inheritance**: Structs cannot inherit from other structs or classes, and they cannot serve as 
    ///   a base for other classes or structs.
    ///   
    /// 5. **Members**: Structs can have fields, properties, methods, and events, similar to
    ///   classes.However, they cannot have finalizers (destructors) or be used as base types.
    ///   
    /// 6. **Default Values**: If a struct is not explicitly initialized, its fields will be assigned 
    ///   default values(zero or null values) based on their data types.
    ///   
    /// 7. **Copying and Equality**: When you assign a struct to another variable or pass it as a method 
    ///   parameter, a copy of the struct is made.Each copy has its own separate data.Equality for structs 
    ///   is based on the values of their fields.
    ///     
    /// 8. **Immutable**: It's a good practice to design structs to be immutable (i.e., their fields   cannot be changed after creation). This helps maintain consistency and predictability.
    // Default access modifer inside namespace for(class, struct) is: internal
    struct Common
    {
        /// Access Modifer:
        /// Default access level in struct or class is: private by default not like java which has a default
        ///    access level which is default to the package scope.
        ///    
        /// In C#, access modifiers are keywords that specify the visibility and accessibility of types
        /// (classes, structs, enums, etc.), members (fields, properties, methods, etc.), and nested types  
        /// Access Modifer:
        /// within a namespace or class. Access modifiers control which parts of your code can access certain 
        /// Access Modifer:
        /// types and members, helping you manage the visibility of your code's elements.
        /// 
        ///Here are the main access modifiers in C#:
        ///
        /// 1. **`public`**: Members with this modifier are accessible from any code that can see the 
        ///   containing class or struct. They have the widest accessibility.(Accessable everywhere).
        ///
        /// 2.**`protected`**: Members with this modifier are accessible within the containing class, as well 
        ///  as in derived classes.They are not accessible from outside the class hierarchy.
        ///  (Between base and child class) inhertance only.
        ///
        /// 3. **`internal`**: Members with this modifier are accessible within the same assembly(project). 
        ///   It allows sharing code among classes within the same assembly but not to code outside that assembly.
        ///   An assembly is a compiled unit of code that could be a single .NET executable file, a DLL 
        ///   (Dynamic Link Library), or other types of assemblies.
        ///  This mean it's accessable at anyplace inside the programe even if it in defferent nameSpace.
        ///
        /// 4. **`protected internal`**: This is a combination of `protected` and `internal`. Members with
        ///   this modifier are accessible within the same assembly and also in derived classes, whether 
        ///   those derived classes are in the same or different assemblies.
        /// 5. **`private`**: Members with this modifier are only accessible within the containing class or 
        ///     struct. They are not accessible from outside the class.
        ///     
        /// 6. ** 'private protected'**: The private protected access modifier restricts access to the 
        ///      containing class and derived classes within the same assembly. This modifier was introduced  
        ///      to allow a combination of private and protected behavior.

        public int publicFild = 0;
        // Accessable from everywhere inside or outside the assembly file.

        internal int internalFild;
        // Accessable from everywhere inside the assembly file.

        private int privateFild;
        // Accessable inside the class only.

        // protected filds can't be declared inside sturct as it can't be inherted.

        public Common(int pulicFild, int internalFild, int privateFild)
        {
            // we could have a constructor inside struct.
            // Any userdefined Contstructor in struct must fully initialize all struct Attribute.
            this.internalFild = internalFild;
            this.privateFild = privateFild;
            this.publicFild = pulicFild;

        }
        public void print() 
        {
            Console.WriteLine($"PublicFild: {publicFild} \n" +
                $"internalFild: {internalFild} \n" +
                $"privterFild: {privateFild}" );
        }
        public override string ToString()
        {
            return $"publicFild: {publicFild}, privateFild: {privateFild}, internalFild: {internalFild}";
        }

    }

    /// <Enumeration:>
    /// In C#, an enum (short for "enumeration") is a value type that defines a named set of related named constants. 
    /// Enums provide a convenient way to work with a group of related constants that represent distinct values.
    /// Enums make code more readable, maintainable, and self-documenting by giving meaningful names to specific values. 
    /// 
    /// In this example, an enum named DaysOfWeek is defined, containing the names of the days of the week as constants.
    /// Each constant represents a unique integer value starting from 0 (Sunday) to 6 (Saturday).
    /// Enums are indexed starting from 0 by default, but you can assign specific integer values to enum constants if needed.
    /// 
    /// Enums are particularly useful when you want to represent a limited set of options or states in your code. 
    /// They improve code readability by using descriptive names instead of hard-coded integer values.
    /// 
    /// Key points about enums in C#:
    /// 1. Underlying Type: Enums have an underlying integral type(usually int), and each enum member corresponds 
    ///    to a unique integer value of that type.
    ///    
    /// 2. Value Assignment: By default, the first enum member has a value of 0, and subsequent members are 
    ///    assigned values incrementing by 1. However, you can explicitly assign values to enum members.
    /// 
    /// 3. Comparisons: Enums are compared using value equality.You can use enums in comparisons, switch statements,
    ///     and as method parameters.
    ///     
    /// 4. ToString(): Calling ToString() on an enum member returns its name as a string.
    /// 
    /// 5.  Casting: You can cast an enum value to its underlying type and vice versa.
    /// 
    /// 6.  Namespace: Enums are typically defined within a namespace.
    /// 
    /// Enums are a great way to make your code more expressive and self-explanatory, especially when dealing with sets of related constants.
    /// 
    /// </Enumeration:>
    enum DaysOfTheWeek
    {
        // enum is an intger values with lables.
        // like in our example here sunday is 0 with lable Sunday, monday is 1 with lable Monday and so on.
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }


    class Test
    {
        public String testString;
    }
    class Test2
    {
        public Test test;
    }
}