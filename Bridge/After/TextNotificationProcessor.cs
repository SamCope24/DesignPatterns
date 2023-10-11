namespace DesignPatterns.Bridge.After;

public class TextNotificationProcessor : INotificationProcessor
{
    private readonly INotificationSender _notificationSender;

    public TextNotificationProcessor(INotificationSender notificationSender) =>
        _notificationSender = notificationSender ?? throw new ArgumentNullException(nameof(notificationSender));


    public void ProcessNotification(string message) 
    {
        _notificationSender.SendNotification(message);
    }
}