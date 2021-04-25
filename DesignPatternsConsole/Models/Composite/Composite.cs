using System;
using System.Collections.Generic;

namespace DesignPatternsConsole.Models.Composite
{
    public class Composite : IComponent
    {
        private string Name { get; set; }
        
        private readonly List<IComponent> components = new List<IComponent>();
        
        public Composite(string name)
        {
            this.Name = name;
        }

        public void AddComponent(IComponent component) => components.Add(component);

        public void DisplayPrice()
        {
            Console.WriteLine(Name);
            
            foreach (var item in components)
            {
                item.DisplayPrice();
            }
        }
    }
}
