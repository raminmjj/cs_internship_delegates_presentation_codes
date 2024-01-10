namespace DelegateVsInterface;

internal class WhatsappService : IMessenger
{
    public bool SendMessage(string message, string phoneNumber)
    {
        Console.WriteLine($"Whatsapp to {phoneNumber}: {message}");
        return true;
    }
}
