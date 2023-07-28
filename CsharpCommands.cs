// This importing of the System nameSpace to use all classes in it.
using System;

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
            // if we want to save a string in a spacific formate or to print string in a spacific formate
            // we could use formate method in String class.
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
            for(int i = 0; i < firstTwoDimensionArray.GetLength(0); i++)
                for(int j = 0; j < firstTwoDimensionArray.GetLength(1); j++)
                {
                    firstTwoDimensionArray[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }

        }
    }
}