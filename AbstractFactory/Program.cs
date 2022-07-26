using AbstractFactory;
using AbstractFactory.ConcreteFactories;

var factory = new PatagoniaFactory();

Client.LagerBeers(factory);
Client.AleBeers(factory);
