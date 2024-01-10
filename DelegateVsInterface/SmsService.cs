namespace DelegateVsInterface;

internal class SmsService : IMessenger
{
    public bool SendMessage(string message, string phoneNumber)
    {
        Console.WriteLine($"SMS to {phoneNumber}: {message}");
        return true;
    }
}
