using DesignPatterns.Bridge.Before;

NotificationProcessor text = new TextNotificationSender();
NotificationProcessor email = new EmailNotificationSender();

text.ProcessNotification("Hello world");
email.ProcessNotification("Hello World");

