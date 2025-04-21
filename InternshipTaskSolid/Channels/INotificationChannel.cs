namespace InternshipTaskSolid.Channels;

public interface INotificationChannel
{
    void Send(string recipient, string subject, string message);
    NotificationChannelType ChannelType { get; }
}