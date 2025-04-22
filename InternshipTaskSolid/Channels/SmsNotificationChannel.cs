using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Users;

namespace InternshipTaskSolid.Channels;

public class SmsNotificationChannel : INotificationChannel
{
    public NotificationType ChannelType => NotificationType.Sms;

    public void Send(Notification notification, User user)
    {
        Console.WriteLine($"SMS to {user.PhoneNumber}:");
        Console.WriteLine($"{notification.FormatTitle}: {notification.FormatContent}");
        Console.WriteLine();
    }
}