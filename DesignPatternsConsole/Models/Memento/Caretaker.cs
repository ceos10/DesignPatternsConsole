using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.Models.Memento
{
    public class Caretaker
    {
        private readonly List<Memento> LedTvList = new List<Memento>();
        public void AddMemento(Memento memento)
        {
            LedTvList.Add(memento);
            Console.WriteLine($"LED TV's snapshots Maintained by CareTaker :{memento.GetDetails()}");
        }
        public Memento GetMemento(int index) => LedTvList[index];
    }
}
