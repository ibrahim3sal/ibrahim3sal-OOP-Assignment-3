namespace RefactoringLab;

public class PushNotification : INotificationChannel
{
    public void Send(string to, string message, DateTime? sendAt)
    {
        if (sendAt.HasValue)
        {
            Console.WriteLine(
                $"[push scheduled {sendAt.Value:g}] {to}: {message}");
            return;
        }

        Console.WriteLine($"[push] {to}: {message}");
    }
}