using System;
using DesignPatternsConsole.Models.Memento;

namespace DesignPatternsConsole.Logic.Behavioral
{
    public class MementoPattern
    {
        public void RunExample()
        {
            Originator originator = new Originator
            {
                LedTv = new LedTv("42 inch", "60000Rs", false)
            };

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());
            originator.LedTv = new LedTv("46 inch", "80000Rs", true);
            caretaker.AddMemento(originator.CreateMemento());
            originator.LedTv = new LedTv("50 inch", "100000Rs", true);

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.WriteLine("\nOriginator restoring to 42 inch LED TV");
            originator.LedTv = caretaker.GetMemento(0).LedTv;
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
        }
    }
}
