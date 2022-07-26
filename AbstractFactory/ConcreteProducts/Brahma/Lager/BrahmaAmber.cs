using AbstractFactory.AbstractProducts.Lager;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Brahma.Lager
{
    public class BrahmaAmber : IAmberLager
    {
        public BrahmaAmber() : base("Brahma Extra Red Lager", 5.2, 10) { }
    }
}
