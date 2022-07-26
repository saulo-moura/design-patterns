using AbstractFactory.AbstractProducts.Ale;

namespace AbstractFactory.Interfaces.Factories
{
    public interface IAleFactory
    {
        public IWeizen CreateWeizenBeer();
        public IIndianPaleAle CreateIPABeer();
    }
}
