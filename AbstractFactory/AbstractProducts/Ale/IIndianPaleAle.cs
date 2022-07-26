using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    public abstract class IIndianPaleAle : IBeer
    {
        protected IIndianPaleAle(string name, double abv, int ibu) : base(name, abv, ibu) { }
    }
}
