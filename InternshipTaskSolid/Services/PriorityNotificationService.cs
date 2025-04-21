using InternshipTaskSolid.Channels;
using InternshipTaskSolid.Notifications;
using InternshipTaskSolid.Senders;

namespace InternshipTaskSolid.Services;

public class EnhancedNotificationService(NotificationService notificationService) : INotificationSender
{
    public void SendNotification(Notification notification, NotificationChannelType channelType)
    {
        var priorityPrefix = notification.Priority switch
        {
            NotificationPriority.High => "[HIGH] ",
            NotificationPriority.Critical => "[URGENT] ",
            _ => string.Empty
        };

        notificationService.Send(
            notification.Recipient,
            priorityPrefix + notification.Subject,
            notification.Message,
            channelType
        );
    }
}