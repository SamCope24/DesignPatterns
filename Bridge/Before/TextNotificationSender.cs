namespace DesignPatterns.Bridge.Before;

public class TextNotificationSender : TextNotificationProcessor
{
    public override void ProcessNotification(string message)
    {
        base.ProcessNotification(message);
        System.Console.WriteLine($"Text: {notificationMessage}");
    }
}