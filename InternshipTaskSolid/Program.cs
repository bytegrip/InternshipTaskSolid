using InternshipTaskSolid.Channels;
using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Services;
using InternshipTaskSolid.Users;

var notificationService = new NotificationService();
notificationService.AddChannel(new EmailNotificationChannel());
notificationService.AddChannel(new SmsNotificationChannel());
notificationService.AddChannel(new PushNotificationChannel());

var user1 = new User(1, "John", "john@example.com", "+1234567890", "device123");
var user2 = new User(2, "Alice", "alice@example.com", "+9876543210", "device456");

Console.WriteLine("Sending notifications to users...\n");
            
var message1 = new TextNotification("Hello John!", "This is a test message");
notificationService.SendNotification(message1, user1, NotificationType.Email);
            
var message2 = new TextNotification("New message from Bob", "Hey Alice, how are you?");
notificationService.SendNotification(message2, user2, NotificationType.Sms);
            
var message3 = new PriorityNotification("Meeting Reminder", "Team meeting in 15 minutes", NotificationPriority.High);
notificationService.SendNotification(message3, user1, NotificationType.Push);
            
Console.WriteLine("\nSending to all available channels:");
notificationService.SendToAllChannels(message3, user2);
            
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();