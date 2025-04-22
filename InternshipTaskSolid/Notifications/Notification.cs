namespace InternshipTaskSolid.Notifications;

public abstract class Notification(string title, string content)
{
    public string Title { get; } = title;
    public string Content { get; } = content;
    public virtual string FormatTitle => Title;
    public virtual string FormatContent => $"{Content}";
}