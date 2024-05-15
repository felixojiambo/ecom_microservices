using Mserve.Services.RewardAPI.Message;

namespace Mserve.Services.RewardAPI.Services
{
    public interface IRewardService
    {
        Task UpdateRewards(RewardsMessage rewardsMessage);
    }
}
