namespace DelegateVsInterface;

internal class TelegramService : IMessenger
{
    public bool SendMessage(string message, string phoneNumber)
    {
        Console.WriteLine($"Telegram to {phoneNumber}: {message}");
        return true;
    }
}
