namespace DesignPatternsConsole.Models.Bridge
{
    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILedTv ledTv) : base(ledTv)
        {
        }

        public override void SwitchOn() => ledTv.SwitchOn();
        public override void SwitchOff() => ledTv.SwitchOff();
        public override void SetChannel(int channelNumber) => ledTv.SetChannel(channelNumber);
    }
}
