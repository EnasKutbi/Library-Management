public class SMSNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string successMessage)
    {
        Console.WriteLine($"SMS notification on success : {successMessage}");
    }
    public void SendNotificationOnFailure(string failureMessage)
    {
        Console.WriteLine($"SMS notification on failure : {failureMessage}");
    }
}