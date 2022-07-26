using AbstractFactory.AbstractProducts.Lager;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Interfaces.Factories
{
    public interface ILagerFactory
    {
        IPilsen CreatePilsenBeer();
        IAmberLager CreateAmberLagerBeer();
    }
}
