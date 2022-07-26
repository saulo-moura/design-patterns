using AbstractFactory.AbstractProducts.Lager;

namespace AbstractFactory.ConcreteProducts.Patagonia.Lager
{
    public class PatagoniaBohemianPilsener : IPilsen
    {
        public PatagoniaBohemianPilsener() : base("Patagonia Bohemian Pilsener", 5.2, 18) { }
    }
}
