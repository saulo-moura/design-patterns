namespace AbstractFactory.Interfaces
{
    public abstract class IBeer
    {
        public string Name { get; private set; }
        public double ABV { get; private set; }
        public int IBU { get; private set; }

        public IBeer(string name, double abv, int ibu) 
        {   
            Name = name;
            ABV = abv;
            IBU = ibu;
        }
    }
}
