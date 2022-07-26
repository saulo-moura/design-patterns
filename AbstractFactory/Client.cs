using AbstractFactory.Interfaces.Factories;

namespace AbstractFactory
{
    public class Client
    {
        public static void LagerBeers(ILagerFactory lagerFactory)
        {
            var amberLager = lagerFactory.CreateAmberLagerBeer();
            var pilsen = lagerFactory.CreatePilsenBeer();

            Console.WriteLine("\nDADOS DA CERVEJA DO ESTILO AMBER LAGER");
            Console.WriteLine($"Nome - {amberLager.Name}\nABV - {amberLager.ABV:F}%\nIBU - {amberLager.IBU}\n");

            Console.WriteLine("DADOS DA CERVEJA DO ESTILO PILSEN");
            Console.WriteLine($"Nome - {pilsen.Name}\nABV - {pilsen.ABV:F}%\nIBU - {pilsen.IBU}");

        }

        public static void AleBeers(IAleFactory aleFactory)
        {
            var weizen= aleFactory.CreateWeizenBeer();
            var ipa = aleFactory.CreateIPABeer();

            Console.WriteLine("\nDADOS DA CERVEJA DO ESTILO WEIZEN");
            Console.WriteLine($"Nome - {weizen.Name}\nABV - {weizen.ABV:F}%\nIBU - {weizen.IBU}\n");

            Console.WriteLine("DADOS DA CERVEJA DO ESTILO INDIAN PALE ALE");
            Console.WriteLine($"Nome - {ipa.Name}\nABV - {ipa.ABV:F}%\nIBU - {ipa.IBU}");

        }
    }
}
