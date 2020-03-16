using System;
using BridgePattern.Interface;

namespace BridgePattern.Clases
{
    public class SamsungRemoteControl : IAccionesControlRemoto
        /*AbstractRemoteControl*/
    {
        private readonly IAccionesControlRemoto accionesControlRemoto;

        public SamsungRemoteControl(IAccionesControlRemoto accionesControlRemoto)
        {
            this.accionesControlRemoto =
                accionesControlRemoto ?? throw new ArgumentNullException(nameof(accionesControlRemoto));
        }

        public  void SwitchOn()
        {
            accionesControlRemoto.SwitchOn();
        }

        public  void SwitchOff()
        {
            accionesControlRemoto.SwitchOff();
        }

        public  void SetChannel(int channelNumber)
        {
            accionesControlRemoto.SetChannel(channelNumber);
        }
    }
}