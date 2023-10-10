using DesignPatterns.Adapter.Characters.Adapters;
using DesignPatterns.Adapter.Characters.Concretes;
using DesignPatterns.Adapter.Characters.Interfaces;
using DesignPatterns.Adapter.Data;

var database = new Database();
var adapter = new DatabaseAccessAdapter<Database>(database);
var query = new Query<Database>(adapter);
var command = new Command<Database>(adapter);


IMoose moose = new Moose();
IBadGuy badGuy = new BadGuy();
IFlyingSquirrel flyingSquirrel = new FlyingSquirrel();

var characters = new List<ICharacter>()
{
    new MooseAdapter(moose),
    new BadGuyAdapter(badGuy),
    new FlyingSquirrelAdapter(flyingSquirrel)
};
