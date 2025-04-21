namespace InternshipTaskSolid.Channels;

public class SmsNotificationChannel : INotificationChannel
{
    public NotificationChannelType ChannelType => NotificationChannelType.Sms;

    public void Send(string recipient, string subject, string message)
    {
        Console.WriteLine($"Sending SMS to {recipient}");
        Console.WriteLine($"Message: {subject} - {message}");
        Console.WriteLine("SMS sent successfully!");
    }
}