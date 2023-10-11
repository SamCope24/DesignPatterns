namespace DesignPatterns.Bridge.After;

public class EmailNotificationProcessor : INotificationProcessor
{
    private readonly INotificationSender _notificationSender;

    public EmailNotificationProcessor(INotificationSender notificationSender) =>
        _notificationSender = notificationSender ?? throw new ArgumentNullException(nameof(notificationSender));


    public void ProcessNotification(string message) 
    {
        _notificationSender.SendNotification($"<html>{message}</html>");
    }
}