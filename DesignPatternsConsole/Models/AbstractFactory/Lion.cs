﻿namespace DesignPatternsConsole.Models.AbstractFactory
{
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
}
