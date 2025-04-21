namespace InternshipTaskSolid.Notifications;

public class Notification(
    string recipient,
    string subject,
    string message,
    NotificationPriority priority = NotificationPriority.Normal)
{
    public string Recipient { get; set; } = recipient;
    public string Subject { get; set; } = subject;
    public string Message { get; set; } = message;
    public NotificationPriority Priority { get; set; } = priority;
    public DateTime CreatedAt { get; private set; } = DateTime.Now;
}