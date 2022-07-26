using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractProducts.Lager
{
    public abstract class IPilsen : IBeer
    {
        protected IPilsen(string name, double abv, int ibu) : base(name, abv, ibu) { }
    }
}
