namespace DesignPatterns.Bridge.Before;

public class EmailNotificationProcessor : NotificationProcessor
{
    protected string notificationMessage = string.Empty;

    public override void ProcessNotification(string message) 
    {
        notificationMessage = $"<html>{message}</html>";
    }
}