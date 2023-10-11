using DesignPatterns.Bridge.After;

INotificationProcessor text = new TextNotificationProcessor(new TextNotificationSender());
INotificationProcessor email = new EmailNotificationProcessor(new EmailNotificationSender());

text.ProcessNotification("Hello world");
email.ProcessNotification("Hello World");