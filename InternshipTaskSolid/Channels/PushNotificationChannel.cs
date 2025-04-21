namespace InternshipTaskSolid.Channels;

public class PushNotificationChannel : INotificationChannel
{
    public NotificationChannelType ChannelType => NotificationChannelType.Push;

    public void Send(string recipient, string subject, string message)
    {
        Console.WriteLine($"Sending Push Notification to {recipient}'s device");
        Console.WriteLine($"Title: {subject}");
        Console.WriteLine($"Body: {message}");
        Console.WriteLine("Push notification sent successfully!");
    }
}
