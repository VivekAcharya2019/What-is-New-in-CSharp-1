﻿using System;

using static System.Console;

namespace Using_Statements_for_Static_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine($"This is the nameof operator in action: {nameof(Program)}");
        }
    }
}
