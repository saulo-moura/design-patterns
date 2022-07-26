using AbstractFactory.AbstractProducts.Ale;
using AbstractFactory.AbstractProducts.Lager;
using AbstractFactory.ConcreteProducts.Patagonia.Ale;
using AbstractFactory.ConcreteProducts.Patagonia.Lager;
using AbstractFactory.Interfaces.Factories;

namespace AbstractFactory.ConcreteFactories
{
    public class PatagoniaFactory : IAleFactory, ILagerFactory
    {
        public IAmberLager CreateAmberLagerBeer()
        {
            return new PatagoniaAmberLager();
        }

        public IIndianPaleAle CreateIPABeer()
        {
            return new PatagoniaIPA();
        }

        public IPilsen CreatePilsenBeer()
        {
            return new PatagoniaBohemianPilsener();
        }

        public IWeizen CreateWeizenBeer()
        {
            return new PatagoniaWeisse();
        }
    }
}
