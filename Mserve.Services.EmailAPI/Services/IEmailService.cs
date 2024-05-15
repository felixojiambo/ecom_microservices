using Mserve.Services.EmailAPI.Message;
using Mserve.Services.EmailAPI.Models.Dto;

namespace Mserve.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
