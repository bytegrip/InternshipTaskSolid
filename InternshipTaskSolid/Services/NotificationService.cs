using InternshipTaskSolid.Channels;
using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Users;

namespace InternshipTaskSolid.Services;

public class NotificationService
{
    private readonly Dictionary<NotificationType, INotificationChannel> _channels = new();

    public void AddChannel(INotificationChannel channel)
    {
        _channels[channel.ChannelType] = channel;
    }

    public void SendNotification(Notification notification, User user, NotificationType type)
    {
        if (_channels.TryGetValue(type, out var channel))
        {
            channel.Send(notification, user);
        }
        else
        {
            Console.WriteLine($"No channel available for notification type: {type}");
        }
    }

    public void SendToAllChannels(Notification notification, User user)
    {
        foreach (var channel in _channels.Values)
        {
            channel.Send(notification, user);
        }
    }
}