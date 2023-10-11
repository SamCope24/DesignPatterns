namespace DesignPatterns.Bridge.Before;

public class EmailNotificationSender : EmailNotificationProcessor
{
    public override void ProcessNotification(string message)
    {
        base.ProcessNotification(message);
        System.Console.WriteLine($"Email: {notificationMessage}");
    }
}