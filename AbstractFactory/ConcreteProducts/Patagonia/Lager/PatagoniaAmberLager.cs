using AbstractFactory.AbstractProducts.Lager;

namespace AbstractFactory.ConcreteProducts.Patagonia.Lager
{
    public class PatagoniaAmberLager : IAmberLager
    {
        public PatagoniaAmberLager() : base("Patagonia Amber Lager", 4.5, 15) { }
    }
}
