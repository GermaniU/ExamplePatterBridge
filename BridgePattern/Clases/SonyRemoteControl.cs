using BridgePattern.Interface;

namespace BridgePattern.Clases
{
    public class SonyRemoteControl : IRemoteControl
    {
        public IAccionesControlRemoto AccionesControlRemoto;

        public SonyRemoteControl(IAccionesControlRemoto accionesControlRemoto)
        {
            AccionesControlRemoto = accionesControlRemoto;
        }

        public  void SwitchOn()
        {
            AccionesControlRemoto.SwitchOn();
        }

        public  void SwitchOff()
        {
            AccionesControlRemoto.SwitchOff();
        }

        public  void SetChannel(int channelNumber)
        {
            AccionesControlRemoto.SetChannel(channelNumber);
        }
    }
}