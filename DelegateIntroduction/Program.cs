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


SimpleDelegate();


void SimpleDelegate()
{
    SendMessageDelegate delegateInstance = SendBySMS;
    delegateInstance("Hello From Simple Delegate", "+989000000000");
}

void MulticastDelegate()
{
    SendMessageDelegate delegateInstance = SendBySMS;
    delegateInstance += SendByWhatsapp;
    delegateInstance += SendByTelegram;
    delegateInstance("Hello From Multicast Delegate", "+989000000000");
}

void AnonymousFunction()
{
    SendMessageDelegate delegateInstance = (string msg, string pNum) =>
    {
        Console.WriteLine($"CS_Messenger to {pNum}: {msg}");
        return true;
    };

    delegateInstance("Hello From Anonymous Function", "+989000000000");
}

delegate bool SendMessageDelegate(string message, string phoneNumber);
