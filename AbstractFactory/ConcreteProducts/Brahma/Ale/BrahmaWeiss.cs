using AbstractFactory.AbstractProducts.Ale;

namespace AbstractFactory.Brahma.Ale
{
    public class BrahmaWeiss : IWeizen
    {
        public BrahmaWeiss() : base("Brahma Extra Weiss", 4.9, 14) { }
    }
}
