public interface INotificationService {
    void SendNotificationOnSuccess(string successMessage);
    void SendNotificationOnFailure(string failureMessage);
}