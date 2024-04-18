public class EmailNotificationService : INotificationService
{
    public void SendNotificationOnSuccess(string successMessage){
        Console.WriteLine($"Email notification on success : {successMessage}");
    }
    public void SendNotificationOnFailure(string failureMessage){
        Console.WriteLine($"Email notification on failure : {failureMessage}");
    }
}