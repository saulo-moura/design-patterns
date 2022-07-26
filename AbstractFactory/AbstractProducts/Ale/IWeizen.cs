using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractProducts.Ale
{
    public abstract class IWeizen : IBeer
    {
        protected IWeizen(string name, double ibv, int ibu) : base(name, ibv, ibu) { }
    }
}
