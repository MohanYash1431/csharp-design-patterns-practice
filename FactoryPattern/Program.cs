using FactoryPattern;

var notificationService = new NotificationService();

notificationService.SendNotification(
    "SMS", "A new inspection has been assigned.");

notificationService.SendNotification(
    "Slack", "Inspection completed successfully.");