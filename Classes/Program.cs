using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's yo name?");
            string myName = Console.ReadLine();
            Person randomPerson = new Person(myName);
            randomPerson.SayMyName();
            Console.ReadLine();
        }
    }
    // Class Declaration
    // To create a specific person, you create an instance of the class
    class Person
    {
        readonly string _myName;
        // Getters and Setters TBD

        // public name-of-the-class
        public Person(string name)
        {
            _myName = name;
        }
        // Method declaration
        // access-modifier return-type name (parameters) 
        // (argument1, argument2)
        
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public void SayMyName()
        {
            Console.WriteLine(_myName.ToLower());
        }
    }
}
