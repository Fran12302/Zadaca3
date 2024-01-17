namespace ApstraktnaTvornicaPrimjer
{
    public class DisplayFactory : Factory
    {
        public override Samsung CreateSamsung()
        {
            return new SamsungDisplay();
        }

        public override Dell CreateDell()
        {
            return new DellDisplay();
        }
    }




}