using DelegateVsInterface;

IMessenger messenger = new SmsService();
messenger.SendMessage("Say Hello From Interface Project", "+989000000000");