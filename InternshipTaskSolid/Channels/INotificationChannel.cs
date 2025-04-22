using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Users;

namespace InternshipTaskSolid.Channels;

public interface INotificationChannel
{
    NotificationType ChannelType { get; }
    void Send(Notification notification, User user);
}