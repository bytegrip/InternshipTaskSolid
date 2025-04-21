namespace InternshipTaskSolid.Channels;

public class EmailNotificationChannel : INotificationChannel
{
    public NotificationChannelType ChannelType => NotificationChannelType.Email;

    public void Send(string recipient, string subject, string message)
    {
        Console.WriteLine($"Sending Email to {recipient}");
        Console.WriteLine($"Subject: {subject}");
        Console.WriteLine($"Message: {message}");
        Console.WriteLine("Email sent successfully!");
    }
}