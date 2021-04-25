namespace DesignPatternsConsole.Models.Bridge
{
    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILedTv ledTv) : base(ledTv)
        {
        }

        public override void SwitchOn() => ledTv.SwitchOn();
        public override void SwitchOff() => ledTv.SwitchOff();
        public override void SetChannel(int channelNumber) => ledTv.SetChannel(channelNumber);
    }
}
