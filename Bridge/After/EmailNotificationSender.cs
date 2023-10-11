namespace DesignPatterns.Bridge.After;

public class EmailNotificationSender : INotificationSender
{
    public void SendNotification(string message)
    {
        System.Console.WriteLine($"Email: {message}");
    }
}