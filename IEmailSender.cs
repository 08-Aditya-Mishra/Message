using SmsProject;

namespace SmsProject
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
