namespace DesignPatterns.Bridge.After;

public class TextNotificationSender : INotificationSender
{
    public void SendNotification(string message)
    {
        System.Console.WriteLine($"Text: {message}");
    }
}