using InternshipTaskSolid.Channels;
using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Services;
using InternshipTaskSolid.Users;

Console.WriteLine("Notification System Demo\n");

var emailChannel = new EmailNotificationChannel();
var smsChannel = new SmsNotificationChannel();
var pushChannel = new PushNotificationChannel();

var notificationService = new NotificationService([
    emailChannel,
    smsChannel,
    pushChannel
]);

var enhancedService = new EnhancedNotificationService(notificationService);

var user1 = new User
{
    Id = "user1",
    Name = "John Doe",
    Email = "john.doe@example.com",
    PhoneNumber = "+1234567890",
};

var user2 = new User
{
    Id = "user2",
    Name = "Jane Smith",
    Email = "jane.smith@example.com",
    PhoneNumber = "+0987654321",
};

notificationService.Send(user1.Email, "Welcome", "Welcome to our messaging app!");

notificationService.Send(user1.PhoneNumber, "Login Alert", "New login detected on your account.", NotificationChannelType.Sms);

var notification = NotificationFactory.CreateSystemNotification(
    user2,
    "Security Alert",
    "Unusual activity detected on your account. Please verify.",
    NotificationPriority.Critical
);
enhancedService.SendNotification(notification, NotificationChannelType.Email);

var textNotification = NotificationFactory.CreateTextNotification(
    user1,
    "Hey, how's it going? Want to meet up later?"
);
enhancedService.SendNotification(textNotification, NotificationChannelType.Push);

Console.ReadKey();