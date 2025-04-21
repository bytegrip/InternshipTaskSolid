using InternshipTaskSolid.Channels;

namespace InternshipTaskSolid.Services;

public class NotificationService(List<INotificationChannel> channels)
{
    public void AddChannel(INotificationChannel channel)
    {
        channels.Add(channel);
    }

    public void Send(string recipient, string subject, string message, NotificationChannelType? channelType = null)
    {
        if (channelType == null)
        {
            foreach (var channel in channels)
            {
                channel.Send(recipient, subject, message);
            }
        }
        else
        {
            var channel = channels.Find(c => c.ChannelType == channelType);
            if (channel != null)
            {
                channel.Send(recipient, subject, message);
            }
            else
            {
                throw new ArgumentException($"Notification channel '{channelType}' not found.");
            }
        }
    }
}