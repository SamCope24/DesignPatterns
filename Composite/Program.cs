using DesignPatterns.Composite;

var databaseCommandHandler = new DatabaseCommandHandler();
var fileCommandHandler = new FileCommandHandler();
var messageCommandHandler = new MessageCommandHandler();
var commandHandlers = new List<ICommandHandler<Command>> { databaseCommandHandler, fileCommandHandler, messageCommandHandler };

var command = new Command("Do Something");

// await databaseCommandHandler.ExecuteCommand(command);
// await fileCommandHandler.ExecuteCommand(command);
// await messageCommandHandler.ExecuteCommand(command);

var chainCommandHandler = new ChainCommandHandler(commandHandlers);
await chainCommandHandler.ExecuteCommand(command);