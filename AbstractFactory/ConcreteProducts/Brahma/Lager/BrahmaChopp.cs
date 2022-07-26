using AbstractFactory.AbstractProducts.Lager;

namespace AbstractFactory.Brahma.Lager
{
    public class BrahmaChopp : IPilsen
    {
        public BrahmaChopp() : base("Brahma Chopp", 4.8, 10) { }
    }
}
