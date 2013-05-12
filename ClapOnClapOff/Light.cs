namespace ClapOnClapOff
{
    public class Light
    {
        public bool IsOn { get; set; }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
        }
    }
}