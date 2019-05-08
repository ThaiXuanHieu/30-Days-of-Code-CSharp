using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        
        // Declare second integer, double, and String variables.
        int intNumber;
        double doubleNumber;
        String str;
        // Read and save an integer, double, and String to your variables.
        intNumber = Convert.ToInt32(Console.ReadLine());
        doubleNumber = Convert.ToDouble(Console.ReadLine());
        str = Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + intNumber);
        // Print the sum of the double variables on a new line.
        Console.WriteLine(String.Format("{0:0.0}", d + doubleNumber));
        // Concatenate and print the String variables on a new line
        // The 's' variable above should be printed first.
        Console.WriteLine(s + str);
    }
}