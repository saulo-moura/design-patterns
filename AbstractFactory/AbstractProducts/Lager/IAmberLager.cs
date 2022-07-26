using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractProducts.Lager
{
    public abstract class IAmberLager : IBeer
    {
        protected IAmberLager(string name, double abv, int ibu) : base(name, abv, ibu) { }
    }
}
