using DesignPatterns.Adapter;

var database = new Database();
var adapter = new DatabaseAccessAdapter<Database>(database);
var query = new Query<Database>(adapter);
var command = new Command<Database>(adapter);
