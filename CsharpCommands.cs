// This importing of the System nameSpace to use all classes in it.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

/* In C sharp we could use a static using to import any class as a static so we could use all the methods
    in this class without writing all the pass of the mehtod like when we use a System.Console class
    as  a static class so we could call the method wirteLine and write without calling the System.Console 
    by just write down the name of the method.
*/
using static System.Console;
namespace CSharpCommands
{
    internal class CsharpCommands
    {
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

            //----------------------------------------------------------------------------------------------------//
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
            // C# is pass by reference or value language not like java whic is pass by value only.
            // In swapByValue method we pass by value here so when we pass any data to this method, we just pass copy of 
            //    this data not the original data.
            int firstNumberToSwap = 10, secondNumberToSwap = 20;
            swapByValue(firstNumberToSwap, secondNumberToSwap);
            Console.WriteLine($"firstNumberToSwap: {firstNumberToSwap},  secondNumberToSwap: {secondNumberToSwap}");
            //firstNumberToSwap: 10,  secondNumberToSwap: 20
            // the original values for variable didn't change as the passign was by value 

            // we could modify the function to make passing by reference like in swapByReference function.
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
            // As we know reference type store in heap and when we pass a reference type this mean we don't creat 
            //     new object, but we just refere to the exisist object by a new name.
            // Conseder that we have a method that sum vlaues inside int array which accept int array.
            int[] arrayToBeSum = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Console.WriteLine(sumArray(arrayToBeSum));// 91
            /*
              * static int sumArray(int[] array)
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
             * Any changes made to the reference inside the method will modify the original reference outside the method.
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
            // passing vlue or reference by reference : read and write.
            //-------------------------------------------------------------------------------------------------//
            ///Passing by out:
            ///passing value by value : read only, and passing vlue or reference by reference : read and write.
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

            //--------------------------------------------------------------------------------------------------------------//
             





        }// End of main



        // In this method printLine which accept two parameters we put a default values for paramters that be accepted 
        //     this mean we could call this method without passing any data to it at this time the complier will use default values
        //     but if we pass any data then the passed data will be used.
        // Also we could pass data in different order, but in this time we have to write the name of parameter then : then value.
        //Also we could pass just one of parameters not all parameters.
        public static void printLine(int n = 5, String output = " * ")
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

        static void sumAndMultiply (int n1,  int n2, out int sum, out int mulitply)
        {
            //Note: When using out, you must assign a value to all out parameters within the method before it returns.
            sum = n1 + n2;
            mulitply = n1 * n2;
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
}