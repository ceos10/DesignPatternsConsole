﻿using DesignPatternsConsole.Models.Adapter;

namespace DesignPatternsConsole.Logic.Structural
{
    public class AdapterPattern : IPattern
    {
        public void RunExample()
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new RichCompound("Water");
            water.Display();

            Compound benzene = new RichCompound("Benzene");
            benzene.Display();

            Compound ethanol = new RichCompound("Ethanol");
            ethanol.Display();
        }
    }
}
