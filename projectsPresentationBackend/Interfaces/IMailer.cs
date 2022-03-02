using ArchitecturalProjectsBackend.Models;
using System.Threading.Tasks;

namespace ArchitecturalProjectsBackend.Interfaces
{
    public interface IMailer
    {
        Task SendEmailAsync(ContactFormUserInfo userInfo);
    }
}