namespace DesignPatterns.Bridge.Before;

public class TextNotificationProcessor : NotificationProcessor
{
    protected string notificationMessage = string.Empty;

    public override void ProcessNotification(string message) 
    {
        notificationMessage = message;
    }
}