namespace InternshipTaskSolid.Notifications;

public class PriorityNotification(string title, string content, NotificationPriority priority)
    : Notification(title, content)
{
    private NotificationPriority Priority { get; } = priority;
    
    public override string FormatTitle => $"{Priority}: {Title}";
    public override string FormatContent => $"{Content}";
}