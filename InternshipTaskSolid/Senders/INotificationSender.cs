using InternshipTaskSolid.Channels;
using InternshipTaskSolid.Notifications;

namespace InternshipTaskSolid.Senders;

public interface INotificationSender
{
    void SendNotification(Notification notification);
}