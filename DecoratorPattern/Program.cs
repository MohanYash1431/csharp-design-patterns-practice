using DecoratorPattern;

INotification notification =
    new FormattingNotification(
        new RetryNotification(
            new SmsNotification()));

//RetryNotification retry = new RetryNotification(notification);

notification.send("Inspection assigned");