using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class BankAccount
    {
        public int accountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime DateOpened { get; set; }
        public string AccountType { get; set; }

        void Open() { }
        void Close() { }
        void Deposit() { }
        void Withdraw() { }
    }
    // Parent class
    class Animal
    {
        string Name { get; set; }
        public virtual void Eat()
        {
            //TasteFoodInMouth();
            //SendFoodDownFoodPipe();
            //SendToIntestines();
            //ProcessFoodsInAcidicStomach();
            //SendProcessedSubstanceToExcertorySystem();
            //DisposeOfFood();
            Console.WriteLine("Eating");
        }
    }
   
    // Child class
    class Platypus : Animal
    {
        void LayEggs()
        {
            Console.WriteLine("Laying eggs");
        }
    }
    class AnimalThatCantEat : Animal
    {
        public override void Eat()
        {
            throw new Exception("Can't eat");
        }
    }
}
