using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5._2
{
    internal class Program
    {
        #region Format
        static void Introduction()
        {
            // HEADER
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Assignment 5.2");
            Console.WriteLine("Name: Isaac Jang\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---------------PART 1---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Transition()
        {
            // TRANSITION
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nPress any key to continue!\n");
            Console.ReadKey();
        }

        static void Part(int i)
        {
            // PART 2
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n---------------PART {i}---------------\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void ClosingMessage()
        {
            // CLOSING MESSAGE
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\nHave a great day!");
        }
        #endregion

        static void TryAgain()
        {
        TryAgain:
        StartPoint1:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint1;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain;
            }

        }

        static void Main(string[] args)
        {
            #region Part1
            Introduction(); StartPoint1:

            /*
             1. Given a string s consisting of words and spaces, return the length of the last word in the string. A word is a maximal substring consisting of non-space characters only.

            Example 1:

            Input: s = "Hello World"
            Output: 5
            Explanation: The last word is "World" with length 5.
            Example 2:

            Input: s = " fly me to the moon "
            Output: 4
            Explanation: The last word is "moon" with length 4.

             */

            Console.WriteLine("\nEnter string and I will return the length of the last word.");
            Console.Write("Enter String :");
            char[] s = Console.ReadLine().ToArray();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine(lengthOfLastWord(s));
            Console.ForegroundColor = ConsoleColor.White;

            TryAgain1:
            try
            {
                while (true)
                {
                    // ask user if they want to try again
                    Console.WriteLine("\nWant to try again? (Y / N)");
                    char answer = char.Parse(Console.ReadLine().ToUpper());

                    // wants to continue
                    if (answer == 'Y')
                    {
                        goto StartPoint1;
                    }

                    // does not want to continue
                    else if (answer == 'N')
                    {
                        break;
                    }

                    // invaid entry
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEnter valid character");
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvaild Answer Choice\n");
                Console.ForegroundColor = ConsoleColor.White;
                goto TryAgain1;
            }

            #endregion

            Transition(); Part(2); StartPoint2:

            /*
            2.Write a program in C# Sharp to print the first n natural number using recursion.
            Test Data:
            How many numbers to print: 10
            Expected Output :
            1 2 3 4 5 6 7 8 9 10*/

            Console.Write("How many numbers to print: ");
            int n = int.Parse(Console.ReadLine());

            PrintNumbersIncrease(1, n);

            //TryAgain2:
            //try
            //{
            //    while (true)
            //    {
            //        // ask user if they want to try again
            //        Console.WriteLine("\nWant to try again? (Y / N)");
            //        char answer = char.Parse(Console.ReadLine().ToUpper());

            //        // wants to continue
            //        if (answer == 'Y')
            //        {
            //            goto StartPoint2;
            //        }

            //        // does not want to continue
            //        else if (answer == 'N')
            //        {
            //            break;
            //        }

            //        // invaid entry
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("\nEnter valid character");
            //            Console.ForegroundColor = ConsoleColor.White;
            //            continue;
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("\nInvaild Answer Choice\n");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    goto TryAgain2;
            //}

            Transition(); Part(3); StartPoint3:
            /*3.Write a program in C# Sharp to print numbers from n to 1 using recursion.
            Test Data:
            How many numbers to print: 10
            Expected Output :
            10 9 8 7 6 5 4 3 2 1
            */

            Console.Write("How many numbers to print: ");
            int x = int.Parse(Console.ReadLine());

            PrintNumbersDecrease(x);

            //TryAgain3:
            //try
            //{
            //    while (true)
            //    {
            //        // ask user if they want to try again
            //        Console.WriteLine("\nWant to try again? (Y / N)");
            //        char answer = char.Parse(Console.ReadLine().ToUpper());

            //        // wants to continue
            //        if (answer == 'Y')
            //        {
            //            goto StartPoint3;
            //        }

            //        // does not want to continue
            //        else if (answer == 'N')
            //        {
            //            break;
            //        }

            //        // invaid entry
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("\nEnter valid character");
            //            Console.ForegroundColor = ConsoleColor.White;
            //            continue;
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("\nInvaild Answer Choice\n");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    goto TryAgain3;
            //}

            Transition(); Part(4); StartPoint4:
            /*
            4.Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
            Test Data:
            Input a string : RADAR
            Expected Output:
            The string is Palindrome.
            */

            Console.WriteLine("Enter a word to see if it is a Palindrome");
            Console.Write("Enter word: ");
            string userWord = Console.ReadLine().ToUpper();

            bool isPal = IsPalindrome(userWord, 0, userWord.Length - 1);

            Console.ForegroundColor = ConsoleColor.Yellow;
            if (isPal)
            {
                Console.WriteLine($"\n{userWord} is a Palindrome.");
            }
            else
            {
                Console.WriteLine($"\n{userWord} is not a Palindrome.");
            }
            Console.ForegroundColor = ConsoleColor.White;

            //TryAgain4:
            //try
            //{
            //    while (true)
            //    {
            //        // ask user if they want to try again
            //        Console.WriteLine("\nWant to try again? (Y / N)");
            //        char answer = char.Parse(Console.ReadLine().ToUpper());

            //        // wants to continue
            //        if (answer == 'Y')
            //        {
            //            goto StartPoint4;
            //        }

            //        // does not want to continue
            //        else if (answer == 'N')
            //        {
            //            break;
            //        }

            //        // invaid entry
            //        else
            //        {
            //            Console.ForegroundColor = ConsoleColor.Red;
            //            Console.WriteLine("\nEnter valid character");
            //            Console.ForegroundColor = ConsoleColor.White;
            //            continue;
            //        }
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("\nInvaild Answer Choice\n");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    goto TryAgain4;
            //}
            ClosingMessage(); Console.ReadKey();

        }

        static int lengthOfLastWord(char[] s)
        {
            int length = 0;  // Initialize a variable to store the length of the last word
            int i = s.Length - 1;  // Start from the end of the array

            // Skip any trailing spaces at the end of the array
            while (s[i] == ' ')
            {
                i--;  // Move to the previous character
            }

            // Count the length of the last word
            while (i >= 0 && s[i] != ' ')
            {
                length++;  // Increment the length for each character in the last word
                i--;  // Move to the previous character
            }

            return length;  // Return the length of the last word
        }

        static void PrintNumbersIncrease(int current, int n)
        {
            //base case
            if (current > n) {return;}

            Console.Write(current + " ");
            PrintNumbersIncrease(current + 1, n);
        }

        static void PrintNumbersDecrease(int x)
        {
            //base case
            if(x <= 0 ) { return;}

            Console.Write(x + " ");
            PrintNumbersDecrease( x - 1);
        }

        static bool IsPalindrome(string s, int begin, int end)
        {
            //Check to see if the end integer is a zero or a negative number. This tells the computer if the user's word is a single letter.
            if (begin >= end)
            {
                return true;
            }

            //Check to see if the letters at each index have the same value.
            if (s[begin] != s[end])
            {
                return false;
            }

            //Recursively call the IsPalindrome method but move one index to the right of the first half of the word and one index left of the last half of the word.
            return IsPalindrome(s, begin + 1, end - 1);
        }

    }
}
