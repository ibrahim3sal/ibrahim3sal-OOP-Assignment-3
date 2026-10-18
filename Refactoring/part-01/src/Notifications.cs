namespace RefactoringLab;

public interface INotificationChannel
{
    void Send(string to, string message, DateTime? sendAt);
}

public class EmailNotification : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[email scheduled {sendAt.Value:g}] {to}: {message}");
            return;
        }

        Console.WriteLine($"[email] {to}: {message}");
    }
}

public class SmsNotification : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[sms scheduled {sendAt.Value:g}] {to}: {message}");
            return;
        }

        Console.WriteLine($"[sms] {to}: {message}");
    }
}

public class Notification
{
    private readonly INotificationChannel _channel;

    public Notification(INotificationChannel channel)
    {
        _channel = channel;
    }

    public void Send(
        string to,
        string message,
        bool urgent = false,
        DateTime? sendAt = null)
    {
        if (urgent)
        {
            message = $"[URGENT] {message}";
        }

        _channel.Send(to, message, sendAt);
    }
}