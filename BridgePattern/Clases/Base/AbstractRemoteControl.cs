using BridgePattern.Interface;

namespace BridgePattern.Clases
{
    ///Favorecer la composición a la herencia, esta clase abstracta puede ser sustituida por una interface;
    public abstract class AbstractRemoteControl
    {
        protected IAccionesControlRemoto ledTv;
        protected AbstractRemoteControl(IAccionesControlRemoto ledTv)
        {
            this.ledTv = ledTv;
        }
        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);

    }
}