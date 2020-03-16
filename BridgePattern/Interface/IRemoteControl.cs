using System.Diagnostics;

namespace BridgePattern.Interface
{
    public interface IRemoteControl
    {
       void SwitchOn();

       void SwitchOff();

       void SetChannel(int channelNumber);
    }
}