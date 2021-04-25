namespace DesignPatternsConsole.Models.Bridge
{
    public abstract class AbstractRemoteControl
    {
        protected ILedTv ledTv;

        protected AbstractRemoteControl(ILedTv ledTv)
        {
            this.ledTv = ledTv;
        }

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }
}
