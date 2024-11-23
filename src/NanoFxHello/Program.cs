using System;
using System.Diagnostics;
using System.Threading;
using System.Device.Gpio;

namespace NanoFxHello
{
    public class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Hello from nanoFramework!");

            LEDon();

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }

        private static GpioController _gpio;
        private static void LEDon()
        {
            // This code is rubish.. but it works and I'm just looking for a feedback loop. 
            // Time to refactor! 
            _gpio = new GpioController();
            GpioPin led = _gpio.OpenPin(2, PinMode.Output);
            led.Write(PinValue.Low);
            while (true)
            {
                // One
                led.Write(PinValue.High);
                Thread.Sleep(1000);
                led.Write(PinValue.Low);
                Thread.Sleep(1000);

                // Two
                led.Write(PinValue.High);
                Thread.Sleep(1000);
                led.Write(PinValue.Low);
                Thread.Sleep(1000);
    
                // Three
                led.Write(PinValue.High);
                Thread.Sleep(1000);
                led.Write(PinValue.Low);
                Thread.Sleep(3000);
            }   
        }
    }
}
