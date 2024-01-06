namespace Lumos.Domain.Models;

public class SupportChatMessage
{
    public int SupportChatId { get; set; }
    public int UserId { get; set; }
    public int ManagerId { get; set; }
    public string Message { get; set; }
    public DateTime Date { get; set; }
    public MessageSender Sender { get; set; }
}

public enum MessageSender
{
    User,
    Manager
}