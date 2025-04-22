using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Users;

namespace InternshipTaskSolid.Channels;

public class EmailNotificationChannel : INotificationChannel
{
    public NotificationType ChannelType => NotificationType.Email;

    public void Send(Notification notification, User user)
    {
        Console.WriteLine($"EMAIL to {user.Email}:");
        Console.WriteLine($"Subject: {notification.FormatTitle}");
        Console.WriteLine($"Body: {notification.FormatContent}");
        Console.WriteLine();
    }
}