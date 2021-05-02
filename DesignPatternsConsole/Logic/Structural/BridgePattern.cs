using System;
using DesignPatternsConsole.Models.Bridge;

namespace DesignPatternsConsole.Logic.Structural
{
    public class BridgePattern : IPattern
    {
        public void RunExample()
        {
            SonyRemoteControl sonyRemoteControl = new SonyRemoteControl(new SonyLedTv());
            sonyRemoteControl.SwitchOn();
            sonyRemoteControl.SetChannel(2);
            sonyRemoteControl.SwitchOff();

            Console.WriteLine();
            SamsungRemoteControl samsungRemoteControl = new SamsungRemoteControl(new SamsungLedTv());
            samsungRemoteControl.SwitchOn();
            samsungRemoteControl.SetChannel(9);
            samsungRemoteControl.SwitchOff();
        }
    }
}
