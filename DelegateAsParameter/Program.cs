#region Send Methods
bool SendBySMS(string message, string phoneNumber)
{
    Console.WriteLine($"SMS to {phoneNumber}: {message}");
    return true;
}

bool SendByTelegram(string message, string phoneNumber)
{
    Console.WriteLine($"Telegram to {phoneNumber}: {message}");
    return true;
}

bool SendByWhatsapp(string message, string phoneNumber)
{
    Console.WriteLine($"Whatsapp to {phoneNumber}: {message}");
    return true;
}

void SendWhitoutResponse(string message, string phoneNumber)
{
    Console.WriteLine($"UnknownMessenger to {phoneNumber}: {message}");
}

#endregion

SendMessage(SendBySMS, "Say Hello From SendMessage Method", "+989000000000");

//SendByMultipleMessenger(Messengers.Whatsapp | Messengers.Telegram, "Say Hello From SendByMultipleMessenger Method", "+989000000000");

//SendMessageByFunc(SendByTelegram, "Say Hello From SendMessageByFunc Method", "+989000000000");

//SendMessageByAction(SendWhitoutResponse, "Say Hello From SendMessageByFunc Method", "+989000000000");

bool SendMessage(SendMessageDelegate delegateInstance, string message, string phoneNumber)
{
    return delegateInstance(message, phoneNumber);
}

bool SendByMultipleMessenger(Messengers messengers, string message, string phoneNumber)
{
    var delegateInstance = GetMessengers(messengers);
    return delegateInstance(message, phoneNumber);
}

bool SendMessageByFunc(Func<string, string, bool> func, string message, string phoneNumber)
{
    return func(message, phoneNumber);
}

void SendMessageByAction(Action<string, string> action, string message, string phoneNumber)
{
    action(message, phoneNumber);
}


SendMessageDelegate GetMessengers(Messengers messengers)
{
    SendMessageDelegate result = SendBySMS;

    if (messengers.HasFlag(Messengers.SMS) == false)
    {
        result -= SendBySMS;
    }
    if (messengers.HasFlag(Messengers.Telegram))
    {
        result += SendByTelegram;
    }
    if (messengers.HasFlag(Messengers.Whatsapp))
    {
        result += SendByWhatsapp;
    }

    return result;
}

delegate bool SendMessageDelegate(string message, string phoneNumber);

enum Messengers
{
    SMS = 1 << 0,
    Telegram = 1 << 1,
    Whatsapp = 1 << 2,
}