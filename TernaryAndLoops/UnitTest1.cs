using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TernaryAndLoops
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Ternary()
        {
            int myAge = 19;

            // Ternary: Conditional statement, that executes C# based on whether the given condition is true or false 
            // (condition) ? c# if true : c# if false;
            bool isAboveLegalAge;

            isAboveLegalAge = (myAge > 20) ? true : false;

            if (myAge > 20)
            {
                isAboveLegalAge = true;
            }
            else
            {
                isAboveLegalAge = false;
            }
        }
        [TestMethod]
        public void Loops()
        {
            // Comment: ctrl+k+c
            // Uncomment: ctrl+k+u
            // control*
            // Loop: A statement that allows you to run a block of code multiple times based on a given condition

            //int counter = 0;

            //while (counter < 10)
            //{
            //    Console.WriteLine("While : " + counter);
            //    counter++;
            //}

            //do
            //{
            //    Console.WriteLine("Do while: " + counter);
            //    counter++;
            //} while (counter < 10);

            // Iteration variable | Condition | Post iteration modification
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //List<string> listOfNames = new List<string>() { "Nick", "Nicole", "Oscar", "Olivia", "Patrick", "Penelope" };

            //foreach (string name in listOfNames)
            //{
            //    Console.WriteLine(name);
            //}
        }
    }
}
