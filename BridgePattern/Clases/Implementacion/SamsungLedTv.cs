using System;
using BridgePattern.Interface;

namespace BridgePattern.Clases
{
    public class SamsungLedTv :IAccionesControlRemoto
    {
        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Samsung TV");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Samsung TV");
        }
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Samsung TV");
        }

    }
}