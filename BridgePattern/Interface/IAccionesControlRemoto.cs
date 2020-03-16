namespace BridgePattern.Interface
{
    public interface IAccionesControlRemoto
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channelNumber);
    }
}