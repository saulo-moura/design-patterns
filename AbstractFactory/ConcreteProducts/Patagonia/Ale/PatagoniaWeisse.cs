using AbstractFactory.AbstractProducts.Ale;

namespace AbstractFactory.ConcreteProducts.Patagonia.Ale
{
    public class PatagoniaWeisse : IWeizen
    {
        public PatagoniaWeisse() : base("Patagonia Weisse", 4.4, 10) { }
    }
}
