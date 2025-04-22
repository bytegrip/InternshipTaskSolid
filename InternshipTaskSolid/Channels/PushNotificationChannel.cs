using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Users;

namespace InternshipTaskSolid.Channels;

public class PushNotificationChannel : INotificationChannel
{
    public NotificationType ChannelType => NotificationType.Push;

    public void Send(Notification notification, User user)
    {
        Console.WriteLine($"PUSH to device {user.DeviceToken}:");
        Console.WriteLine($"{notification.FormatTitle}: {notification.FormatContent}");
        Console.WriteLine();
    }
}
