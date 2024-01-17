using System.Runtime.InteropServices;

namespace ApstraktnaTvornicaPrimjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory trgovinadisplayima = new DisplayFactory();
            Factory trgovinatelevizorima = new TvFactory();
            App aplikacijatrgovine = new App(trgovinatelevizorima,trgovinadisplayima);
            aplikacijatrgovine.SellSamsungTV();

        }

        public class App
        {
            //radio sam 2 instance factory da može biti moguće i televizore i displaya(nepotrebno)
            Factory factory;
            Factory factory2;


            public App(Factory factory,Factory facotory2)
            {
                this.factory = factory;
                this.factory2 = facotory2;
            }



            public void SellDellTV()
            {
                Dell televizor=factory.CreateDell();
                televizor.UseDell();
            }
            public void SellDellDisplay()
            {
                Dell display = factory2.CreateDell();
                display.UseDell();
            }
            public void SellSamsungTV()
            {
                Samsung televizor2 = factory.CreateSamsung();
                televizor2.UseSamsung();
            }
            public void SellSamsungDisplay()
            {
                Samsung display2 = factory2.CreateSamsung();
                display2.UseSamsung();
            }
        }
    }

    // SRP-klasa app koristi samo tvornice koje su joj potrebne za tv i displaye umjesto da instancira sve posbno
    // OCP-Mozemo dodavati jos obitelji proizvoda bez da mijenjamo kod u app-u
    // DIP-klase ovise o apstrakcijama Samsun i Dell
    // ISP-Samsung i Dell su odvojeni
    // LSP-Konkretne klase Factory su zamjenjive(TvFactory i DisplyFactory)

}

