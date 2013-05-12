using Gadgeteer;
using Microsoft.SPOT;

using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using Gadgeteer.Modules.GHIElectronics;

namespace ClapOnClapOff
{
    public partial class Program
    {
        private Light _light;
        
        void ProgramStarted()
        {
            Initialise();
            Debug.Print("Program Started");

            button.ButtonPressed += button_ButtonPressed;
        }

        private void Initialise()
        {
            _light = new Light();
        }

        void button_ButtonPressed(Button sender, Button.ButtonState state)
        {            
            if (_light.IsOn)
            {
                multicolorLed.TurnOff();
                _light.TurnOff();
            }
            else
            {
                multicolorLed.TurnBlue();
                _light.TurnOn();
            }
        }
    }
}
