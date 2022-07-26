using AbstractFactory.AbstractProducts.Ale;
using AbstractFactory.AbstractProducts.Lager;
using AbstractFactory.Brahma.Ale;
using AbstractFactory.Brahma.Lager;
using AbstractFactory.Interfaces.Factories;

namespace AbstractFactory.ConcreteFactories
{
    public class BrahmaFactory : ILagerFactory, IAleFactory
    {
        public IIndianPaleAle CreateIPABeer()
        {
            throw new NotImplementedException();
        }

        public IAmberLager CreateAmberLagerBeer()
        {
            return new BrahmaAmber();
        }

        public IPilsen CreatePilsenBeer()
        {
            return new BrahmaChopp();
        }

        public IWeizen CreateWeizenBeer()
        {
            return new BrahmaWeiss();
        }
    }
}
