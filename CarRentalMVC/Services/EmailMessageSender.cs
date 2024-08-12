namespace CarRentalMVC.Services;

public class EmailMessageSender : IMessageSender
{
    public string Send()
    {
        return "Send by Email";
    }
}

