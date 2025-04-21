using InternshipTaskSolid.Users;

namespace InternshipTaskSolid.Notifications;

public class NotificationFactory
{
    public static Notification CreateTextNotification(User user, string message)
    {
        return new Notification(
            user.PhoneNumber,
            "New Message",
            message
        );
    }

    public static Notification CreateSystemNotification(User user, string subject, string message, NotificationPriority priority)
    {
        return new Notification(
            user.Email,
            subject,
            message,
            priority
        );
    }
}