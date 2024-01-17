namespace ApstraktnaTvornicaPrimjer
{
    public class TvFactory : Factory
    {
        public override Samsung CreateSamsung()
        {
            return new SamsungTV();
        }

        public override Dell CreateDell()
        {
            return new DellTV();
        }
    }




}