﻿
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the Gadgeteer Designer.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Gadgeteer;
using GTM = Gadgeteer.Modules;

namespace ClapOnClapOff
{
    public partial class Program : Gadgeteer.Program
    {
        // GTM.Module definitions
        Gadgeteer.Modules.GHIElectronics.UsbClientDP usbClientDP;
        Gadgeteer.Modules.GHIElectronics.LED7R led7r;
        Gadgeteer.Modules.GHIElectronics.Button button;
        Gadgeteer.Modules.GHIElectronics.MulticolorLed multicolorLed;

        public static void Main()
        {
            //Important to initialize the Mainboard first
            Mainboard = new GHIElectronics.Gadgeteer.FEZSpider();			

            Program program = new Program();
            program.InitializeModules();
            program.ProgramStarted();
            program.Run(); // Starts Dispatcher
        }

        private void InitializeModules()
        {   
            // Initialize GTM.Modules and event handlers here.		
            usbClientDP = new GTM.GHIElectronics.UsbClientDP(1);
		
            multicolorLed = new GTM.GHIElectronics.MulticolorLed(4);
		
            button = new GTM.GHIElectronics.Button(11);
		
            led7r = new GTM.GHIElectronics.LED7R(12);

        }
    }
}