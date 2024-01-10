namespace DelegateVsInterface;

internal interface IMessenger
{
    bool SendMessage(string message, string phoneNumber);
}

