using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    static void weirdOrNotWeird(int num)
    {
        if(num % 2 != 0)
            Console.WriteLine("Weird");
        else
        {
            if(num >= 2 && num <= 5)
                Console.WriteLine("Not Weird");
            if(num >= 6 && num <= 20)
                Console.WriteLine("Weird");
            if(num > 20)
                Console.WriteLine("Not Weird");
        }
    }


    static void Main(string[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
        weirdOrNotWeird(N);
    }
}
