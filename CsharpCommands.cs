// This importing of the System nameSpace to use all classes in it.
using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Linq.Expressions;
using System.Net;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

/* In C sharp we could use a static using to import any class as a static so we could use all the methods
    in this class without writing all the pass of the mehtod like when we use a System.Console class
    as  a static class so we could call the method wirteLine and write without calling the System.Console 
    by just write down the name of the method.
*/
using static System.Console;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;
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
            Common c = new Common(0, 0, 0);
            Console.WriteLine(c.publicFild);
            Console.WriteLine(c);// it will call atomaticlly ToString method as we override it in struct.

            //------------------------------------------------------------------------------------------------------//
            /// Enums
            DaysOfTheWeek day = DaysOfTheWeek.Monday;
            Console.WriteLine(day);// Monday.
            Console.WriteLine((int)day);// 1.
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
            DaysOfTheWeek day4 = (DaysOfTheWeek)4;
            Console.WriteLine(day4); // Thursday.

            // if we give it a value not in the enum like 10 and we know Days of the week is 7 then it will return the same passed value.
            day4 = (DaysOfTheWeek)10; // we have to use explicit casting.
            Console.WriteLine(day4);

            // We have to know that when we try to store the enum values in database it will be stored not with label 
            //    but it will be stored with its integer values, as if we store sunday in database it will be stored with value 0.

            // What about if we want to change the value of the label. 
            // For example if we have an enum which has the name of departments in our company and want to store each 
            //   department Id not with integer number start with 0. we want to give each lable an Id to store it in 
            //   database with its id.
            // The next enum will give spacific values to lables.
            Departments dep1 = Departments.security;
            System.Console.WriteLine(((int)dep1)); // 401
            dep1 = Departments.network;
            System.Console.WriteLine(((int)dep1)); // 403 as the security department take 401 then the department
                                                   // projectManagement take 402 and network take 403
                                                   // and so on we don't have to give each department value if the increasing is by one.


            /*
                /// <Enum_flags>
                /// Lets imagin the following situation:
                /// If we have four flags (Read, Write, Excute, Delete) to give primission to user to modify data and we want 
                ///    to store them in binary(1000, 0100, 0010, 0001) by this way, so we don't have to use array of flags which 
                ///    will use 4 byte in memory and this is extra useage. we could use an enum with data type of byte which could 
               ///    store 8 flags not just four so we could save the memory.
               /// We could give each flage his value in different ways in binnary or hexdecmial or decmial.
               /// </Enum_flags>
               /// 
               // we have to know that we couldn't use two premissions at the same time until we use this command
                [Flags]
                // this command is used to allow us to use the enum as a flag not just bit. this command make the CLR know that we could make
                //    a commbsion of two or more flags using OR, AND or XOR.

               enum premission : byte
               {
                   Read = 0x08, Write = 0b0000_0100, Excute = 2, Delete = 0x1, Admin = 0x0f 
               }

             */
            Premission p1 = Premission.Read;
            p1 ^= Premission.Write; // Read xor  Write.
            Console.WriteLine((p1));// Read, Write
            p1 ^= Premission.Read;
            Console.WriteLine((p1));// Write.
            p1 = (Premission)12;
            Console.WriteLine(p1);// Read, Write
            // As now p1 has Read and write flage if we want to check if the read flage is used by using equal operator
            //   '==' it will return false as the equal Operator doesn't check bit by bit it check the all value, so
            //   it will see the value of p1 = 12.
            if (p1 == Premission.Read)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            // it will retrun false 
            // so to check if the read flage is used then we have to make an expression with and operator.
            if ((p1 & Premission.Read) == Premission.Read)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
            // false.

            //------------------------------------------------------------------------------------------------------//
            /// Indexer
            phoneBook book = new phoneBook(6);
            book.setEntry(0, "abc", 123);
            book.setEntry(1, "def", 456);
            book.setEntry(2, "xyz", 789);
            book.setEntry(3, "nop", 159);
            Console.WriteLine(book.getNumber("xyz"));// 789
            /// This way of dealing with the class phonBook take lot of time as we have to call the function set entry
            ///    to set a number and call the function getNumber to get a number and this is so boring. 
            /// There is another way by using indexer to get number like using array like say book["abc"] which will 
            ///     return 123 without calling any methods.
            /// To do so we need an indexer in the phoneBook class.

            book["def"] = 357;
            Console.WriteLine(book["nop"]);// 159
            Console.WriteLine(book["def"]);// 357

            book[4, "jkl"] = 351;
            Console.WriteLine(book["jkl"]); // 351

            Console.WriteLine(book[3]); // name: nop ::: number: 159


            //------------------------------------------------------------------------------------------------------//
            ///<InterFace>
            ///</InterFace>
            SeriesByTwo seriesByTwo = new SeriesByTwo();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{seriesByTwo.Currrent}  ");
                seriesByTwo.GetNext();
            } // 0  2  4  6  8  10  12  14  16  18

            // We could create reference of interface, but it has to refer to any class implement this interface.
            ISeries series = new FibSeries();
            // This way of creation an object is create an object from FibSeries class, but could use the method of 
            //     ISeries interface only which mean if there are any method owned by FibSeries class this object couldn't use it.
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{series.Currrent}   ");
                series.GetNext();
            }


            //--------------------------------------------------------------------------------------------------//
            ///<foreach>
            /// The foreach statement in C# is used to iterate over elements in a collection (such as arrays, lists, or
            ///    any type that implements the IEnumerable interface) without the need for explicit indexing or manual
            ///    iteration. It simplifies the process of looping through each element of a collection, making the 
            ///    code more concise and readable.
            ///  
            /// foreach (var element in collection)
            /// {
            ///         // Code to be executed for each element
            /// }
            /// element: Represents the current element being iterated over.
            /// collection: The collection(or object implementing IEnumerable) to be iterated.
            /// </foreach>

            int[] arr = { 10, 5, 8, 7, 9, 2, 1, 3 };
            Array.Sort(arr); // this is used to sort array.
            foreach (int i in arr)
            {
                // i : read only.
                Console.WriteLine(i);// 1  2  3  5  7  8  9  10
            }
            ///<Points>
            ///
            /// Read-Only: The variable used in the foreach loop is read-only and cannot be modified within the loop.
            /// No Indexing: foreach abstracts away indexing and simplifies iteration.
            /// No Need for Length: You don't need to know the length or size of the collection to iterate using foreach.
            /// Collection Conformance: The collection being iterated must conform to the IEnumerable or IEnumerable
            ///    < T> interface.
            /// Easier to Understand: foreach enhances code readability by focusing on the iteration logic rather 
            ///   han indexing details.
            ///   
            /// </Points>
            /// 

            // Here we use Array.sort to sort array, because this arry is integer array, but if this array is array 
            //    of object then we couldn't use Array.sort directly to sort it as we have to make these objects
            //    in this arrray implement IComparable interface 
            //----------------------------------------------------------------------------------------------------///
            ///<SortingArray>
            /// value type arrays could be sorted using Array.sort, but refernce type array couldn't until we
            ///    implement IComparable interface.
            /// </SortingArray>
            char[] charArray = { 'a', 'd', 'y', 'x', 't', 'e' };
            Array.Sort(charArray);// it will be sortted as it is value type array.

            Employee[] employee =
            {
                new Employee(1, "Ahmed Mohamed", 7050),
                new Employee(2, "Mahmoud Saadallah", 9400),
                new Employee(3, "Omar Emad", 10000),
                new Employee(4, "Osman Aslam", 11400)
            };
            Array.Sort(employee); // this will return an error of type
            // System.InvalidOperationException: 'Failed to compare two elements in the array.
            // To use this command to sort array of object we need to implement IComparable intereface in the class Employee.
            // now after implement this interface we could implement the single method on it which is CompareTo
            //   and by implementation we could decide way of sortting.
            foreach (Employee i in employee)
                Console.WriteLine(i);

            //----------------------------------------------------------------------------------------///
            ///<Execption_Handling>
            /// Exception handling in C# is a mechanism that allows you to gracefully handle and manage runtime
            /// errors, known as exceptions, that may occur during program execution. Exceptions can be caused by
            /// various factors, such as invalid input, unexpected conditions, or external issues like file I/O
            /// errors or network problems. By handling exceptions, you can prevent your program from crashing and
            /// provide appropriate error messages or alternative behaviors.
            /// 
            /// Here's how exception handling works in C#:
            /// 
            /// Throwing Exceptions:When an error occurs, you can throw an exception using the throw statement.
            /// Exceptions are instances of classes derived from the System.Exception class or its subclasses.
            /// 
            /// Catching Exceptions:
            /// To catch exceptions, you use try and catch blocks.
            /// The try block contains the code that might throw an exception.
            /// The catch block specifies the type of exception to catch and provides code to handle the exception.
            /// 
            /// Finally Block:
            /// You can include a finally block after a try and catch block.
            /// The finally block contains code that executes regardless of whether an exception was thrown
            /// or caught.
            ///  It's often used to clean up resources that were acquired in the try block.
            ///  
            /// Multiple Catch Blocks:
            /// You can have multiple catch blocks to handle different types of exceptions.
            /// The first catch block that matches the thrown exception's type will be executed.
            /// </Execption_Handling>


            int x, y, z;


            // here we don't know what type of input will the uset enter may be the user will enter char 
            //   which will trow an execption or enter a string.
            // To handle these satates we could use try block.
            // When using try block we have to use catch block or finally block or use both of them.
            try
            {
                x = int.Parse(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());

                // here also the user might enter zero to y and the next command will return an error as we
                //  devied by zero.
                z = x / y;
                // To use your own execption that you create in another class we have to use "throw new" keyword.
                if (y < 0)
                    throw new NegativeNumberExecption();
                // then we could catch this execption in catch block.

                // If all the code inside try block excute without execption then the catch block will 
                //    never execute.
            }
            ///<CatchBlock>
            /// The catch block is used to handle exceptions that are thrown within a try block.it 
            ///   provides a mechanism to respond to specific types of exceptions and execute custom code 
            ///   when those exceptions occur.
            ///   The catch block follows the try block and comes before any finally block if present.
            /// Catch block is used to catch execption. inside the catch block we define the type of 
            ///   exectption that might be happen.
            /// There are lot of execptions implemented in System.Execption class 
            /// If we use catch block without define type of excpected execption this mean we use parent
            ///   Execption class.
            ///</CatchBlock>

            /*
            *  try
               {
                  // Code that may throw an exception
                  }
                  catch (ExceptionType1 ex)
                  {
                     // Code to handle ExceptionType1
                  }
                  catch (ExceptionType2 ex)
                  {
                      // Code to handle ExceptionType2
                  }
                  // Additional catch blocks as needed

            */

            ///<PointsOfCatch>
            /// Key points about the catch block:
            /// 
            /// Exception Type: Each catch block specifies the type of exception it will catch. 
            ///  For example, catch (DivideByZeroException ex) will catch DivideByZeroException or its
            ///   derived exceptions.
            /// 
            /// Handling Logic: Inside the catch block, you write code to handle the specific exception 
            ///   that is caught.This might involve providing an error message, logging the error, or 
            ///   taking corrective action.
            ///   
            /// Variable Name: The exception object is assigned to a variable(ex in the example above)
            ///   that allows you to access information about the exception, such as its message, stack
            ///   trace, and inner exceptions.
            ///   
            /// Multiple Catch Blocks: You can have multiple catch blocks to handle different types of
            ///     exceptions.The first catch block that matches the exception type will be executed,
            ///     and subsequent catch blocks will be skipped.
            ///     
            /// General catch Block: You can have a general catch block that catches any exception type. 
            ///    However, using specific catch blocks for known exception types is recommended for better
            ///    error handling and debugging.
            ///    
            /// Catch Filter(when Clause): You can use a when clause to filter exceptions within a catch
            ///   block.This allows you to add additional conditions to decide whether to handle an
            ///   exception or not.
            /// </PointsOfCatch>

            /// we have to know that the order of catch blocks is so important as we start with child 
            ///   execptions then parants 
            /// Here in our example the ArtithmeticExecption can't be come befor DividedByZeroExecption
            ///    as the arthmetic is the parent of DividebyZero, and so on with the genral Execption
            ///    int the third catch it can't come before any other catch blocks as its the base
            ///    for all execptions.
            catch (NegativeNumberExecption ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("You have to change the vlaue of denominator. ");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            ///<FinallyBlock>
            ///
            /// The finally block in C# is used in conjunction with the try and catch blocks to ensure that
            ///    a section of code is executed regardless of whether an exception is thrown or not. 
            /// The code within the finally block is guaranteed to be executed, even if an exception
            ///    occurs and is caught by a catch block
            ///    
            /// Purpose: The finally block is used for cleanup operations or ensuring that certain code is
            ///    executed no matter what.
            ///    
            /// Execution Order: The finally block is executed after the try block and any catch block(s),
            ///    regardless of whether an exception occurred or was caught.
            ///    
            /// No Exception: If no exception is thrown, the finally block still executes.
            /// 
            /// Exception Caught: If an exception is caught in a catch block, the finally block still 
            ///    executes after the catch block.
            ///    
            /// Exception Uncaught: If an exception is not caught, the finally block executes before the
            ///    exception propagates further.
            ///     
            /// Common Use Cases: Releasing resources(such as closing files or network connections) and
            ///    performing cleanup operations are common use cases for the finally block.
            ///</FinallyBlock>
            finally
            {
                Console.WriteLine(" we are in finall.");
            }

            // At the end we have to know that the execption handling with try and catch must be the last soluation
            //   to protect your code.
            // we could protect the same code without exectption handling with try and catch which will be more better.


            ///<Protective_Programming>
            /// At the first we have to handle the parse mehod which convert input from user to specific data type.
            /// To do so we could use "TruParse" method which will return true if the parthing could be happen or
            ///   return false if the parsing can't be happen without execption fired.
            ///</Protective_Programming>
            do
            {
                Console.WriteLine("Enter value to x");
            }
            while (!int.TryParse(Console.ReadLine(), out x));
            /// Here this do and while will be execute until the user enter an integer number
            /// int.TryParse(Console.ReadLine(), out x): mean try the value which user enter if it could be converted
            ///   to integer then put this value to x and end do while, if not retrun again to do while until the user
            ///   enter an integer value.
            do
            {
                Console.WriteLine("Enter value to y");
            }
            while (!int.TryParse(Console.ReadLine(), out y) || y <= 0);
            // Here the execption will never be fired so we could divid x into y without any execption.
            z = x / y;


            //-----------------------------------------------------------------------------------------------------//
            ///<Object_Initializer>
            /// We could create object in differnt ways. one of them is the boring way which we create the object 
            ///    first then sent data to the public fild in this object one by one.
            /// The second way is by create object and sent data to the public fild in the same command.
            /// </Object_Initializer>

            Employee e1 = new Employee();
            e1.Salary = 7000;
            e1.BirthDate = new DateTime(1995, 12, 2);
            e1.Age = DateTime.Now.Year - e1.BirthDate.Year;
            // This is the boring way.

            Employee e2 = new() { Salary = 10000, BirthDate = new DateTime(1991, 7, 3), Name = "Ahmed" };
            // This is syntax suger.

            //------------------------------------------------------------------------------------------------------//
            ///<Copy_Ctor>
            ///
            /// If we have an object and we want to create another object has the same data of the original object 
            ///    in this case if we use equal sign "=" this will make a new refernce refere to the same object 
            ///    not making a new object, so in this case we will have just one object with two refernces.
            /// 
            /// To solve this problem and make a new object with the same data we have to use Copy constructor.
            /// 
            /// </Copy_Ctor>

            // The way of using copy constructor is by using new key word and pass the orignal object to the ctor
            //   but before that we have to implement the ctor in the class to accept the object and copy its data.

            Car oldCar = new Car(1, "BMW", 180);
            Car newCar = new Car(oldCar);
            // This will create a new copy of object with the same data.
            // To make sure these two objects are not the same we could check the hashCode for both of them.
            Console.WriteLine(oldCar.GetHashCode());
            Console.WriteLine(newCar.GetHashCode());
            // both of them will retrun deffernt values which mean they are not the same object.

            //---------------------------------------------------------------------------------------------------//
            ///<Clone>
            ///
            /// There is another way to copy constructor(object) using Clone method, but before using this method 
            ///   we have to implement the interface "ICloneable" in our class(The class which we will use).
            ///   
            ///</Clone>

            // now after implementing the ICloneable interface we could use clone method to make a new copy of object.
            Car anotherNewCar = (Car)newCar.Clone();
            // We have to use explicit casting as the Clone method accept any type of object so we have to till
            //   the engin that it is a car object.

            Console.WriteLine(newCar.GetHashCode());
            Console.WriteLine(anotherNewCar.GetHashCode());
            // they will return two different values.

            //---------------------------------------------------------------------------------------------------//
            ///<Static>
            ///</Static>

            // In the Utility class there are two methods which thay are static methods so we could access them without
            //  create an object of this class, just using class name.
            Console.WriteLine(Utility.Inch2Cm(40)); // 101.6
            Console.WriteLine(Utility.Cm2Inch(40)); // 15.748031496062993
            Console.WriteLine(Utility.CircleArea(10)); // 314

            //--------------------------------------------------------------------------------------------------//
            ///<One-Instance_Class>
            ///</One-Instance_Class>

            OneInstanceClass firstInstace = OneInstanceClass.createInstance();
            OneInstanceClass secondInstace = OneInstanceClass.createInstance();
            Console.WriteLine(firstInstace.GetHashCode());
            Console.WriteLine(secondInstace.GetHashCode());
            // They will return the same value as this class create only one instance.


            OneInstanceClass2 thirdInstance = OneInstanceClass2.createInstance();
            OneInstanceClass2 fourthInstance = OneInstanceClass2.createInstance();
            Console.WriteLine(thirdInstance.GetHashCode());
            Console.WriteLine(fourthInstance.GetHashCode());
            // they eill return the same value.


            //--------------------------------------------------------------------------------------------------//
            ///<Operator-Overloading>
            ///</Operator-Overloading>


            Complex c1 = new Complex()
            {
                Real = 10,
                Imag = 6
            };
            Complex c2 = new()
            {
                Real = 22,
                Imag = 7
            };
            Complex c3, c4, c5, c6;
            c3 = c1 + c2;
            Console.WriteLine(c3.ToString()); // 32 + 13i

            c4 = c2 + 5;
            Console.WriteLine(c4.ToString()); // 27+7i

            c5 = 5 + c1;
            Console.WriteLine(c5.ToString()); // 15+6i

            c6 = c2 - c1;
            Console.WriteLine(c6.ToString()); // 12+1i

            // We didn't overload += operator but when we overload the + operator the += operator will be initialzed by default.
            c1 += c2;
            Console.WriteLine(c1.ToString()); // 32+13i

            // Also when we overload - operator then the -= will be overloaded by default.
            c1 -= c2;
            Console.WriteLine(c1.ToString()); // 10+6i

            // Unary Arithmatic operator. '-'
            c1 = -c2;
            Console.WriteLine(c1.ToString()); // -22+-7i

            c1++;
            Console.WriteLine(c1.ToString()); // -21+-7i
            ++c1;
            Console.WriteLine(c1.ToString()); // -20+-7i

            c1--;
            Console.WriteLine(c1.ToString()); // -21+-7i
            --c1;
            Console.WriteLine(c1.ToString()); // -22+-7i


            // Implicit Casting.
            int number7 = c1;
            Console.WriteLine(number7); // -22

            // Explicit Casting.
            double number8 = (double)c1;
            Console.WriteLine(number8); // -22

            string str7 = (string)c1;
            Console.WriteLine(str7); // -22+-7i

            //-------------------------------------------------------------------------------------------------------//
            ///<Equality>
            ///
            /// There are differnet ways to check equality in c#:
            /// First we have to know the type of equality in programming:
            /// There are two types of equality in c#:
            /// 
            /// 1. Identity equality (Reference equality): This type of equality is depened on the reference so if we 
            ///     have two references refere to the same object then they are equal, but if we have two refernces 
            ///     refere to two differenct objects then they will not identity equal even if they have the same data.
            ///     
            /// 2. Value equality: This type of equality is depened on the value not the reference so  if we 
            ///     have two references refere to the same object then they are equal as they have the same data value
            ///     also if we have two refernces refere to the two different objects then they are equal if they 
            ///     have the same data value.
            ///     
            /// </Equality>


            ///<Class_Equality>
            ///
            /// Class Equality is system object members. it has different ways to check equality:
            /// 
            /// 1. public virtual bool equals(object o){} : it's refernce equality.
            /// 2. public static bool equals(object o1, object o2){} : it's refernce equality  but we have to know that
            ///     this function is used to call the first function as if we look at the body of this function we will
            ///     find it like that: { return o1.equals(o2);}. 
            ///     
            /// 3. public static ReferenceEquals(object o1, object o2){} : it's reference equality.
            /// 
            /// Note: you have to know that the first function could be change by override then the second function
            ///       will be changed as it call the first function, but the third function couldn't be overrided as 
            ///       it's static function so it will be always refernce equality.
            ///       
            /// 4. Operator == : it's refernce equality.
            /// 
            /// To make a function value equality we could override the first function to make it value equality.
            /// 
            /// </Class_Equality>

            Point firstPoint = new Point() { x = 10, y = 51 };
            Point secondPoint = new Point() { x = 10, y = 51 };
            Point thirdPoint = firstPoint;

            if (firstPoint.Equals(secondPoint))
                Console.WriteLine("first Point = second point");
            else
                Console.WriteLine("first point != second point");

            if (firstPoint.Equals(thirdPoint))
                Console.WriteLine("first Point = third point");
            else
                Console.WriteLine("first point != third point");



            ///<Struct_Equality>
            ///
            /// Class Equality is system.valueType object members. it has different ways to check equality:
            /// The system.ValueType change the way of equal working to value equality.
            /// 
            /// 1. public virtual bool equals(object o){} : it's value equality.
            /// 2. public static bool equals(object o1, object o2){} : it's value equality  but we have to know that
            ///     this function is used to call the first function as if we look at the body of this function we will
            ///     find it like that: { return o1.equals(o2);}. 
            /// 
            /// 3. public static ReferenceEquals(object o1, object o2){} : it's not suitable to be used with values.
            /// 
            /// 4. Operator == : it's not automaticlly emplemented, so to use it you have to implement it(overload).
            /// </Struct_Equality>



            //------------------------------------------------------------------------------------------------//
            ///<Virtual_Methods>
            ///
            /// In C#, a virtual method is a method declared in a base class (or an interface) that can be overridden
            ///  in derived classes. The virtual keyword is used to declare a method as virtual, which means that it
            ///  can be replaced with a different implementation in subclasses. This concept is fundamental to 
            ///  achieving polymorphism and enabling runtime method dispatch based on the actual type of an object.
            ///  
            /// </Virtual_Methods>

            TypeA BaseRef = new TypeA(12);
            BaseRef.staticllyBindedShow(); // base.
            BaseRef.DynamicllyBindedShow(); // base.

            TypeB drivedRef = new TypeB(4, 9);
            drivedRef.staticllyBindedShow(); // drived.
            drivedRef.DynamicllyBindedShow();// drived.

            BaseRef = new TypeB(4, 8);
            /// Refernce to base = Drived object.   This mean i could use the part of Reference in drived, but i 
            ///    couldn't use the part of drived itself. So i could say BaseRef.A = 10; , but i couldn't say 
            ///    BaseRef.B = 10;
            BaseRef.A = 10;
            //BaseRef.B = 10;// Error.

            BaseRef.staticllyBindedShow(); // base.
            /// All the statically Binded Methods(non virtual) the compiler Bind call based in Refernce type not object
            ///   type.

            BaseRef.DynamicllyBindedShow();// drived
            /// Dynamiclly Binded method, CLR will bind function Call based on object Type in Runtime.

            BaseRef = new TypeC(10, 5, 6);

            BaseRef.DynamicllyBindedShow();// TypeC.

            BaseRef = new TypeD(10, 8, 6, 5);
            BaseRef.DynamicllyBindedShow(); // TypeC. as the last class that use this method with keyword override is
                                            // the TypeC class. 
                                            // To access the DynamicllyBindedShow() method in TypeD class then we have to use refernce of typeD as this
                                            //   method is implemented with keyword new in TypeD class.
            TypeD RefD = new TypeD(85, 5, 6, 7);
            RefD.DynamicllyBindedShow(); // TypeD.

            // if we create a new class that inhert from TypeD class then the new class will not be able to see the 
            //  DynamicllyBindedShow method in TypeC it will be able to see only the new implemented method in TypeD.
            // Also we could make this mehtod as new virtual in typeD class to be overrided in the drived classes 
            // form this class.

            //--------------------------------------------------------------------------------------------------//
            ///<Generic>
            ///
            /// Let's have an example to know the benfit of using generic let's consider that i have a class Helper
            ///   which has one method (swap()) method this mehtod is used to swap two interger numbers, so when i 
            ///   pass two integer number to it, it will work, but if i try to pass two double numbers to it it will 
            ///   return an error as it's not accept any double numbers.
            ///   
            /// </Generic>
            int numberX = 10, numberY = 6;
            Helper.swap(ref numberX, ref numberY);
            Console.WriteLine(numberX); // 6
            Console.WriteLine(numberY); // 10

            double n1 = 1.54, n2 = 66.656;
            // if i try using swap function to swap these two double numbers it will retrurn error as the swap function
            //   doesn't accept double numbers.
            // Helper.swap(ref n1, ref n2); // Error.
            // the same thing will happen if we try to swap any two data type execpt integer.so the only way to solve 
            //    this problem is by overload the swap function to accept double and also overload it to accept string
            //    and so on with all data type, but this way will be too long and take lot of memory and time, so 
            //    to solve it we could use generic.

            /// by suing a Generic method to swap we could use single method to deal with all data type even with 
            /// refernce data type.
            /// now after implement generic method to swap so we could use it with any data type.

            Helper.swap(ref n1, ref n2); // i could call it like this way or i could explicitly define the type of T.
            Helper.swap<int>(ref numberX, ref numberY); // This is the way by explicit the type of T.
            Console.WriteLine($"n1 {n1}");//66.656
            Console.WriteLine($"n2 {n2}");//1.54

            string str1 = "one", str2 = "two";
            Helper.swap(ref str1, ref str2);
            Console.WriteLine($"str1: {str1}"); // two.
            Console.WriteLine($"str2: {str2}"); // one.
            // In case of generic method (not generic class or struct or interface) compiler can detect Type parameter
            //   T type from input parameter, but in case of class or interface i have to Explicit the type.

            // The pervious case i use generic in method, but what about if i use the generic to the class Helper2.
            // When using generic class the way of calling will be change.As in the calling we have to specife the type
            //   of T.
            string str3 = "three", str4 = "four";
            Helper2<string>.swap(ref str3, ref str4); // here i have to explicit the type of T.
            Console.WriteLine($"str3 {str3}"); // four.
            Console.WriteLine($"str4 {str4}"); // three.

            //----------------------------------------------------------------------------------------------------------//
            ///<Collection>
            ///
            /// </Collection>

            ///<List<T>>
            ///
            /// In C#, List<T> is one of the most commonly used collection classes provided by the .NET Framework. 
            /// It is part of the System.Collections.Generic namespace and allows you to create dynamic, resizable lists
            ///   that can hold elements of a specific data type (T).
            ///   
            /// Here are the key features and usage details of List<T>:
            /// 
            /// 1. Creating a List:
            /// You can create a new instance of List<T> by specifying the type of elements it will hold:
            /// List<int> numbers = new List<int>(); // Creates an empty list of integers
            /// 
            /// 2. Adding Elements:
            /// You can add elements to a list using the Add method:
            /// numbers.Add(42);
            /// numbers.Add(10);
            /// 
            /// 3. Accessing Elements:
            /// You can access elements in a list by their index using square brackets ([]):
            /// int firstNumber = numbers[0]; // Retrieves the first element (42)
            /// 
            /// 4. Count and Capacity:
            /// Count: Returns the number of elements in the list.
            /// Capacity: Returns the number of elements that the list can currently hold without resizing.
            /// int count = numbers.Count;
            /// int capacity = numbers.Capacity;
            /// 
            /// 5. Removing Elements:
            /// You can remove elements by value using the Remove method or by index using the RemoveAt method:
            /// numbers.Remove(10); // Removes the first occurrence of 10
            /// numbers.RemoveAt(0); // Removes the element at index 0
            /// 
            /// 6. Iterating Over a List:
            /// You can iterate over the elements of a list using various techniques, such as foreach loops or LINQ querie
            /// foreach (int number in numbers)
            /// {
            ///    // Process each number
            /// }
            /// // Using LINQ to filter or transform elements
            /// var filteredNumbers = numbers.Where(n => n > 20);
            /// 
            /// 7. Sorting:
            /// You can sort a list using the Sort method:
            /// numbers.Sort(); // Sorts the list in ascending order
            /// 
            /// 8. Other Useful Methods:
            /// Clear(): Removes all elements from the list.
            /// Contains(T item): Checks if the list contains a specific item.
            /// IndexOf(T item): Returns the index of the first occurrence of an item.
            /// ToArray(): Converts the list to an array.
            /// AddRange(IEnumerable < T > collection): Adds elements from another collection.
            /// TirmExcess(): to tirm or delete un used location in list.
            /// 
            /// 9. Generics:
            /// List<T> is strongly typed, which means it provides type safety. You specify the type of elements the list
            ///   will hold when creating it (<T>).
            ///   
            /// 10. Dynamic Sizing:
            /// List<T> dynamically resizes itself as needed to accommodate more elements, so you don't need to specify an
            ///   initial capacity.
            ///   
            /// List<T> is a versatile and efficient collection class that is widely used in C# for storing and managing
            ///   lists of items.
            /// It's suitable for a wide range of scenarios, from simple data storage to more complex data manipulation 
            ///   and filtering operations.
            /*
             * The `List<T>` class in C# provides various methods to manipulate and work with lists. Here are some of the most commonly used methods of the `List<T>` class:

            **1. Add**: Adds an element to the end of the list.

            ```csharp
            List<int> numbers = new List<int>();
            numbers.Add(42);
            numbers.Add(10);
            ```

            **2. AddRange**: Adds a collection of elements to the end of the list.

            ```csharp
            List<int> numbers = new List<int>();
            List<int> moreNumbers = new List<int> { 1, 2, 3 };
            numbers.AddRange(moreNumbers);
            ```

            **3. Remove**: Removes the first occurrence of a specific element from the list.

            ```csharp
            List<int> numbers = new List<int> { 42, 10, 42 };
            numbers.Remove(42); // Removes the first occurrence of 42
            ```

            **4. RemoveAt**: Removes the element at a specific index.

            ```csharp
            List<int> numbers = new List<int> { 42, 10, 5 };
            numbers.RemoveAt(1); // Removes the element at index 1 (10)
            ```

            **5. RemoveAll**: Removes all elements that match a specified condition.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.RemoveAll(n => n % 2 == 0); // Removes even numbers
            ```

            **6. Clear**: Removes all elements from the list.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.Clear(); // Removes all elements
            ```

            **7. Contains**: Checks if the list contains a specific element.

            ```csharp
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            bool containsBob = names.Contains("Bob"); // true
            ```

            **8. IndexOf**: Returns the index of the first occurrence of a specific element.

            ```csharp
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            int indexOfBob = names.IndexOf("Bob"); // 1
            ```

            **9. Sort**: Sorts the elements in the list.

            ```csharp
            List<int> numbers = new List<int> { 42, 10, 5 };
            numbers.Sort(); // Sorts the list in ascending order
            ```

            **10. Reverse**: Reverses the order of the elements in the list.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Reverse(); // Reverses the list
            ```

            These are just a few of the many methods provided by the `List<T>` class. `List<T>` is a versatile collection class that makes it easy to work with lists of elements in C# and is widely used in a variety of scenarios.


            Certainly! Here are more commonly used methods of the `List<T>` class in C#:

            **11. Find**: Returns the first element that matches a specified condition.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            int result = numbers.Find(x => x > 3); // Returns the first element > 3 (4)
            ```

            **12. FindAll**: Returns all elements that match a specified condition.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> results = numbers.FindAll(x => x % 2 == 0); // Returns all even numbers [2, 4]
            ```

            **13. TrueForAll**: Checks if all elements in the list satisfy a specified condition.

            ```csharp
            List<int> numbers = new List<int> { 2, 4, 6, 8, 10 };
            bool allEven = numbers.TrueForAll(x => x % 2 == 0); // true
            ```

            **14. ConvertAll**: Converts all elements in the list to a different data type using a specified converter function.

            ```csharp
            List<string> strings = new List<string> { "1", "2", "3" };
            List<int> integers = strings.ConvertAll(int.Parse); // Converts to List<int> [1, 2, 3]
            ```

            **15. FindIndex**: Returns the index of the first element that matches a specified condition.

            ```csharp
            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
            int index = names.FindIndex(name => name.StartsWith("B")); // Returns index of "Bob" (1)
            ```

            **16. Insert**: Inserts an element at a specified index.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3 };
            numbers.Insert(1, 42); // Inserts 42 at index 1 [1, 42, 2, 3]
            ```

            **17. InsertRange**: Inserts a collection of elements at a specified index.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3 };
            List<int> additionalNumbers = new List<int> { 4, 5 };
            numbers.InsertRange(1, additionalNumbers); // Inserts [4, 5] at index 1 [1, 4, 5, 2, 3]
            ```

            **18. GetRange**: Returns a new list containing elements from a specified range of indices.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> subrange = numbers.GetRange(1, 3); // Returns [2, 3, 4]
            ```

            **19. RemoveRange**: Removes a specified number of elements starting from a specified index.

            ```csharp
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.RemoveRange(1, 3); // Removes elements at index 1, 2, and 3 [1, 5]
            ```

            These additional methods provide even more flexibility when working with lists in C#. The `List<T>` class offers a wide range of methods to help you manipulate and manage your lists efficiently.
             */
            ///   
            ///<List<T>>

            // When we declar a list without specifie the capacity of it, the compilor will creat an array with capacity
            //  equal to 4, then after adding element to this list till it complite and add more than the capacity the 
            //  compilor will create new list with the capicity equal to double old one capacity and copy the old the old 
            //  list to the new one.

            List<int> ilst = new List<int>();
            // To get size of list we use function count().
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 0  capacity: 0

            ilst.Add(1);
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 1  capacity: 4
            //ilst.Add("2"); //compiler enforce type safty at compilation Type.
            ilst.Add(2);
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 2  capacity: 4
            ilst.Add(3);
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 3  capacity: 4
            Console.WriteLine(sumList(ilst)); // 6

            // we can't use indexer(squer brackets[]) to add to list 
            // ilst[5] = 10; // ArgumentOutOfRangeExecption
            // indexer for update and get not for add;

            ilst.Add(4);
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 4  capacity: 4
            ilst.Add(5);
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 5  capacity: 8

            // We could add more than one parameter at a time using addRang() function which accept array of parameter.
            ilst.AddRange(new int[] { 6, 7, 8, 9 }); 
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 9  capacity: 16

            // To delete the unused location in list we could use TirmExcess() function.
            ilst.TrimExcess();
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 9  capacity: 9

            ilst.Add(10);
            Console.WriteLine($"size: {ilst.Count}  capacity: {ilst.Capacity}");//  size: 10  capacity: 18



            ///<Dictionary>
            /// In C#, a Dictionary<TKey, TValue> is a collection class that represents a collection of key-value pairs, 
            ///   where each key is associated with a value. It is part of the System.Collections.Generic namespace.
            /// Here are the key features and usage details of Dictionary<TKey, TValue>:
            ///   
            /// 1. Creating a Dictionary:
            /// You can create a new instance of Dictionary<TKey, TValue> by specifying the types for keys (TKey) and 
            ///   values (TValue):
            ///   Dictionary<string, int> ageMap = new Dictionary<string, int>();
            ///   
            /// 2. Adding Key-Value Pairs:
            /// You can add key-value pairs to the dictionary using the Add method or by directly indexing into the
            ///   dictionary:
            /// ageMap.Add("Alice", 30);
            /// ageMap["Bob"] = 25;
            ///
            /// 3. Accessing Values by Key:
            /// You can access values in the dictionary using the associated keys:
            /// int aliceAge = ageMap["Alice"]; // Retrieves the value associated with "Alice" (30)
            /// 
            /// 4. Checking for Key Existence:
            /// You can check if a key exists in the dictionary using the ContainsKey method:
            /// bool containsBob = ageMap.ContainsKey("Bob"); // true
            /// 
            /// 5. Removing Key-Value Pairs:
            /// You can remove key-value pairs using the Remove method:
            /// ageMap.Remove("Alice"); // Removes the key-value pair with the key "Alice"
            /// 
            /// 6. Iterating Over a Dictionary:
            /// You can iterate over the key-value pairs in the dictionary using a foreach loop:
            /// foreach (var pair in ageMap)
            /// {
            ///     string name = pair.Key;
            ///     int age = pair.Value;// Process the key-value pair
            /// }
            /// 
            /// 7. Count:
            /// The Count property returns the number of key-value pairs in the dictionary:
            /// int count = ageMap.Count;
            /// 
            /// 8. TryGetValue:
            /// You can safely retrieve a value by key using the TryGetValue method, which avoids exceptions if the key
            ///   is not found:
            /// if (ageMap.TryGetValue("Charlie", out int charlieAge))
            /// {
            ///      // Key "Charlie" exists, and charlieAge contains the value
            /// }
            ///  else
            ///  {
            ///       // Key "Charlie" does not exist
            ///  }
            ///  
            /// 9. Dictionary Initialization:
            /// You can initialize a dictionary using collection initializer syntax:
            /// Dictionary<string, int> scores = new Dictionary<string, int>
            /// {
            ///    { "Alice", 95 },
            ///    { "Bob", 88 },
            ///    { "Charlie", 75 }
            /// };
            /// 
            /// 10. Value Collection and Key Collection:
            /// You can access the collection of values or keys using the Values and Keys properties, respectively:
            /// ICollection<int> allAges = ageMap.Values;
            /// ICollection<string> allNames = ageMap.Keys;
            /// 
            /// 11. Duplicate Keys:
            /// Keys in a dictionary must be unique. If you attempt to add a duplicate key, it will throw an exception
            ///  
            /// 12. Generics:
            /// Dictionary<TKey, TValue> is strongly typed, allowing you to specify the types for keys and values 
            ///   when creating it.
            ///   
            /// Dictionaries are widely used to store and retrieve data efficiently based on keys.
            /// They are suitable for scenarios where you need fast lookups and associations between keys and values.
            /// 
            ///</Dictionary>

            Dictionary<string, long> phoneBook = new Dictionary<string, long>();
            // key must be unique.
            phoneBook.Add("abc", 123);
            phoneBook.Add("def", 456);
            phoneBook.Add("xyz", 789);
            //phoneBook.Add("xyz", 159); Execption key must be unique.
            // To handle this execption we could use Try.
            if (phoneBook.TryGetValue("def", out long number))
            {
                // Key "def" exists, and charlieAge contains the value
                phoneBook["def"] = 147;// update.
            }
            else
            {
                // Key "Charlie" does not exist
                phoneBook.Add("def", 159); // adding.
            }

            if (!phoneBook.ContainsKey("xyz"))
                phoneBook.Add("xyz", 159);
            else
                phoneBook["xyz"] = 159;// update

            // To update data for any key we could use indexer.
            phoneBook["abc"] = 541;// used to update value to specific key.
            // Also we could use indexer for adding
            phoneBook["nwc"] = 565; // indexer for adding.
            // also we could use indexer for retrive data.
            Console.WriteLine(phoneBook["def"]);// 456   // used to get.
            // if we try to retrive non exist value then it will return an execption.
            //Console.WriteLine(phoneBook["djk"]); // it will throw an execption.
            // To handle this execption we could use contain.
            if (phoneBook.ContainsKey("djk"))
                Console.WriteLine(phoneBook["djk"]);
            else
                Console.WriteLine("not found");

            // To loop inside the dictionary we could use foreach loop to loop with keyValuePare.
            foreach (KeyValuePair<string, long> item in phoneBook)
                Console.WriteLine($"{item.Key} : {item.Value}");
            // or we could use it by the next foreach 
            foreach (var item in phoneBook)
                Console.WriteLine($"{item.Key} {item.Value}");

            // To return the number of paries in dictionary
            Console.WriteLine(phoneBook.Count);//4

            // You can initialize a dictionary using collection initializer syntax:
            Dictionary<string, int> scores = new Dictionary<string, int>
            {
                { "Alice", 95 },
                { "Bob", 88 },
                { "Charlie", 75 }
            };


            //----------------------------------------------------------------------------------------------//
            ///<Mehod_Pointer>
            ///</Mehod_Pointer>

            // step 1. Delegate declaration.
            strFunDelegate fptr;

            // step 2. Pointer To Function(Delegate) Initalization.
            fptr = new strFunDelegate(StringFunctions.getLength);
            // // we could also use it in a simple way of initalization like
            fptr = StringFunctions.getLength;// here without using new strFunDelegate.
            // here our delegate refare to static method.

            // step 3. using Pointer to function, call function.
            // to call the function we use invoke function which is part of delegate class.
            int numberOfChar  = fptr.Invoke("Mahmoud");
            Console.WriteLine(numberOfChar);// 7

            fptr = new strFunDelegate(StringFunctions.getUpCah);
            int numberOfUpperChar = fptr("AvseCdG");
            Console.WriteLine(numberOfUpperChar); // 3

            //fptr = new strFunDelegate(StringFunctions.fullNameLength); // Error.
            //Error CS0123  No overload for 'fullNameLength' matches delegate 'strFunDelegate'
            // this will return an error as the delegate signature not the same as the function
            //   fulNameLength signature.

            // To refare to non static function we have to create an object of the class that contain 
            //  non static function, then use this object to get the function.
            StringFunctions obj =  new StringFunctions();
            obj.ch = 'h';
            fptr = obj.getChNum;
            int numberofRepatedChar = fptr.Invoke("hand hello");
            Console.WriteLine(numberofRepatedChar);  // 2


            // This is the first way to use Bsort function to sort an array form the smallest to the greatest.
            // in this way we can't control the way of sorting as the sorting will be always form smaller to greater.
            // but when we deal with delegate we will have the ablity to use different ways.
            int[] array02 = { 2, 6, 5, 7, 1, 9, 12, -1, -9, 11 };
            SortingAlgorathm.Bsort(array02);
            foreach (int i in array02)
                Console.WriteLine(i);// -9  -1  1  2  5  6  7  9  11  12


            // here when we use delegate we could control the way of using sorting as the ComLes, and the 
            //  ComGer in the CompFunction class have the same signature.
            CompFunDelegate Cptr = new CompFunDelegate(CompFunction.ComLes);      
            SortingAlgorathm.Bsort(array02, Cptr); // here sortting will be from greater to smaller.
            foreach (int i in array02)
                Console.WriteLine(i); // 12  11  9  7  6  5  2  1  -1  -9
            Cptr = CompFunction.ComGer;
            SortingAlgorathm.Bsort(array02, Cptr);// here sortting will be from smaller to greater.
            foreach (int i in array02)
                Console.WriteLine(i);// -9  -1  1  2  5  6  7  9  11  12

            //---------------------------------------------------------------------------------------------//
            ///<Delegate_With_Generic>
            ///
            /// We could use delegate with generic to make a delegate that could refere any method that accept 
            ///   any specific number of parameter no matter what is the data type.
            ///   
            /// So here we used a strFunDelegate which accept one parameter of type T and return bool, as the 
            ///    accepted parameter is not a specific type then we could use this delegate to refere to any 
            ///    method that accept any type of one parameter and return bool. 
            /// in our example we use this deleget to refer to checklength method which accept string and 
            ///    return bool, and we also we use the same delegate to refere to anther method COdd which 
            ///    accept int and retrun bool. so this mean we could use this delegate with any method that 
            ///    accept one parameter of any type and return bool.
            ///  
            /// </Delegate_With_Generic>

            List<string> stringList = new List<string>() { "Ahmed", "Omer", "Mahmoud", "mai", "ali" };
            strFunDelegate<string> sptr = CondFuctions.checklength;
            List<string> str = usingCondition.findCondition(stringList, sptr);
            foreach(string s in str)
                Console.WriteLine(s);


            strFunDelegate<int> sptr2 = CondFuctions.COdd;
            List<int> intlst = new List<int>() { 1, 4, 5, 6, 14, 16, 18, 13, 17, 19, 20, 23, 30, 3, };
            intlst = usingCondition.findCondition(intlst, sptr2);
            foreach (int s in intlst)
                Console.WriteLine(s);

            // Here we use Generic Delegate that refere any mehod accpet one parameter with any data type and return output
            //    with the same data type as accepted parameter.
            // in our example getAbs funcion accept int and return int so we could use this generic delegate with it.
            strFunDelegate2<int> sptr3 = CondFuctions.getAbs;
            Console.WriteLine(sptr3.Invoke(-400));// 400
            // Actally we don't need to call Invoke method each time we need to invoke the delegate we could 
            //   use it without any methods
            Console.WriteLine(sptr3(-400));// 400


            /// <Built_In_Delegate>
            /// 
            /// There are some built in delegate that we could use instead of make our own delegate:
            /// In C#, there are several built-in delegate types provided by the .NET Framework, which are part of the
            ///   System and System.
            /// Delegate namespaces. These delegate types simplify common scenarios for delegate usage. 
            /// Here are some of the most commonly used built-in delegate types:
            /// 
            /// 1.Action:
            ///   Represents a delegate that has no return value (void).
            ///   Used for methods that perform an action but don't return a value.
            ///   Can accept up to 16 parameters (overloads available).
            ///   example:
            ///   Action<string> printMessage = (message) => Console.WriteLine(message);
            ///   printMessage("Hello, World!");
            /// 
            /// 2.Func:
            ///   Represents a delegate that takes parameters and returns a value.
            ///   Used for methods that return a value.
            ///   Can accept up to 16 parameters (overloads available).
            ///   example:
            ///   Func<int, int, int> add = (x, y) => x + y;
            ///   int result = add(3, 4); // 7
            ///   
            /// 3.Predicate:
            ///   Represents a delegate that defines a method that takes one parameter and returns a boolean value.
            ///   Commonly used for filtering collections.
            ///   example:
            ///   Predicate<int> isEven = (x) => x % 2 == 0;
            ///   bool even = isEven(6); // true
            ///   
            /// 
            /// 4.Comparison:
            ///   Represents a delegate that compares two objects of the same type.
            ///   Useful for custom sorting or ordering of objects.
            ///   example:
            ///   Comparison<string> stringComparison = (x, y) => x.CompareTo(y);
            ///   int result = stringComparison("apple", "banana"); // < 0
            ///   
            /// 5.Converter:
            ///   Represents a delegate that converts one type to another.
            ///   Often used when converting elements in collections.
            ///   example:
            ///   Converter<int, string> intToString = (x) => x.ToString();
            ///   string text = intToString(42); // "42"
            ///      
            /// </Built_In_Delegate>
            Predicate<int> sptr4 = CondFuctions.COdd;
            intlst = usingCondition2.findCondition(intlst, sptr4);
            foreach (int s in intlst)
                Console.WriteLine(s);


            // Action Delegate:
            // this delegate dosen't return any thing it returns void.
            Action<string> Asptr0 = new Action<String>(CondFuctions.print);
            Asptr0("My name is mahmoud"); // my name is mahmoud.
            //---------------------------------------------------------------------------------------------//
            /// <Anonymous_Method>
            /// 
            /// An anonymous method in C# is a method without a name, defined inline within the code. 
            /// It allows you to define a method's implementation right where it's needed, typically as an 
            ///   argument to a delegate or as a lambda expression. 
            /// Anonymous methods are a way to create delegate instances with less formal method declarations.
            /// Here are more details and examples of anonymous methods in C#:
            /// Syntax:
            /// Anonymous methods are defined using the delegate keyword followed by a parameter list and a
            /// code block:delegate (parameters) { /* method body */ }
            /// 
            /// Implicit casting from function body to pointer  to function.
            /// The idea of using Anonymous function is that we most of our funcions we used with delegate 
            ///   in the previous examples were too short function, and we use them just for one time, so we 
            ///   don't need to make these functions in different class as we could implement them using 
            ///   delegate as an anonymous funcions
            /// </Anonymous_Method>


            // As we see here in this command we use the predicate delegate to point to function that accept
            //   integer parameter and check if this parameter is devideable by 2.
            // As we see we don't need to declare this funcion as public static to use it as we implement it
            //   in main method also we don't need to make the return type as bool as the predicate delegate
            //   known as a bool return delegate.
            // we just need to write delegate to make cast and write input parameters then write the body of 
            //   of our method.
            Predicate<int> sptr5 = delegate (int x) { return x % 2 == 0; }; // this is function on the fly.
            Console.WriteLine(sptr5(6));//true
            intlst = usingCondition2.findCondition(intlst, sptr5);
            foreach (int s in intlst)
                Console.Write(s); // 4, 6, 14, 16, 18, 20, 30,

            // At runtime the compiler genrate a new class and genrate new method in that class and put the 
            //  same body of delegate to this function then make our delegate refere to this function.
            // If we create any other function on the fly it will be in the same class. so the compiler make
            // new class that save all functions on the fly.
            

            // To use Func delegate to declare Anonymous function we have to specify number and type of inputs
            //  and type of output, as in our example here func accept two integer parmeter and return integer.
            Func<int, int, int> sptr6 = delegate(int x,int y) { return x > y ? x : y; };
            Console.WriteLine(sptr6(10, 12)); // 12

            Action<string> Asptr1 =  delegate (string s) { Console.WriteLine(s); };
            Asptr1("mahmoud"); // mahmoud


            //-----------------------------------------------------------------------------------------------//
            ///<Lambda_Exepression>
            ///
            /// Lambda expressions are a concise way to represent anonymous methods in C#.
            /// They provide a simplified syntax for defining small, inline functions. 
            /// Lambda expressions are often used when you need to pass a delegate to a method, create a short 
            ///   method implementation, or define inline transformations. 
            /// Here are more details and examples of lambda expressions in C#:
            /// Syntax:
            /// (parameters) => expression-or-statement-block
            /// parameters: The input parameters (if any) of the lambda expression.
            /// =>: The lambda operator separates the parameters from the expression or statement block.
            /// expression-or-statement-block: The code to be executed when the lambda is invoked.
            ///  
            /// Lambda expressions are commonly used in scenarios where you would typically use anonymous
            /// methods or delegates. 
            /// They provide a more concise and expressive way to define short methods.
            /// example:
            /// // Lambda expression that takes two integers and returns their sum
            /// Func<int, int, int> add = (a, b) => a + b;
            /// int result = add(3, 4); // 7
            /// 
            /// 
            /// </Lambda_Exepression>

            // =>: this operator called fat arrow. read as : Goes to.


            Predicate<int> sptr7 = (int x) => { return x % 2 == 0; };
            Console.WriteLine(sptr7(9)); // false
            // As we see here when we using lambda expression we don't need to use delegate keyword 
            // We also could simplfy this line of code to make it more shorter by:
            // We know that sptr7 accept int as we defend as Predicate<int>, and retur boo as it is Predicate
            //   so we could delete the type of input parameter after = sign and also delate return keyword.
            sptr7 = x => x % 2 == 0;
            Console.WriteLine(sptr7(9)); // false
                                         // this line of code do the same as:
                                         // sptr7 = (int x) => { return x % 2 == 0; };

            // So lambda expression allow as to make anonymous method using delegate with short code.
            // If our funcion consist of multiple line, we have to use cuerl brackets and use return keyword.

            // We have to know that we don't need to use delegate to use lambda expression we could use it with
            //   any mehod even if it is not anonymous. and we could also use it with if, for and switch.


            Action<int, int> Asptr2 =  (x, y) => { int s = x + y;  Console.WriteLine(s); };
            Asptr2?.Invoke(4, 6);// 10


            //---------------------------------------------------------------------------------------------//
            ///<Events>
            ///</Events>
            
            Ball ball = new Ball();
            Player pl1 = new Player { Name = "Player11", Team = "team01" };
            Player pl2 = new Player { Name = "Player12", Team = "team01" };
            Player pl3 = new Player { Name = "Player21", Team = "team02" };
            Player pl4 = new Player { Name = "Player12", Team = "team02" };
            Refree R1 = new Refree() { Name = "Refree1" };

            ball.BallLocation = new Location {X = 70, Y= 10, Z = 18};
            Console.WriteLine(ball);

            // We use here += to work in multTask.
            // Event keyword in delegate decalration is resposable for crearting list with += sign, if we
            //   delate  event then we could use this delegate direct with = sign, but in this state it will
            //   not be a list of Adresses it will work with singl method a time(single Task). 
            ball.BallLocationChanged += pl1.Run;
            ball.BallLocationChanged += pl2.Run;
            ball.BallLocationChanged += pl3.Run;
            ball.BallLocationChanged += pl4.Run;
            ball.BallLocationChanged += R1.Look;

            ball.BallLocation = new Location { X = 12, Y = 77, Z = 11 };

            // If we want to delate any player or refree from list of registraion we could use -=
            // This mean delate Pointer that point to pl4 from list.
            // after this line of code execute the pl4 will not notify when the locaion of ball change.
            ball.BallLocationChanged -= pl4.Run;


        }// End of main





        // funtion to add integer List
        public static int sumList(List<int> list)
        {
            int sum = 0;
            foreach (int i in list)
                sum += i;
            return sum;
        }


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
                $"privterFild: {privateFild}");
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
    // We could change the dateType of enum from int to any other numeric datatype by the next way 
    // it is look like inhertance, but it's not an inhertance.
    enum Departments : short
    {
        softWare = 101,
        hardWare = 201,
        programming = 301,
        security = 401,
        projectManagement,// it will take 402 by default as the previous one has 401 value.
        network // 403
    }

    /// <Enum_flags>
    /// Lets imagin the following situation:
    /// If we have four flags (Read, Write, Excute, Delete) to give primission to user to modify data and we want 
    ///    to store them in binary(1000, 0100, 0010, 0001) by this way, so we don't have to use array of flags which 
    ///    will use 4 byte in memory and this is extra useage. we could use an enum with data type of byte which could 
    ///    store 8 flags not just four so we could save the memory.
    /// We could give each flage his value in different ways in binnary or hexdecmial or decmial.
    /// </Enum_flags>

    // we have to know that we couldn't use two premissions at the same time until we use this command
    [Flags]
    // this command is used to allow us to use the enum as a flag not just bit. this command make the CLR know that we could make
    //    a commbsion of two or more flags using OR, AND or XOR.
    enum Premission : byte
    {
        Read = 0x08, Write = 0b0000_0100, Excute = 2, Delete = 0x1, Admin = 0x0f
    }

    class Car : IComparable, ICloneable
    {
        int id;
        string model;
        int speed;

        public int Id { get { return id; } set { id = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int Speed { get { return speed; } set { speed = value; } }

        ///<Constructor_Channign>
        /// When we have overload of constructor like the following
        /// public Car(int _id, string _model, int _speed)
        /// {
        ///    this.id = _id;
        ///    this.model = _model;
        ///    this.speed = _speed;
        /// }
        /// 
        /// public Car(int _id, string _model)
        /// {
        ///    this.id = _id;
        ///    this.model = _model;
        ///    this.speed = 60;
        /// }
        /// 
        /// public Car(int _id)
        /// {
        ///    this.id = _id;
        ///    this.model = "BMW";
        ///    this.speed = 60;
        /// }
        /// 
        /// As we see we have three constructors with different parameter, but in all these constructors we implement 
        ///   the same fields. so we could use constructor channing to make this code more better  
        /// </Constructor_Channign>

        public Car(int _id, string _model, int _speed)
        {
            this.id = _id;
            this.model = _model;
            this.speed = _speed;
        }
        public Car(int _id, string _model) : this(_id, _model, 60)
        {

        }
        public Car(int _id) : this(_id, "BMW", 60)
        {

        }
        /// by this way we don't have to implement all the fields in each constructor.


        ///<Copy_Ctor>
        /// If we have an object and we want to create another object has the same data of the original object 
        ///    in this case if we use equal sign "=" this will make a new refernce refere to the same object 
        ///    not making a new object, so in this case we will have just one object with two refernces.
        /// 
        /// To solve this problem and make a new object with the same data we have to use Copy constructor.
        /// </Copy_Ctor>

        // We have to implement the ctor in the class to accept the object and copy its data.
        public Car(Car old)
        {
            this.model = old.Model;
            this.speed = old.Speed;
            this.id = old.Id;
        }

        public int CompareTo(object? obj)
        {
            Car right = (Car)obj;
            return this.speed.CompareTo(right?.speed);
        }

        // By implementing this method we could use it to make new copy of object with the same data.
        public object Clone()
        {
            return new Car(this.id, this.model, this.speed);
        }
    }
    class Test
    {
        public String testString;

    }
    class Test2
    {
        public Test test;
    }

    struct Employee : IComparable
    {
        int id;// private fild by default 

        ///<Property> 
        /// In C#, a property (short for "property procedure") is a member of a class, struct, or interface that 
        ///  provides a flexible way to read or write values of private fields while encapsulating the underlying
        ///  implementation details. Properties allow you to expose data in a controlled and consistent manner, 
        ///  and they are often used to ensure proper access and validation of fields.
        /// </Property>

        ///<Advantages-of-Properties:>
        /// Encapsulation: Properties provide a way to hide the details of how data is stored and retrieved.
        /// Validation: Properties enable you to validate and enforce constraints when getting or setting values.
        /// Code Maintainability: If you need to change how data is stored or computed, you only need to update the 
        /// property implementation.
        ///</Advantages>

        // we have to know that we can't overload property as it the set of property take only one parameter
        // in other way we could say there is no prop take more than one parameter.

        /*
               access-modifier data-type PropertyName
               {
                    get
                    {
                        // return value or expression
                    }
                    set
                    {
                        // set value or perform validation
                    }
               }

          * access-modifier: Specifies the accessibility of the property (public, private, protected, internal, etc.).
          * data-type: Properties have a data type that defines the type of value they store or expose. 
          * PropertyName: The name of the property, usually following PascalCase naming conventions.
         */


        //Auto-Implemented Properties:
        // C# supports auto-implemented properties, which automatically create a private backing field.
        public string Name { get; set; }

        /*
         * Get Accessor (Getter):
            The get accessor retrieves the value of the property.
            It returns the value to the caller.
            It is required for every property and cannot be omitted.

       *   Set Accessor (Setter):
            The set accessor sets the value of the property.
            It allows modification of the underlying data.
            It is optional. If omitted, the property is read-only.
         */
        decimal salary;
        public Decimal Salary
        {
            // To make a prop that has an implemented get and set we have to use a private fild like using private salary 
            //   in the get here we don't use the Salary with capital S, but we use salary which is the name of fild
            //   why?? as if we use Salary which is the name of prop this will make an infinty stack overflow as
            //    the prop is look like the mehtod so it will call him self forever so we use a private fild with 
            //    slef-Implemented properties.
            get
            {
                return salary;
            }
            set
            {
                salary = value >= 1300 ? value : 1300;
            }

        }

        /// <Read-Only Properties:>
        ///  You can have properties with only a get accessor, making them read-only.
        ///  These properties can be set only within the constructor or through internal logic
        /// </Read-Only Properties:>
        int department;
        public int Department
        {
            get
            {
                return department;
            }
        }

        /// <Write-Only Properties:>
        /// You can have properties with only a set accessor, making them write-only.
        /// These properties can be used to set values without directly retrieving them.
        /// </Write-Only Properties:>
        private int managerId;

        public int ManagerId
        {
            set
            {
                //The value keyword is used in the set accessor to represent the value being assigned to the property.
                managerId = value;
            }
        }
        /// <Property Initialization:>
        /// You can initialize properties directly in the property declaration using the { get; set; }
        /// syntax.
        /// This is applicable to auto - implemented properties.
        /// Initialization can simplify the constructor by providing default values.
        /// </Property Initialization:>
        public int Age { get; set; } = 0;

        // We could change the access of get only or set only in property.
        // We could make prop public and get internal or make set private, but the accessor of set or get must ber
        //  mor restrictive than the property which mean if the prop is private we can't make the set or get public
        //    or internal, but if the prop is public we could make set or get public internal or private.
        DateTime birthDate;
        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            internal set
            {
                birthDate = value;
            }
        }

        // we have to know that we can't overload property as it the set of property take only one parameter
        // in other way we could say there is no prop take more than one parameter.
        public override string ToString()
        {
            return $" Id: {id}, name: {Name}, salary: {Salary}";
        }


        public Employee(int id, string name, decimal salary)
        {
            this.id = id;
            this.Name = name;
            this.salary = salary;
        }

        public int CompareTo(object? obj)
        {
            // first we have to make the parameter obj of type Employee so we have to use unBoxing.
            Employee temp = (Employee)obj;
            return this.salary > temp.salary ? 1 : this.salary < temp.salary ? -1 : 0;
        }

    }

    struct phoneBook
    {
        // we have to know that we can't overload property as it the set of property take only one parameter
        // in other way we could say there is no prop take more than one parameter.

        /// <Indexer>
        /// Indexer is a spechial property which accept more than one paramerter and could be overloaded.
        /// An indexer in C# is a special type of property that allows instances of a class or struct to be accessed
        ///    using an index, similar to how arrays are accessed. Indexers provide a way to define and access 
        ///    elements of a collection-like object using indexing syntax. They are particularly useful when you want
        ///    to treat an object as if it were an array or collection.
        ///    
        /// 
        /// </Indexer>
        /// 

        string[] names;
        long[] numbers;
        int size;

        public int Size { get { return size; } }
        public phoneBook(int size)
        {
            this.size = size;
            names = new string[size];
            numbers = new long[size];
        }
        public void setEntry(int index, string name, long number)
        {
            if (index >= 0 && index < size)
            {
                names[index] = name;
                numbers[index] = number;
            }
        }

        public long getNumber(string name)
        {
            for (int i = 0; i < names?.Length; i++)
                if (names[i] == name)
                    return numbers[i];
            return -1;
        }

        ///<Indexer>
        /// Key points about indexers in C#:
        /// Declaration: Indexers are declared with the this keyword followed by the index type in square brackets.
        /// 
        /// Access Modifiers: Indexers can have access modifiers (public, private, protected, internal).
        /// 
        /// Get Accessor: The get accessor is executed when the object is accessed using an index.
        /// 
        /// Set Accessor: The set accessor is executed when a value is assigned to an index.
        /// 
        /// Usage: Indexers are used with an instance of the containing class, just like arrays.
        /// 
        /// Multiple Parameters: You can define indexers with multiple parameters if needed, allowing for more complex
        ///   indexing logic.
        ///   
        /// 
        /// Advantages of using indexers:
        /// Consistent Syntax: Indexers provide a consistent and familiar way to access elements, similar to arrays.
        /// 
        /// Abstraction: Indexers allow you to abstract away the implementation details of how elements are stored and retrieved.
        /// Custom Logic: You can add custom logic inside the indexer's get and set accessors to perform validation, 
        ///    transformation, or other tasks.
        /// Indexers are commonly used in collection classes, allowing you to access elements using natural and 
        ///    intuitive indexing syntax.They help encapsulate data access and promote clean
        ///</Indexer>

        public long this[string name]
        {
            /// here I implement this indexer to retrun numbers of specific name 
            get { return numbers[Array.IndexOf(names, name)]; }
            /// here I implement this indexer to set numbers to specific name 
            set
            {
                if (Array.IndexOf(names, name) > 0)
                    numbers[Array.IndexOf(names, name)] = value;
            }
        }
        // Now I could overload this indexer
        public long this[long index, string name]
        {
            set
            {
                names[index] = index >= 0 && index < size ? name : null;
                numbers[index] = index >= 0 && index < size ? value : 0;
            }
        }

        public String this[int index]
        {
            get { return index >= 0 && index < size ? $"name: {names[index]} ::: number: {numbers[index]}" : "nothing"; }
        }
    }

    /// <interface>
    /// An interface in C# is a contract that defines a set of methods, properties, and events that a class or struct
    /// must implement if it claims to implement that interface. It provides a way to achieve multiple inheritance and 
    /// allows you to define common behavior that can be implemented by different classes. Interfaces are a key 
    /// component of achieving polymorphism in C#.
    /// </interface>
    interface ISeries
    {
        ///<Interface>
        /// Key points about interfaces in C#:
        /// Methods, Properties, and Events: Interfaces can define methods, properties, and events that implementing
        ///   classes must provide.
        /// Multiple Interfaces: A class or struct can implement multiple interfaces, allowing for multiple 
        ///   inheritance-like behavior.
        /// Public Access: Interface members are implicitly public and do not have access modifiers.
        /// Explicit Implementation: A class implementing an interface can explicitly implement interface members, 
        ///   providing more control over naming conflicts.
        /// polymorphism: Interfaces allow you to achieve polymorphism, where you can treat objects of different 
        ///   classes that implement the same interface in a consistent manner.
        /// Contract: An interface represents a contract that implementing classes must fulfill.
        /// No Implementation: Interfaces do not contain implementation details; they define a contract only.
        /// Interfaces can inherit from other interfaces using a comma-separated list.
        /// Interfaces cannot contain fields, only properties. Interface members are implicitly abstract and public.
        /// Classes can implement multiple interfaces.
        /// Interfaces allow unrelated classes to implement common functionality. They provide abstraction and 
        ///   polymorphism.
        /// Interface methods must be implemented by the class using the exact signature defined in the interface.
        /// Interface members are public by default. An interface cannot contain fields, constructors, destructors or 
        ///   finalizers.
        /// A class can inherit from a base class and implement interfaces at the same time. The base class comes 
        ///   first, then interfaces.
        /// Interfaces support multiple inheritance but classes do not. This is a key advantage of interfaces.
        /// Interfaces can extend other interfaces. An interface like IShape can extend IComparable to inherit its members.
        /// Interfaces can contain static members which belong to the interface itself, not the implementing class.
        /// Interfaces are often used to enable polymorphic behavior in classes. A reference of interface type can 
        ///   refer to any object that implements that interfac
        ///<summary>


        // int x;   // get an error as interface can't has a field mermber.

        // interface could have prop
        public int Currrent { get; }

        // interface could have mehtod without implementaion
        // interface methods are public by defualt
        void GetNext();
        void rest();

        // interface also could have implemented methods
        void Countagain()
        {
            numberOfUsingInterface = 0;
        }

        // Interfaces can contain static members which belong to the interface itself, not the implementing class.
        static int numberOfUsingInterface;

        // Interface can't contain constractor.
    }
    // Interface methods must be implemented by the class using the exact signature defined in the interface.
    // when extend interface we have to implement all its method.
    class SeriesByTwo : ISeries
    {
        int current;
        public int Currrent { get { return current; } }

        public void GetNext()
        {
            current += 2;
        }

        public void rest()
        {
            current = 0;
        }
    }
    class FibSeries : ISeries
    {
        int current = 1, prev;

        public int Currrent { get { return current; } }

        public void GetNext()
        {
            int temp = current;
            current = current + prev;
            prev = temp;
        }

        public void rest()
        {
            current = 1; prev = 0;
        }
    }

    /// <Create_your_own_Execption>
    /// You could create your own execption using a class that extend(Inheret) from Execption class.
    /// the resone of extend here is that we can't catch any class that not extend from Execption class.
    /// </Create_your_own_Execption>
    class NegativeNumberExecption : Exception
    {
        public NegativeNumberExecption() : base(" The number must be postive.") { }


    }

    /// <Contaner-Class>
    /// 
    /// A static class in C# is a special type of class that cannot be instantiated like regular classes. It's designed
    ///  to be a container for static members, including static fields, static properties, and static methods. A static
    ///  class is often used to group related utility functions or constants together in a structured manner, without
    ///  the need for object instances.
    ///  
    /// 
    /// A static class cannot be instantiated using the new keyword.
    /// To use class as a container to only static member we have to use staic keyword in the signuture of class.
    /// NO objects could be created form this class.
    /// It cannot contain instance members (non-static fields, properties, or methods).
    /// It cannot be used as a base class, and it cannot inherit from other classes
    /// It is implicitly sealed, meaning it cannot be inherited by other classes.
    /// 
    /// Use Cases:
    /// Utility Functions: Static classes are commonly used to group utility functions and helper methods together.
    ///   These methods are typically independent of instance-specific data and are called using the class name.
    /// 
    /// Math Libraries: Static classes can be used to encapsulate mathematical operations, conversion methods, and 
    ///   other calculations.
    ///   
    /// Constants: Static classes can be used to define constants that are used throughout the application.
    /// 
    /// Factory Methods: Static classes can be used to provide factory methods that create instances of other classes.
    ///  
    /// </Contaner-Class>
    static class Utility
    {

        ///<Static>
        /// Static members in C# belong to the type itself, rather than to an instance of the type. This means that all
        ///   instances of the type share the same static member, and you can access static members without creating an
        ///   instance of the type.
        ///   
        /// Static members include:
        /// 
        /// Static Fields: Variables that are shared among all instances of the class.
        /// Static Properties: Properties that are shared among all instances of the class.
        /// Static Methods: Methods that can be called on the type itself, without creating an instance.
        /// 
        /// Benefits of Static Members:
        /// 
        /// Shared Data: Static members are shared across all instances of the class, making them suitable for storing
        ///   data that should be consistent among instances.
        /// Utility Methods: Static methods can be used to create utility functions that don't require 
        ///   instance-specific data.
        /// Singleton Pattern: Static members can be used to implement the Singleton pattern, ensuring only one
        ///   instance of a class exists.
        /// 
        ///</Static>

        ///<StaticFields>
        ///
        /// Static fields are declared using the static keyword within a class. They are associated with the type 
        ///   itself rather than instances of the class.
        /// Static fields are shared among all instances of the class. If you modify the value of a static field, the
        ///   change is reflected across all instances and other parts of your program that access the field.
        /// Static fields are typically used for data that should be consistent across instances.For example,
        ///   you might use a static field to keep track of the total number of instances created for a class.
        ///   
        /// Static Attributes Allocate in heap before first usage of class till the end of program.
        /// Static members initalized to default values by default.
        ///</StaticFields>


        static double PI;

        ///<StaticConstructor>
        ///
        /// A static constructor is used to initialize static members of a class. It is defined using the static
        ///    keyword and doesn't take any parameters. A static constructor is automatically called before any static
        ///    members are accessed or any static methods are called.
        /// static constructor are execute automaticlly once in the life time of programe before any usage of class.
        /// 
        /// Static Constructor can't specify return DataType, Access Modifier or Input Parameter.
        /// Maximum only one static Constructor per class.
        ///</StaticConstructor>
        // Object ctor is not the right place to initializing static filds, but the best place to initialize static
        //   members is in static Ctor.
        static Utility()
        {
            PI = 3.14;
        }


        /// <StaticMethods>
        /// 
        /// Static methods are defined using the static keyword in their method signature.They belong to the type
        ///   itself, not to instances of the class.
        /// Static methods can be called using the type name, without creating an instance.They can't access
        ///   instance-specific data or instance methods directly.
        /// Static methods are often used for utility functions, operations that don't require instance-specific state
        ///   , and factory methods.
        /// Static methods are also used to access static filds(Attribute, property).
        ///   
        /// </StaticMethods>

        // As we see here we have two functions that not depend on the vlaue of object fields so we could call them 
        //  without create a new object of this class by the name of class directily using static in methods sitgnature
        public static double Cm2Inch(double cm)
        {
            return cm / 2.54;
        }
        public static double Inch2Cm(double Inch)
        {
            return Inch * 2.54;
        }

        public static double CircleArea(double R)
        {
            return PI * R * R;
        }



    }


    class OneInstanceClass
    {
        public int Data { get; private set; }

        ///<Private-Constructor>
        ///
        /// A private constructor in C# is a constructor defined with the private access modifier within a class. 
        /// Unlike public constructors, a private constructor can only be accessed and used within the class itself.
        /// It cannot be accessed from outside the class or be used to create instances of the class directly. 
        /// Private constructors are often used for various purposes, such as enforcing design patterns, controlling 
        /// object creation, and implementing singleton patterns.
        /// 
        /// Common Use Cases:
        /// 
        /// 1. Singleton Pattern: A private constructor is often used when implementing the Singleton pattern.
        ///    In this pattern, a class ensures that it has only one instance and provides a global point of access to
        ///   that instance.
        ///   
        /// 2. Static Classes with No Instances:A class with only static members and methods can have a private 
        ///   constructor to prevent accidental instantiation.This enforces that the class is used as intended,
        ///   without creating instances.
        ///   
        /// 3. Factory Methods: A class might have private constructors and public factory methods that control the 
        ///    creation of instances.This allows the class to control the creation process, enforce certain conditions,
        ///    or provide different object variations.
        /// 
        /// 4. Utility Classes:Private constructors are useful in utility classes that contain only static members.
        ///    They prevent unnecessary instance creation and enforce the intended usage.
        ///    
        /// </Private-Constructor>


        // To make this class has only one instance from it we can't use factory function is the figuar like this
        /*
         * 
         * public static OneInstancClass createInstance()
         * {
         *      return new oneInstanxeClass(1221);
         * }
         * 
         */
        // This way of implement this factory function will allow to create new object evey time we call this method
        //  this is not the way we need to use this class. we need this class to create just one object all the 
        //    the lifetime of this class. 
        // In this case we have to create an attribute with the same type of the class, and make this attribute static
        //    then we could check this attribute in the factory function to see if this atttribute is null then we 
        //    will creat a new instance of to this refernce attribute, but if this attribute is already sign to 
        //    object of this class then we will not create a new object... by this way we could make this class
        //    single instance class.

        // Note: we can't create this attribute in the factory method as this attribute will end with the end of method
        //  so we have make it static arribute in this class to be work till the programe end.

        static OneInstanceClass singleInstance;
        private OneInstanceClass(int data)
        {
            this.Data = data;
        }

        // Factory method that control object creation.

        public static OneInstanceClass createInstance()
        {
            // by this way we make sure that this class is single instance class.
            if (singleInstance == null)
                singleInstance = new OneInstanceClass(1221);
            return singleInstance;
        }

        // BIG NOTE: AFTER DONIGN ALL OF THEIS I HAVE TO SAY THAT THIS IS NOT HE BEST WAY TO CREATE A SINGLE INSTACE
        //   OF CLASS AS THIS WAY HAS PROBLEM WITH THREADS SAFETY.
        /*
         * Thread Safety:Static members can be accessed concurrently by multiple threads, so it's important to consider
         *  thread safety when working with them.
         *  Proper synchronization mechanisms, such as locks, might be needed to ensure correct behavior in 
         *  multi-threaded scenarios
         */

        // To handle this problem we will create a new class with name "OneInstanceClass2" and solve this problem
        //  in it.


    }
    class OneInstanceClass2
    {
        // To handle the problem of thead safety we will creat a static constructor and implement the singlInstance
        //   attribute in this static constructor, as we know the static Ctor is execute once in all the lifetime of 
        //   the programe so when we implement the singlInstance attribute inside it, it will be implemented once 
        //   and also solve the problem of thread safety.
        // In this case we will use the factory mothod to access this singlInstance attribute not to create it.
        // 
        // also we could make the singleIstance as a property as initialzie it without using static Ctor 
        //  public static OneInstanceClass2 singleInstance{get;} = new OneInstanceClass2(1221); 
        // this line of code could be used instead of using static Ctor and factory method .
        public int Data { get; private set; }




        static OneInstanceClass2 singleInstance;
        static OneInstanceClass2()
        {
            singleInstance = new OneInstanceClass2(1221);
        }
        private OneInstanceClass2(int data)
        {
            this.Data = data;
        }

        // Factory method that control object creation.

        public static OneInstanceClass2 createInstance()
        {

            return singleInstance;
        }

    }

    class Complex
    {
        ///<Operator-Overloading>
        ///
        /// Operator overloading in C# allows you to define custom behavior for operators when they are used with
        ///   instances of your own classes. This feature enables you to extend the capabilities of your classes by
        ///   allowing them to interact with operators like +, -, *, /, ==, !=, etc. in a way that makes sense for your
        ///   application's domain.
        ///   
        /// Operators that Can Be Overloaded:
        /// 
        /// Not all operators in C# can be overloaded. The following operators can be overloaded:
        /// 1. Unary Operators: +, -, !, ~, ++, --
        /// 2. Binary Operators: +, -, *, /, %, &, |, ^, <<, >>
        /// 3. Comparison Operators: ==, !=, <, >, <=, >=
        /// 4. Conversion Operators: Explicit and implicit type conversion operators
        /// 
        /// Squer bracket and equal sign can't be overloaded.
        /// 
        /// How to Overload an Operator:
        /// To overload an operator, you define a special static method in your class with the name operator followed by 
        ///   the operator's symbol. This method must be marked as public and static, and it must return a value of the 
        ///   appropriate type.
        ///    
        /// </Operator-Overloading>


        // For example, let's overload the + operator for a ComplexNumber class:
        public int Real { get; set; }
        public int Imag { get; set; }

        // Operator Overloading must be public static method.

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                // to make this code safe we have to use nullable
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
            };
        }

        public static Complex operator +(Complex left, int right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + right,
                Imag = left.Imag
            };
        }

        public static Complex operator +(int right, Complex left)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + right,
                Imag = left.Imag
            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex c)
        {
            return new Complex
            {
                Real = -c.Real,
                Imag = -c.Imag
            };
        }

        // Used for Both pre fix and postfix version (++c, c++)
        public static Complex operator ++(Complex c)
        {
            return new Complex
            {
                Real = c.Real + 1,
                Imag = c.Imag
            };
        }

        // Used for Both pre fix and postfix version (--c, c--)
        public static Complex operator --(Complex c)
        {
            return new Complex
            {
                Real = c.Real - 1,
                Imag = c.Imag
            };
        }

        // if you overload any type of comaprasoin operator then you have to overload the opesite one.
        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag > right.Imag;
            return left.Real > right.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;
            return left.Real < right.Real;
        }
        public override string ToString()
        {
            return $"{Real}+{Imag}i";
        }


        // Implicit casting: when we overload implicit cast there will be no return type to the method.
        public static implicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }

        // Explicit casting: when we overload Explicit cast there will be no return type to the method.
        public static explicit operator double(Complex c)
        {
            return (c?.Real ?? 0);
        }

        public static explicit operator string(Complex c)
        {
            return c?.ToString() ?? "null";
        }
    }

    class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        // This the worst implementation for equals function as it is not secure. 
        //  if we see that the equals function is accept object parameter this object may be any type of ebject not 
        //   only point object it could be string or employee or any thing, but in the first line in the method we cast
        //   that object to point which will return an execption(invalid cast execption) if the passed object not
        //   a point object.
        /*
         *  public override bool Equals(object? obj)
            {
                Point p = (Point)obj; // unsafe casting.
                return this.x == p.x && this.y == p.y ? true : false;   
            } 
         */

        // so we could could handle this way of casting using 'is' which will return true or false without any execption
        // or we could use 'as' which return null if the casting fail.
        public override bool Equals(object? obj)
        {
            // We have to know that may be the Point class is a base class to another class so if we pass a child class
            //   to this method and this child class has the same date like the base class then this method will 
            //   retrun true even if the child object not the same type of Point class. for example
            /*
             *   class point3D : Point
             *   {
             *      public int z {get; set;}
             *   }
             *   
             */
            // now if the object of type point3D is used to passed to this method and this object has value like
            //   x = 5, y = 6 and z = 15;   and we compere it with other object of type Point which has value like 
            //   x = 5, and y = 6, then this method will retrun true which is not correct so we have to handle this 
            //   case using getType method which retrun the type of the object form meta data.

            if (obj.GetType() != this.GetType()) // this will check the type of objects and retrun false if they are
                                                 // not the same type.
                return false;

            // Also we could use a condation which will increase the preformance this check if the two object are 
            //   equal by indentity as if they are equal by indentity then we don't have to check every member of 
            //   these objects.
            if (Object.ReferenceEquals(this, obj)) return true; // this will increase preformance.

            if (obj == null) // this used to handle null values.
                return false;
            if (obj is Point)//  is return false if the casting fail, no execpion will be returned. 
            {
                Point p = (Point)obj;
                return this.x == p.x && this.y == p.y ? true : false;
            }
            else
                return false;

            /// As and Is used with refernce data type so we can't use them with struct as it is value type.
            /*
             *    
             *    Point p = obj as Point;
             *    if(p == null)
             *       retrun false;
             *    return this.x == p.x && this.y == p.y ? true : false;
             *    
             */
        }
    }

    class TypeA
    {
        public int A { set; get; }
        public TypeA(int a) { A = a; }

        public void staticllyBindedShow()
        {
            Console.WriteLine("I am the base.");
        }

        // The virtual mehod must be non private it could be any other access modifer.
        public virtual void DynamicllyBindedShow()
        {
            Console.WriteLine("I am base");
        }
    }
    class TypeB : TypeA
    {
        public int B { set; get; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        public new void staticllyBindedShow() // Using new here is optional not mandatory.
        {
            Console.WriteLine("I am the child.");
        }

        // To override virtual method i have to use override keyword to override method.
        public override void DynamicllyBindedShow()
        {
            Console.WriteLine("I am child.");
        }
    }
    class TypeC : TypeB
    {
        public int C { set; get; }
        public TypeC(int a, int b, int c) : base(a, b)
        {
            C = c;
        }
        public override void DynamicllyBindedShow()
        {
            Console.WriteLine(" I am drived2 (typeC).");
        }
    }
    class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int a, int b, int c, int d) : base(a, b, c)
        {
            D = d;
        }

        // using new here mean new implementation to this method this mean when we didn't use override keyword 
        //   and using new keyword so the last virsion of this virtual method is the one in the last child class 
        //   used keyword override. but this method with new keyword can be access only with a refernce of typeD 
        //   not any other refernces.
        public new virtual void DynamicllyBindedShow()
        {
            Console.WriteLine(" I am drived3 (typeD).");
        }
    }
    class TypeE : TypeD
    {
        public int E { get; set; }
        public TypeE(int a, int b, int c, int d, int e) : base(a, b, c, d)
        {
            E = e;
        }

        // override on typeD Implementation.
        public override void DynamicllyBindedShow()
        {
            Console.WriteLine(" I am drived3 (typeD).");
        }
    }

    /// <Abstract_class>
    /// 
    ///  we could create an abstract class without having any abstract method.
    ///  The resone of doning that is we don't need to create an object of this class but we need only to inhert it w
    ///    without creatting new objects.
    ///    
    /// You cannot create instances of an abstract class directly. You can only create instances of concrete classes
    ///   derived from the abstract class.
    ///   
    /// Abstract classes are used when you want to define a common interface, structure, or behavior for a group of 
    ///   related classes while leaving certain details to be implemented by concrete classes. They promote code 
    ///   reusability and enforce a consistent structure across derived classes.
    ///   
    /// Abstract classes are a fundamental feature of object-oriented programming and are commonly used in C# to create
    /// class hierarchies that share common characteristics but require specific implementations in derived classes.
    ///   
    /// </Abstract_class>
    abstract class person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public person(string _FName, string _LName)
        {
            FName = _FName;
            LName = _LName;
        }
        public override string ToString()
        {
            return $"{FName} {LName}";
        }
    }

    abstract class GeoShape
    {
        public int Dim1 { get; set; }
        public int Dim2 { get; set; }
        public GeoShape(int dim1, int dim2) { Dim1 = dim1; Dim2 = dim2; }

        // abstract method must be in abstract class.
        public abstract double Area();// Abstract method = Virtual + no Implementation.
        public abstract double Perimater { get; } // abstract property.
    }

    // As the Reg class is not abstract and it's inherte the abstract class has abstract method so it have to implement
    //   all the abstract methods in this abstract class.
    class Reg : GeoShape
    {
        public Reg(int W, int H) : base(W, H)
        {

        }

        public override double Perimater { get { return (Dim1 + Dim2) * 2; } }
        // As the area is abstract then we have to implement it using keyword override.
        public override double Area()
        {
            return Dim1 * Dim2;
        }
    }

    ///<Sealed>
    ///
    /// In C#, the sealed keyword is used to prevent further inheritance or overriding of a class, method, or property.
    /// When you mark a class as sealed, it means that other classes cannot inherit from it. When you mark a method or
    ///   property as sealed, it means that derived classes cannot override or hide that specific method or property.
    ///Here are the common use cases for sealed:
    ///
    ///</Sealed>
    class BaseClass
    {
        public int Fild1 { get; set; }
        public virtual int output()
        {
            return Fild1;
        }

        public virtual void print()
        {
            Console.WriteLine("Sealed method can't be override.");
        }

    }
    /// <Sealed_Class>
    /// 
    /// When you mark a class as sealed, it indicates that you do not want other classes to inherit from it.
    /// This is useful when you want to prevent further extension of a class, often because it provides a complete 
    ///   or final implementation.
    ///   
    /// </Sealed_Class>
    sealed class FRefClass : BaseClass
    {
        public override int output()
        {
            return Fild1;
        }
    }
    class SRefClass : BaseClass
    {
        /// <Sealed_Method>
        /// 
        /// When you mark a method as sealed in a base class, it prevents derived classes from overriding or hiding 
        ///   that method. This is useful when you want to provide a specific implementation that should not be changed
        ///   in derived classes.
        ///   
        /// </Sealed_Method>

        /// Similar to sealed methods, you can mark a property as sealed to prevent derived classes from overriding or
        ///  hiding it. This ensures that the property's behavior remains consistent.
        public override sealed void print()
        {
            base.print();
        }

    }
    class TRefClass : SRefClass
    {

        //public override void print(){base.print();}   error
        // sealed method can't be override.
    }
    class Helper
    {
        ///<Generic>
        ///
        /// Generics in C# are a powerful feature that allow you to create classes, interfaces, methods, and delegates 
        ///   that work with various data types without sacrificing type safety. Generics provide the ability to define
        ///   placeholders for data types that are determined when the code is compiled. This enables you to write
        ///   reusable and type-safe code
        ///   
        ///</Generic>

        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        ///<Generic_Method>
        ///
        /// You can define generic methods within non-generic classes. These methods use type parameters to work with a
        ///  variety of data types.
        ///
        ///</Generic_Method>

        public static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
    class Helper2<T>
        // We could add some constrains in type T to use it.
        where T : 
        //class
        // primary constrains 
        // zero or one.
        // T must be class.
        // After adding this constrans i could use null and == operator with Type T.
        //struct 
        // T must be struct
        // After adding this struct i could use T x = new T(); so type T will have default parameterless constructor.

        //Point
        // General constrains when we use a constrains of name of class or struct.
        // T must be Point or point child.
        IComparable<T>
        // Secodary constrains
        // Implementing interfaces
        // After adding this constrains i could use the function compareTo in the Icomparable interface with T.
        // T must be classed or struct that implement Icomparable interface.

        //new()
        // This constrains make T must be data Type having parameterless constructor.
        // can't use new() constrains with struct as it all new by default in struct.

    {
        /// <Generic_class>
        /// 
        /// You can create generic classes by defining type parameters within angle brackets (<>). 
        /// These type parameters serve as placeholders for the actual data types that will be used when creating 
        ///   instances of the class.
        /// 
        /// </Generic_class>

        // To know why we can't use generic all the time in all classes and methods let's see the following examples:
        // The first problem that will face you is the function that accept parametr of type T when we use this function 
        //  we may pass any type of data to it like int or double or even refernce type like class or string at this time
        //  we will find that not all the operation could be execute in both value type parameter and refernce type
        //  paramerter
        // There are some operation that can be happen with any data type in .net. let's see them.
        public Helper2()
        {
            // valid for any type parameter T in .net
            // 1. Declare variable or object.
            T X;
            T Y;

            // 2. Initialization by default.
            X = default;

            // 3. Assignment operator
            Y = X;

            // 4. return statment. 
            // T myFun() { return X = default;}

            // 5. dealing with System.Object
            object o1 = X;
            if (X.Equals(Y)) ;
            int R = X?.GetHashCode() ?? 0;
            string st = X.ToString();
            if (X?.GetType() == Y?.GetType()) ;
            



            // Not valid for any type parameter T.
            // X = 0;   As not all data type in .net could be initalized to zero. it just work with value type.
            // Y = null;   As not all data type in .net could be initalized to null. it just work with refernce type.
            // X = new T(); As not all constructor have parameterless constructor.

        }
        // this funcion can't be used as generic as there is no way to use arithmatic operator with type T.
        //public static T sum(T x, T y) { return x + y; }
        public static void BSort(T[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
                for (int j = 0; j < arr?.Length - i - 1; j++)
                    // if (arr[j + 1] < arr[j]) // can't be used as it is not valid for all data type.
                    if (arr[j + 1].CompareTo(arr[j]) < 0)
                        swap(ref arr[j], ref arr[j + 1]);
                
        }
        public int SearchArray(T[] arr, T value)
        {
            foreach (T i in arr)
                //if (i  == value) // can't be used as it is not valid to all data type.
                if (i .Equals( value))
                    return Array.IndexOf(arr, i); 
            return -1;
        }
        public static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }


    /// <Pointer_To_Function>
    /// 1. Delegate datatype declartion.
    ///   delegate is declared in the namespace scope like class and struct.
    ///   The signature of the deleget must be the same signature of the method which it poit to.
    ///      like if the function return boolean then the delegate must return boolean and if it accepts two
    ///      parameters then the delegate must accept two parameters.
    /// </Pointer_To_Function>
    public delegate bool CompFunDelegate(int L, int R);
    // New delegate dataType(class), any object from this delegate DataType can point to(hold address) any 
    //   function with the exact signature. bool(int, int)
    // Can point to any function(static, object), regardless of function name, or access modifier.
    class SortingAlgorathm
    {
        // Each time we use Bsort function we have to call CompFunction.ComGer 
        public static void Bsort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
                for(int j = 0; j < arr.Length- i - 1; j++)
                    if (CompFunction.ComGer(arr[j], arr[j+1]))
                        swap(ref arr[j], ref arr[j + 1]); 

        }
        public static void Bsort(int[] arr, CompFunDelegate CompFunPtr/*Pointer to ComFunction*/ )
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (CompFunPtr?.Invoke(arr[j], arr[j + 1]) == true)
                        // Invoke call CompFunction using pointer.
                        swap(ref arr[j], ref arr[j + 1]);

        }
        public static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y; y = temp;
        }
    }
    class CompFunction
    {
        public static bool ComGer(int x, int y) { return x > y ? true : false; }
        public static bool ComLes(int x, int y) { return x < y ? true : false; }
    }
    //step 0. Delegate data type declarion.
    public delegate int strFunDelegate(string str);
    class StringFunctions
    {
        public char ch { get; set; }
        public static int getLength(string str) { return str?.Length ?? -1; }
        public int getChNum(string str)
        {
            int counter = 0;
            for (int i = 0; i < str?.Length; i++)
                if (str[i] == ch)
                    counter++;
            return counter;
        }
        public static int fullNameLength(string fName, string lName) { return fName.Length + lName.Length; }
        public static int getUpCah(string str)
        {
            int counter = 0;
            for (int i = 0; i < str?.Length; i++)
                if (char.IsUpper(str[i]))
                    counter++;
            return counter;

        }
    }
    //--------------------------------------------------------------------------------------//
    //Delegate with Generic
    public delegate bool strFunDelegate<T>(T x);
    public delegate T strFunDelegate2<T>(T x);
    class CondFuctions
    {
        public static bool ComGer(int x, int y) { return x > y ? true : false; }
        public static bool ComLes(int x, int y) { return x < y ? true : false; }
        public static bool checklength(string str) { return str.Length > 4; }
        public static bool CEven(int ints) { return ints % 2 == 0; }
        public static bool COdd(int ints) { return ints % 2 == 1; }
        public static int getAbs(int n) { return Math.Abs(n); }
        public static void print(string s) { Console.WriteLine(s); }


    } 
    class usingCondition
    {
        public static List<T> findCondition<T>(List<T> list, strFunDelegate<T> con)
        {
            List<T> newLst = new List<T>();
            for (int i = 0; i < list?.Count; i++)
                if (con?.Invoke(list[i]) == true)
                    newLst.Add(list[i]);
            return newLst;  
            
        }
        
    }

    /// <Built_In_Delegate>
    /// 
    /// There are some built in delegate that we could use instead of make our own delegate:
    /// In C#, there are several built-in delegate types provided by the .NET Framework, which are part of the
    ///   System and System.
    /// Delegate namespaces. These delegate types simplify common scenarios for delegate usage. 
    /// Here are some of the most commonly used built-in delegate types:
    /// 
    /// 1.Action:
    ///   Represents a delegate that has no return value (void).
    ///   Used for methods that perform an action but don't return a value.
    ///   Can accept up to 16 parameters (overloads available).
    ///   example:
    ///   Action<string> printMessage = (message) => Console.WriteLine(message);
    ///   printMessage("Hello, World!");
    /// 
    /// 2.Func:
    ///   Represents a delegate that takes parameters and returns a value.
    ///   Used for methods that return a value.
    ///   Can accept up to 16 parameters (overloads available).
    ///   example:
    ///   Func<int, int, int> add = (x, y) => x + y;
    ///   int result = add(3, 4); // 7
    ///   
    /// 3.Predicate:
    ///   Represents a delegate that defines a method that takes one parameter and returns a boolean value.
    ///   Commonly used for filtering collections.
    ///   example:
    ///   Predicate<int> isEven = (x) => x % 2 == 0;
    ///   bool even = isEven(6); // true
    ///   
    /// 
    /// 4.Comparison:
    ///   Represents a delegate that compares two objects of the same type.
    ///   Useful for custom sorting or ordering of objects.
    ///   example:
    ///   Comparison<string> stringComparison = (x, y) => x.CompareTo(y);
    ///   int result = stringComparison("apple", "banana"); // < 0
    ///   
    /// 5.Converter:
    ///   Represents a delegate that converts one type to another.
    ///   Often used when converting elements in collections.
    ///   example:
    ///   Converter<int, string> intToString = (x) => x.ToString();
    ///   string text = intToString(42); // "42"
    ///      
    /// </Built_In_Delegate>

    // Predicate<T>:
    //  we could use predicate delegate without declaration.
    class usingCondition2
    {
        public static List<T> findCondition<T>(List<T> list, Predicate<T> con)
        {
            List<T> newLst = new List<T>();
            for (int i = 0; i < list?.Count; i++)
                if (con?.Invoke(list[i]) == true)
                    newLst.Add(list[i]);
            return newLst;

        }

    }

    //<Using lambda expression with tradnainal methods>
    class point3D
    {
        int x, y, z;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }
        public string ReadOnlyProp => "Mahmoud";

        public point3D() => Console.WriteLine("parameterless Ctor");
        public override string ToString() => $" x: {x},  y: {y},  z: {y}";
    }

    ///<Event>
    ///</Event>
    class Ball
    {
        public int Id { get; set; }

        Location ballLocation;
        internal Location BallLocation
        {
            get => ballLocation;
            set
            {
                if (ballLocation != value)
                {
                    ballLocation = value;
                    //4. notify subc.
                    BallLocationChanged?.Invoke();
                }
            }
        }
        //1. Declare an event
        public event Action BallLocationChanged;
        public override string ToString()
        => $"Ball {Id} @ {ballLocation}";
    }
    struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public override string ToString()
        {
            return $"{X}, {Y}, {Z}";
        }
        public static bool operator == (Location l, Location R)
                => l.X == R.X && l.Y == R.Y && l.Z == R.Z;
        public static bool operator != (Location l, Location R)
                =>  l.X != R.X || l.Y != R.Y || l.Z != R.Z;
    }
    // 1. subsc
    class Player
    {
        public string Name { get; set; }
        public string Team { get; set; }

        // This subscriber must declare call back method that match the same signuture of event
        public void Run()
            => Console.WriteLine($"player {Name} running");
        public override string ToString()
        => $"name {Name}, Team {Team}";
    }
    
    // subsc no.2
    class Refree
    {
        public string Name { get; set; }
        // declare call back method 
        public void Look() => Console.WriteLine($"refree {Name} looking");
        public override string ToString() => Name;
    }
}